using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEI_CRM.PAGES
{
    public partial class project_page : Form
    {
        public class project_details
        {
            public string project_name { get; set; }
            public string project_start_date { get; set; }
            public string project_due_date { get; set; }
            public int project_progress_percent { get; set; }
            public string project_status { get; set; }
            public string project_department { get; set; }

        };
        HashSet<string> projects = new HashSet<string>();
        public class user_info
        {
            public string name;
            public string email;
            public string department;
            public string user_id;

        }
        user_info current_user = new user_info();
        private bool is_head;
        private string current_page = "PROJECTS";
        private string current_user_projects;
        private int user_id = Properties.Settings.Default.active_user;


        string constring = Properties.Settings.Default.constring;
        public project_page()
        {
            InitializeComponent();
            navbar1.navigation_current_page(current_page);
        }
   

        private void projects_Load(object sender, EventArgs e)
        {
            load_user_info();
            //MessageBox.Show(current_user.name + current_user.department + current_user.user_id +is_head);
            load_existing_projects();
            if (current_user_projects == null)
            {

                welcome_panel_no_project.Visible = true;
                Project_sorting_table.Visible = false;
                project_main_table.Visible = false;
                project_add_project_button.Visible = false;
            }
            else {
                welcome_panel_no_project.Visible = false;
                Project_sorting_table.Visible = true;
                project_main_table.Visible = true;
                project_add_project_button.Visible = true;
            }
            sorters();
            view_all_projects();

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
                        using (MySqlDataReader reader = cmd.ExecuteReader())
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
                    MessageBox.Show("User info1 : " + ex.Message);
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
                    MessageBox.Show("User info2: " + ex.Message);
                }
            }


        }

        private string check_dept(string dept)
        {
            string temp = "";
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



        private void load_existing_projects()
        {

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    string command;
                    if (is_head)
                    {
                        if (current_user.name == "ADMIN")
                        {
                            command = "SELECT * FROM projects ";

                        }
                        else
                        {
                            //filter per department 
                            command = "SELECT * FROM projects WHERE project_department = @department ";
                        }
                     

                        
                    }
                    else
                    {

                        command = "SELECT * FROM projects WHERE project_handler LIKE @id AND project_department = @department";
                    }
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(command, con))
                    {
                        cmd.Parameters.AddWithValue("@id", "%" + current_user.user_id + ",%");
                        cmd.Parameters.AddWithValue("@department", current_user.department);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                current_user_projects += reader["project_name"] + ",";
                                //text_box_mod1.Texts += reader["project_name"] + Environment.NewLine;

                            }
                        }

                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }
        private void sorters() 
        {
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {

                    con.Open();
                    string loadcommand;
                    if (is_head )
                    {
                        if (current_user.name == "ADMIN")
                        {
                            loadcommand = "SELECT * FROM projects";
                        }
                        else 
                        {
                            //filter per project
                        }
                        loadcommand = "SELECT * FROM projects WHERE project_department = @department";
                        

                    }
                    else 
                    {

                        loadcommand = "SELECT * FROM projects WHERE project_handler LIKE @id AND project_department = @department";
                    }
                    //MessageBox.Show(loadcommand + current_user.department);
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                    {
                        cmd.Parameters.AddWithValue("@id", "%" + current_user.user_id + ",%");
                        cmd.Parameters.AddWithValue("@department", current_user.department);
                      
                        using (MySqlDataReader reader = cmd.ExecuteReader()) 
                        {
                            foreach (string project_name in project_sorter_project_name_box.Items) 
                            {
                                projects.Add(project_name);
                            }
                            projects.Add("Projects(ALL)");
                            project_sorter_project_name_box.Items.Add("Projects (ALL)");
                            while (reader.Read())
                            {
                                string project_name = reader["project_name"].ToString();
                                if (projects.Count == 0)
                                {
                                    projects.Add(project_name);
                                    project_sorter_project_name_box.Items.Add(project_name);
                                }

                                else if (!projects.Contains(project_name))
                                {
                                    projects.Add(project_name);
                                    project_sorter_project_name_box.Items.Add(project_name);
                                }
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
           
        }
        private void view_all_projects() 
        {
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {

                    con.Open();
                    string load_command;
                    if (is_head )
                    {
                        if (current_user.name == "ADMIN")
                        {
                            //no filter
                            load_command = "SELECT * FROM projects WHERE project_status LIKE @project_status AND project_name LIKE @project_name";
                        }
                        else 
                        {
                            //filter per dept
                            load_command = "SELECT * FROM projects WHERE project_status LIKE @project_status AND project_name LIKE @project_name AND project_department = @project_department";
                        }
                            

                    }
                    else
                    {
                        load_command = "SELECT * FROM projects WHERE project_handler LIKE @id AND project_status LIKE @project_status AND project_name LIKE @project_name AND project_department = @project_department";

                    }
                    //load_command = "SELECT * FROM tasks WHERE task_members LIKE @id"
                    //MessageBox.Show(load_command);
                    using (MySqlCommand cmd = new MySqlCommand(load_command, con))
                    {
                        cmd.Parameters.AddWithValue("@id", "%" + current_user.user_id + ",%");
                        cmd.Parameters.AddWithValue("@project_department",current_user.department);

                        if (project_sorter_status_box.Texts == "Status (ALL)")
                        {
                            cmd.Parameters.AddWithValue("@project_status", "%" + "%");
                        }
                        else 
                        {
                            cmd.Parameters.AddWithValue("@project_status", "%" + project_sorter_status_box.Texts + "%");
                        }
                        if (project_sorter_project_name_box.Texts == "Projects (ALL)")
                        {
                            cmd.Parameters.AddWithValue("@project_name", "%" + "%");
                        }
                        else 
                        {
                            cmd.Parameters.AddWithValue("@project_name", "%" + project_sorter_project_name_box.Texts + "%");
                        }
                        





                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            flowLayoutPanel1.Controls.Clear();
                            HashSet<string> projects = new HashSet<string>();


                            foreach (string project_Name in project_sorter_project_name_box.Items)
                            {
                                projects.Add(project_Name);
                            }

                            int yOffset = 0;
                            while (reader.Read())
                            {
                                
                                string project_project_name = reader["project_name"].ToString();
                                if (projects.Count == 0)
                                {

                                    project_sorter_project_name_box.Items.Add(project_project_name);
                                    projects.Add(project_project_name);
                                }
                                if (!projects.Contains(project_project_name))
                                {
                                    project_sorter_project_name_box.Items.Add(project_project_name);
                                    projects.Add(project_project_name);

                                }

                                var current_project = new project_details

                                {
                                    project_name = reader["project_name"].ToString(),
                                    project_start_date = reader["project_start_date"].ToString(),
                                    project_due_date = reader["project_due_date"].ToString(),
                                    //project_progress_percent = (int)reader["project_progress_percent"],

                                    project_progress_percent = (int)load_project_progress_percent(project_project_name),
                                    project_department = reader["project_department"].ToString(),
                                    project_status = reader["project_status"].ToString()
                                };

                                string project_json = JsonSerializer.Serialize(current_project);
                                page_table table = new page_table
                                {
                                    Location = new Point(10, yOffset)


                                };
                                flowLayoutPanel1.Controls.Add(table);
                                table.update_values(project_json);
                                yOffset += table.Height + 10;


                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();

            }



        }

        private float load_project_progress_percent(string project_name)
        {
            float total_tasks = 0, finished_tasks = 0;
            string load_command;
            float progress_percent = 0;

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    load_command = "SELECT COUNT(*) FROM tasks WHERE task_project = @project_name";
                    using (MySqlCommand cmd = new MySqlCommand(load_command, con))
                    {
                        cmd.Parameters.AddWithValue("@project_name", project_name);

                        total_tasks = Convert.ToInt32(cmd.ExecuteScalar());
                      
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    load_command = "SELECT COUNT(*) FROM tasks WHERE task_project = @project_name AND task_status = @task_status";
                    using (MySqlCommand cmd = new MySqlCommand(load_command, con))
                    {
                        cmd.Parameters.AddWithValue("@project_name", project_name);
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
                progress_percent = 0;
            }
            else
            {
                progress_percent = (float)((finished_tasks / total_tasks) * 100);
           
            }

            using (MySqlConnection con = new MySqlConnection(constring)) 
            {
                try
                { 
                    con.Open();
                    load_command = "UPDATE projects SET project_progress_percent = @project_progress_percent WHERE project_name = @project_name";
                    using(MySqlCommand cmd  = new MySqlCommand(load_command, con)) 
                    {
                        cmd.Parameters.AddWithValue("@project_progress_percent", progress_percent);
                        cmd.Parameters.AddWithValue("@project_name", project_name);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }





                return progress_percent;

        }






        private void project_add_project_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form project_add_project = new PAGES.project_add_project();
            project_add_project.ShowDialog();
            this.Close();

        }

        private void welcome_panel_no_project_add_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form project_add_project = new PAGES.project_add_project();
            project_add_project.ShowDialog();
            this.Close();
        }

        private void project_sorter_project_name_box_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            view_all_projects();
        }

        private void project_sorter_status_box_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            view_all_projects();
        }

        private void project_sorter_department_box_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            view_all_projects();
        }
    }
}
