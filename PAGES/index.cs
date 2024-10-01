using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using EEI_CRM.PAGES;
using System.Threading;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;
using Org.BouncyCastle.Pqc.Crypto.Bike;
namespace EEI_CRM
{

    public partial class index : Form
    {
        StringBuilder projects_notif = new StringBuilder();
        StringBuilder tasks_notif = new StringBuilder();
        StringBuilder tasks_id = new StringBuilder();
        string constring = Properties.Settings.Default.constring;
        private int project_search, client_search;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        //private string for current details
        private string current_window = "DASHBOARD";
        public string current_project;
        private string current_user_name;
        private int user_id = Properties.Settings.Default.active_user;
        public string current_project_status = "ONGOING";
        bool is_head;
        int unverified_accounts;
        string department;

        private int task_counter;

        public class user_info 
        {
            public string name;
            public string email;
            public string department;
            public string user_id;
    
        }
        user_info current_user = new user_info();
        public class AddProject
        {
            public string project_name { get; set; }
            public string project_cost { get; set; }
            public string project_status { get; set; }


        }
        public index()
        {
            InitializeComponent();
            Form splash = new load_screen();


        }
        public string return_current_page()
        {
            return current_window;

        }


        private void index_Load(object sender, EventArgs e)
        {
            load_user_info();

            load_project_panel();
            load_search_bar();
            load_notification();
            if ((unverified_accounts != 0) || notification_new_project_box.Texts != "" || notification_new_tasks_panel.Texts != "")
            {
                notification_bell_button.BackColor = Color.OrangeRed;
            }
            else 
            {
                notification_bell_button.BackColor = Color.Transparent;
            }
            navbar1.navigation_current_page(current_window);
            index_current_page_label.Text = current_window;

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string load_command;
                    if (user_id == 0)
                    {

                        load_command = "SELECT * FROM users";
                    }
                    else
                    {


                        load_command = "SELECT * FROM users WHERE id = @idnumber";
                    }
                    using (MySqlCommand cmd = new MySqlCommand(load_command, con))
                    {
                        cmd.Parameters.AddWithValue("@idnumber", current_user.user_id);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string current_user = reader["name"].ToString();
                                string current_position = reader["position"].ToString();
                                user_id = (int)reader["id"];
                                current_user_label.Text = current_user;
                                current_position_label.Text = current_position;

                            }

                            else
                            {

                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Index load: " + ex.Message);
                }
            }

        }
        private void load_user_info()
        {
            using (MySqlConnection con = new MySqlConnection(constring)) 
            {
                try 
                {
                    con.Open();
                    string loadcommand = "SELECT * FROM users WHERE id = @user_id";
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con)) 
                    {
                        cmd.Parameters.AddWithValue("@user_id", user_id);
                        using (MySqlDataReader reader =  cmd.ExecuteReader()) 
                        {
                            if (reader.Read()) 
                            {
                                current_user.name = reader["name"].ToString();
                                current_user.email = reader["email"].ToString();
                                current_user.department = reader["department"].ToString();
                                current_user.user_id = reader["id"].ToString();
                            }

                        }

                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("User info : " + ex.Message);
                }

            }
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string loadcommand = "SELECT * FROM department";
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                    {

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (current_user.name == reader[check_dept(current_user.department)].ToString())
                                {
                                    is_head = true;
                                    //MessageBox.Show("HEAD");
                                }
                                else
                                {
                                    is_head = false;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("User info: " + ex.Message);
                }
            }


        }
        private void notification_bell_button_Click(object sender, EventArgs e)
        {
            if (notification_panel.Visible) 
            {
              notification_panel.Visible = false;
            }
            notification_panel.Visible = true;
            projects_notif.Clear();
            tasks_notif.Clear();
            tasks_id.Clear();   
        }
   
            
      

           

            //check if head


            //check 
            

        
        
        private string check_dept(string dept)
        {
            string temp ="";
            switch (dept) 
            {
                case "General Manager":
                    temp = "gm";
                    break;
                case "GENERAL SERVICES AND MARKETING":
                    temp = "gsm";
                    break;
                case "TECHNICAL SERVICE GROUP":
                    temp = "tsg";
                    break;
                case "REGULATORY AFFAIRS":
                    temp = "ra";
                    break;
                case "OPERATIONS AND INNOVATIONS":
                    temp = "oi";
                    break;
                case "STRATEGY AND PLANNING":
                    temp = "sp";
                    break;
                case "SOLAR BUSINESS UNIT":
                    temp = "sbu";
                    break;
                case "POWER CONTRACTING GROUP":
                    temp = "pcg";
                    break;
                case "ENERGY EFFICIENCY SERVICES":
                    temp = "ees";
                    break;
                case "POWER GENERATION BUSINESS DEV/RES":
                    temp = "pgb";
                    break;
                case "ADMIN":
                    temp = "ADMIN";
                    break;
                default:
                    temp = "";
                    break;
            }

            return temp;
        }
        private void load_notification() 
        {
            string today = DateTime.Today.ToShortDateString(); // YYYY-MM-DD
             unverified_accounts = 0;
            notification_new_project_box.Texts = "";

            if (is_head || current_user.name == "ADMIN")
            {
                //load new users -- >> only if head and own department
                using (MySqlConnection con = new MySqlConnection(constring))
                {
                    try
                    {
                        con.Open();
                        string loadcommand;
                        if (current_user.name == "ADMIN")
                        {
                            loadcommand = "SELECT COUNT(*) FROM users  WHERE state = @state ";

                        }
                        else
                        {
                            loadcommand = "SELECT COUNT(*) FROM users  WHERE state = @state AND department = @department";

                        }
                        using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                        {

                            cmd.Parameters.AddWithValue("@state", "unverified");
                            if (current_user.name != "ADMIN")
                            {
                                cmd.Parameters.AddWithValue("@department", current_user.department);
                            }
                            else 
                            {
                                ;
                            }
                            unverified_accounts = Convert.ToInt32(cmd.ExecuteScalar());
                            unverified_count.Text = unverified_accounts.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("first_loop" + ex.Message);
                    }
                }

            }
            else 
            {
                unverified_count.Text = "Account do not have access";
            }
            //load new projects -->> today -->> assigned
            using (MySqlConnection con  =  new MySqlConnection(constring)) 
            {
                string loadcommand;
                int project_count = 1;
                try 
                {
                    con.Open();
                    //check if head
                    if (is_head)
                    {
                        if (current_user.name == "ADMIN")
                        {
                            loadcommand = "SELECT * FROM projects WHERE project_start_date LIKE @today";

                        }
                        else
                        {
                            loadcommand = "SELECT * FROM projects WHERE project_department LIKE @department AND project_start_date LIKE @today";
                        }
                    }
                    else
                    {
                        loadcommand = "SELECT * FROM projects WHERE project_handler LIKE @project_handler AND project_start_date LIKE @today";

                    }

                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con)) 
                    {
                        cmd.Parameters.AddWithValue("@project_handler", "%" + user_id + ",%");
                        cmd.Parameters.AddWithValue("@today", "%" + today + "%");
                        cmd.Parameters.AddWithValue("@department", "%" + current_user.department + "%");
                        Console.WriteLine(today);
                        using (MySqlDataReader reader =  cmd.ExecuteReader()) 
                        {
                            while (reader.Read()) 
                            {
                                projects_notif.AppendLine(project_count + ": " + reader["project_name"].ToString());
                                project_count++;
                            }
                        }
                    }
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("second_loop" + ex.Message);
                }

                notification_new_project_box.Texts = projects_notif.ToString();
            }

            //load new tasks assigned
             string[] date = today.Split('-');
             string month = date[1];

            using (MySqlConnection con =  new MySqlConnection(constring))
            {
                notification_new_tasks_panel.Texts = "";
          
                 task_counter = 1;
                try 
                {
                    con.Open();
                    string loadcommand = "SELECT * FROM tasks WHERE acknowledged = @acknowledged AND task_members LIKE @user";
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                    {
                        cmd.Parameters.AddWithValue("@acknowledged", 0);
                        cmd.Parameters.AddWithValue("@user", "%" + user_id + ",%");
                        using (MySqlDataReader reader = cmd.ExecuteReader()) 
                        {
                            while (reader.Read()) 
                            {
                                string[] task_start_date = (reader["task_start_date"].ToString()).Split('-');
                                string task_month = task_start_date[1];
                                //MessageBox.Show(task_month + "|" + month);
                                if (task_month == month) 
                                {
                                    //same month, add the task
                                    tasks_notif.AppendLine(task_counter + ": " + reader["task_name"].ToString() + " - " + reader["task_project"].ToString());
                                    tasks_id.Append((int)reader["task_id"] + ",");
                                    
                                    task_counter++;
                                    

                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("third_loop" + ex.Message);
                }
                notification_new_tasks_panel.Texts = tasks_notif.ToString();
            }


        }

        private void notif_acknowledge_button_Click(object sender, EventArgs e)
        {
            string today = DateTime.Today.ToShortDateString(); // YYYY-MM-DD
            string[] task_notif_list = (tasks_id.ToString()).Split(',') ;
            string[] date = today.Split('-');
            string month = date[1];
            //acknowdledge the tasks at notification_new_tasks_panel
            for (int i = 0; i < task_counter; i++)
            {
                using (MySqlConnection con = new MySqlConnection(constring))
                {
                    try
                    {
                        con.Open();
                        string loadcommand = "UPDATE tasks SET acknowledged = @acknowledged WHERE task_members LIKE @user AND task_id = @task_id";
                        using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                        {


                            cmd.Parameters.AddWithValue("@acknowledged", true);
                            cmd.Parameters.AddWithValue("@task_id", task_notif_list[i]);
                            cmd.Parameters.AddWithValue("@user", "%" + user_id + ",%");
                            cmd.ExecuteNonQuery();


                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            this.Hide();
            Form index = new index();
            index.ShowDialog();
            this.Close();

        }
        private int load_project_panel()
        {
            Console.WriteLine(user_id);

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    string command;
                    if (current_user.name == "ADMIN")
                    {
                        command = "SELECT * FROM projects";
             
                    }
                    else if (is_head && current_user.name != "ADMIN") 
                    {
                        command = "SELECT * FROM projects WHERE project_department = @department";
                    
                    }
                    else
                    {
                        command = "SELECT * FROM projects where project_handler LIKE @id";
              

                    }


                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(command, con))
                    {
                        if (is_head)
                        {
                            cmd.Parameters.AddWithValue("@department", current_user.department);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@id", "%" + user_id + ",%");

                        }


                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            int yOffset = 50; // Initial Y offset for the first panel
                            while (reader.Read())
                            {
                                var project = new AddProject
                                {
                                    project_name = reader["project_name"].ToString(),
                                    project_status = reader["project_status"].ToString(),
                                    project_cost = reader["project_cost"].ToString()
                                };
                                string json_project = JsonSerializer.Serialize(project);


                                index_perproject_panel panel = new index_perproject_panel
                                {
                                    Location = new Point(10, yOffset),
                                    BackColor = Color.White
                                };

                                flowLayoutPanel2.Controls.Add(panel);
                                panel.update_value(json_project);
                                yOffset += panel.Height + 10; // Adjust Y offset for the next panel
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log or handle the exception
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
            flowLayoutPanel2.WrapContents = false;
            flowLayoutPanel2.AutoScroll = true;


            return 0;

        }
        private void load_search_bar()
        {
            project_search = 0;
            client_search = 0;
           
            search_bar_box.Items.Clear();
            string loadcommand;
            //MessageBox.Show(search_content);
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    loadcommand = "SELECT * FROM projects";
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                    {
                       
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string content = reader["project_name"].ToString();
                                if (content != "")
                                {
                                    search_bar_box.Items.Add(content);
                                    project_search++;

                                }

                            }
                        }
                    }
                    client_search = project_search + 1;
                    loadcommand = "SELECT * FROM clients ";
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string content = reader["client_name"].ToString();
                                if (content != "")
                                {
                                    search_bar_box.Items.Add(content);
                                    client_search++;

                                }

                            }
                        }

                    }
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }
        public void load_chart_panel()
        {
            float elec_perc = load_chart_elec();
            float csa_perc = load_chart_csa();
            float mech_pec = load_chart_mech();
            elec_work_progress_bar.Value = (int)(elec_perc * elec_work_progress_bar.Max_Val);
            csa_work_progress_bar.Value = (int)(csa_perc * csa_work_progress_bar.Max_Val);
            mechanical_work_progress_bar.Value = (int)(mech_pec * mechanical_work_progress_bar.Max_Val);
            //Console.WriteLine(elec_work_progress_bar.Value.ToString());
            EW_Chart_percent.Text = elec_work_progress_bar.Value.ToString() + "%";
            CSA_Chart_percent.Text = csa_work_progress_bar.Value.ToString() + "%";
            MW_Chart_percent.Text = mechanical_work_progress_bar.Value.ToString() + "%";
            if (elec_work_progress_bar.Value == 100 && csa_work_progress_bar.Value == 100 && mechanical_work_progress_bar.Value == 100)
            {
                current_project_status = "FINISHED";
            }
            else
            {
                current_project_status = "ONGOING";
            }

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string loadcommand = "UPDATE projects SET project_status = @project_status WHERE project_name = @project_name";
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                    {
                        cmd.Parameters.AddWithValue("@project_status", current_project_status);
                        cmd.Parameters.AddWithValue("@project_name", current_project);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //load the chart value of elec works

        private float load_chart_elec()
        {
            float perc = 00.00F;
            float total_tasks = 0;
            float finished_tasks = 0;
            //read number of tasks available
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string loadcommand = "SELECT COUNT(*) FROM tasks WHERE task_project = @project_name AND task_group = @task_group;";
                    //string loadcommand = ""
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                    {
                        cmd.Parameters.AddWithValue("@project_name", current_project);
                        cmd.Parameters.AddWithValue("@task_group", "Electrical Works");
                        total_tasks = Convert.ToInt32(cmd.ExecuteScalar());


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
            //read finished tasks
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string loadcommand = "SELECT COUNT(*) FROM tasks WHERE task_project = @project_name AND task_group = @task_group AND task_status = @task_status;";
                    //string loadcommand = ""
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                    {
                        cmd.Parameters.AddWithValue("@project_name", current_project);
                        cmd.Parameters.AddWithValue("@task_group", "Electrical Works");
                        cmd.Parameters.AddWithValue("@task_status", "Finished");
                        finished_tasks = Convert.ToInt32(cmd.ExecuteScalar());


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
            if (finished_tasks == 0)
            {
                perc = 0;
            }
            else
            {
                perc = (float)(finished_tasks / total_tasks);

            }



            return perc;
        }
        private float load_chart_csa()
        {
            float perc = 00.00F;
            float total_tasks = 0;
            float finished_tasks = 0;
            //read number of tasks available
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string loadcommand = "SELECT COUNT(*) FROM tasks WHERE task_project = @project_name AND task_group = @task_group;";
                    //string loadcommand = ""
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                    {
                        cmd.Parameters.AddWithValue("@project_name", current_project);
                        cmd.Parameters.AddWithValue("@task_group", "Civil, Structural and Architectural Works");
                        total_tasks = Convert.ToInt32(cmd.ExecuteScalar());


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
            //read finished tasks
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string loadcommand = "SELECT COUNT(*) FROM tasks WHERE task_project = @project_name AND task_group = @task_group AND task_status = @task_status;";
                    //string loadcommand = ""
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                    {
                        cmd.Parameters.AddWithValue("@project_name", current_project);
                        cmd.Parameters.AddWithValue("@task_group", "Civil, Structural and Architectural Works");
                        cmd.Parameters.AddWithValue("@task_status", "Finished");
                        finished_tasks = Convert.ToInt32(cmd.ExecuteScalar());


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }


            if (finished_tasks == 0)
            {
                perc = 0;
            }
            else
            {
                perc = (float)(finished_tasks / total_tasks);

            }



            return perc;
        }
        private float load_chart_mech()
        {
            float perc = 00.00F;
            float total_tasks = 0;
            float finished_tasks = 0;
            //read number of tasks available
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string loadcommand = "SELECT COUNT(*) FROM tasks WHERE task_project = @project_name AND task_group = @task_group;";
                    //string loadcommand = ""
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                    {
                        cmd.Parameters.AddWithValue("@project_name", current_project);
                        cmd.Parameters.AddWithValue("@task_group", "Mechanical Works");
                        total_tasks = Convert.ToInt32(cmd.ExecuteScalar());

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
            //read finished tasks
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string loadcommand = "SELECT COUNT(*) FROM tasks WHERE task_project = @project_name AND task_group = @task_group AND task_status = @task_status;";
                    //string loadcommand = ""
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                    {
                        cmd.Parameters.AddWithValue("@project_name", current_project);
                        cmd.Parameters.AddWithValue("@task_group", "Mechanical Works");
                        cmd.Parameters.AddWithValue("@task_status", "Finished");
                        finished_tasks = Convert.ToInt32(cmd.ExecuteScalar());


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }


            if (finished_tasks == 0)
            {
                perc = 0;
            }
            else
            {
                perc = (float)(finished_tasks / total_tasks);

            }



            return perc;
        }
        private void index_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;

        }

        private void index_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void index_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }



        private void dashboard_projects_panel_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form projects = new PAGES.project_page();
            projects.ShowDialog();
            this.Close();

        }

        private void dashboard_project_panel_button_MouseEnter(object sender, EventArgs e)
        {
            dashboard_project_panel_button.BackColor = Color.WhiteSmoke;
        }
        private void dashboard_project_panel_button_MouseLeave(object sender, EventArgs e)
        {

            dashboard_project_panel_button.BackColor = Color.Transparent;
        }

        private void dash_project_panel_Scroll(object sender, ScrollEventArgs e)
        {

            //dash_project_panel.ScrollControlIntoView(this);
        }
        public void dashboard_update_data(string project_name)
        {
            index_project_name_label1.Text = project_name;
            index_project_name_label2.Text = project_name;
            current_project = project_name;


        }

        private void label5_Click(object sender, EventArgs e) { }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void notification_panel_Paint(object sender, PaintEventArgs e)
        {

        }



        private void search_bar_box_OnSelectedIndexChanged(object sender, EventArgs e)
        {
           

            //MessageBox.Show( project_search.ToString()+""+ search_bar_box.SelectedIndex.ToString());
            string search;
            search = search_bar_box.Texts;
            if (search_bar_box.SelectedIndex < project_search)
            {
                this.Hide();
                Form project_info = new project_details(search_bar_box.Texts);
                project_info.ShowDialog();
                this.Close();
            }
            else 
            {
                this.Hide();
                Form client_info = new client_profile(search_bar_box.Texts);
                client_info.ShowDialog();
                this.Close();
            }
        }
    }
}
