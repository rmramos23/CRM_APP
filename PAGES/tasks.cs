using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.Json;
using System.Xml;

namespace EEI_CRM
{

    public partial class tasks : Form
    {
        HashSet<string> projects = new HashSet<string>();
        private string constring = Properties.Settings.Default.constring;
        private int user_id = Properties.Settings.Default.active_user;
        private string current_page = "TASKS";
        private int number_of_tasks;
        private class TaskDetails {
            public string task_name {  get; set; }
            public string task_group { get; set; }
            public string task_category { get; set; }
            public string task_due_date { get; set; }
            public string task_status { get; set; }
            public string task_project { get; set; }
            public string task_priority { get; set; }
            public bool is_sort_state { get; set; }


        }
        public class user_info
        {
            public string name;
            public string email;
            public string department;
            public string user_id;

        }
        user_info current_user = new user_info();
        private bool is_head;
        public tasks()
        {
            InitializeComponent();
            navbar1.navigation_current_page(current_page);
        }





        private void tasks_Load(object sender, EventArgs e)
        {
            tasks_current_page_label.Text = current_page;
            load_user_info();
            task_counter();
            sorters();
            view_all_task();
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.AutoScroll = true;
            //string task_sorting_content = "";

            if (number_of_tasks != 0)
            {
                welcome_panel_no_task.Visible = false;
                task_sorting_table_panel.Visible = true;
                task_main_table_panel.Visible = true;
                task_existing_task_add_button.Visible = true;
                //view_all_task();
            }
            else
            {

                welcome_panel_no_task.Visible = true;
                task_sorting_table_panel.Visible = false;
                task_main_table_panel.Visible = false;  
                task_existing_task_add_button.Visible = false;

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

        private void sorters() {

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {

                    string loadcommand;
                    con.Open();
                    if (is_head || current_user.name == "ADMIN")
                    {

                        loadcommand = "SELECT * FROM tasks ";
                    }
                    else
                    {
                        loadcommand = "SELECT * FROM tasks WHERE task_members LIKE @id";
                    }
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                    {
                        cmd.Parameters.AddWithValue("@id", "%" + current_user.user_id + ",%");
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            
                            foreach (string project_Name in task_sorter_project_box.Items)
                            {
                                projects.Add(project_Name);
                            }


                            projects.Add("Projects(ALL)");
                            task_sorter_project_box.Items.Add("Projects(ALL)");
                            while (reader.Read())
                            {
                                string task_project_name = reader["task_project"].ToString();
                                if (projects.Count == 0)
                                {

                                    task_sorter_project_box.Items.Add(task_project_name);
                                    projects.Add(task_project_name);
                                }
                                if (!projects.Contains(task_project_name))
                                {
                                    task_sorter_project_box.Items.Add(task_project_name);
                                    projects.Add(task_project_name);

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
        private void task_counter() 
        {

            //look for tasks of current user
            //load database for tasks
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {

                    string loadcommand;

                    con.Open();
                    if (is_head)
                    {

                        loadcommand = "SELECT * FROM tasks ";


                    }
                    else 
                    {

                         loadcommand = "SELECT * FROM tasks WHERE task_members LIKE @id";
                    }
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                    {
                        cmd.Parameters.AddWithValue("@id", "%" + current_user.user_id + ",%");
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                

                                number_of_tasks += 1;

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
        public void view_all_task()
        {
            
          
            using (MySqlConnection con = new MySqlConnection(constring)) 
            {
                try
                {

                    con.Open();
                    string load_command;
                    if (is_head)
                    {
                        load_command = "SELECT * FROM tasks";
                    }
                    else 
                    {
                        load_command = "SELECT * FROM tasks WHERE task_members LIKE @id AND task_group LIKE @group AND task_project LIKE @project";
                    }
                   
                    //load_command = "SELECT * FROM tasks WHERE task_members LIKE @id";
                    using (MySqlCommand cmd = new MySqlCommand(load_command, con))
                    {

                        cmd.Parameters.AddWithValue("@id", "%" + current_user.user_id + ",%");
                        if (task_sorter_group_box.Texts == "Task Group(ALL)")
                        {
                            cmd.Parameters.AddWithValue("@group", "%%");
                        }
                        else 
                        {
                            cmd.Parameters.AddWithValue("@group", "%" + task_sorter_group_box.Texts + "%");
                        }
                        if (task_sorter_project_box.Texts == "Projects(ALL)")
                        {
                            cmd.Parameters.AddWithValue("@project", "%%");
                        }
                        else 
                        {
                            cmd.Parameters.AddWithValue("@project", "%" + task_sorter_project_box.Texts + "%");
                        }

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            flowLayoutPanel1.Controls.Clear();
                            HashSet<string> projects = new HashSet<string>();

                        
                            foreach (string project_Name in task_sorter_project_box.Items)
                            {
                                projects.Add(project_Name);
                            }
                           
                            int yOffset = 0;
                            while (reader.Read()) 
                            {
                                string task_project_name = reader["task_project"].ToString();
                                if (projects.Count == 0)
                                {

                                    task_sorter_project_box.Items.Add(task_project_name);
                                    projects.Add(task_project_name);
                                }
                                if (!projects.Contains(task_project_name))
                                {
                                    task_sorter_project_box.Items.Add(task_project_name);
                                    projects.Add(task_project_name);

                                }

                                var current_task = new TaskDetails
                                {
                                    task_name = reader["task_name"].ToString(),
                                    task_group = reader["task_group"].ToString(),
                                    task_category = reader["task_category"].ToString(),
                                    task_due_date = reader["task_due_date"].ToString(),
                                    task_status = reader["task_status"].ToString(),
                                    task_project = reader["task_project"].ToString(),
                                    task_priority = reader["task_priority"].ToString(),
                                    is_sort_state = false
                                };

                                string task_json = JsonSerializer.Serialize(current_task);
                                task_table table = new task_table
                                {
                                    Location = new Point(10, yOffset)


                                };
                                flowLayoutPanel1.Controls.Add(table);
                                table.update_values(task_json);
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
        private void welcome_panel_no_task_add_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form add_task = new PAGES.tasks_add_task(); 
            add_task.ShowDialog();
            this.Close();
        }

        private void task_existing_task_add_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form add_task = new PAGES.tasks_add_task();
            add_task.ShowDialog();
            this.Close();
        }

        private void task_sorter_project_box_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            view_all_task();
        }

        private void task_sorter_group_box_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            view_all_task();
        }
    }
}
