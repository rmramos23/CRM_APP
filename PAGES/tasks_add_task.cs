using MySql.Data.MySqlClient;
using Mysqlx.Prepare;
using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEI_CRM.PAGES
{
    public partial class tasks_add_task : Form
    {
        private int user_id = Properties.Settings.Default.active_user;

        private string constring = Properties.Settings.Default.constring;
        private string current_window = "TASKS";
        public tasks_add_task()
        { 

            InitializeComponent();
        }

        private class NewTask {
            public string Owner;
            public string project;
            public string group;
            public string category;
            public string contact;
            public string status;
            public string priority;
            public string due_date;
            public string start_date;
            public string members;
            public string task_name;
            public string created_by;
        
        
        
        }
        NewTask task = new NewTask();   
        private void tasks_add_task_Load(object sender, EventArgs e)
        {
            //Console.WriteLine(user_id);
            load_task_owners();
            load_category();
            load_contact();
            navbar_mini1.navigation_current_page(current_window);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            create_task_due_date_label.Text = month_calendar_cue_date.SelectionStart.ToShortDateString();
        }
        private void create_task_due_date_icon_Click(object sender, EventArgs e)
        {
            if (create_task_due_date_panel.Visible)
            {

                label3.Text = "Notes:";
                create_task_due_date_panel.Visible = false;
                create_task_notes_panel.Visible = true;
                create_task_involved_panel.Visible = false;
                create_task_start_date_panel.Visible = false;
            }
            else
            {

                label3.Text = "Select Due Date:";
                create_task_due_date_panel.Visible = true;
                create_task_notes_panel.Visible = false;
                create_task_involved_panel.Visible = false;
                create_task_start_date_panel.Visible = false;
            }
        }

        private void create_task_start_date_icon_Click(object sender, EventArgs e)
        {
            if (create_task_start_date_panel.Visible)
            {
                label3.Text = "Notes:";
                create_task_notes_panel.Visible = true;
                create_task_start_date_panel.Visible = false;
                create_task_due_date_panel.Visible = false;
                create_task_involved_panel.Visible = false;


            }
            else {
                label3.Text = "Select Start Date:";
                create_task_start_date_panel.Visible = true;
                create_task_due_date_panel.Visible = false;
                create_task_notes_panel.Visible = false;
                create_task_involved_panel.Visible = false;
            }

        }
        private void create_task_involved_button_Click(object sender, EventArgs e)
        {
            if (create_task_involved_panel.Visible)
            {

                label3.Text = "Notes:";
                create_task_involved_panel.Visible = false;
                create_task_due_date_panel.Visible = false;
                create_task_notes_panel.Visible = true;
                create_task_search_involved_button.Visible = false;
                create_task_start_date_panel.Visible = false;
            }
            else
            {
                label3.Text = "Members:";
                create_task_involved_panel.Visible = true;
                create_task_search_involved_button.Visible = true;
                create_task_due_date_panel.Visible = false;
                create_task_notes_panel.Visible = false;
                create_task_start_date_panel.Visible = false;
            }
        }
        private void load_task_owners() {
            //pull data from sql, names from users to task owner list
            using (MySqlConnection con = new MySqlConnection(constring)) 
            {
                try
                {
                    con.Open();
                    string loadcommand = "SELECT * FROM users WHERE state = @state";
                    using (MySqlCommand cmd  = new MySqlCommand (loadcommand, con))
                    {
                        cmd.Parameters.AddWithValue("@state", "approved");
                        using (MySqlDataReader reader = cmd.ExecuteReader()) {
                            while (reader.Read()) 
                            {
                                create_task_task_owner_box.Items.Add(reader["name"].ToString());
                            }
                        
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        


        }
        private void load_projects() 
        {
           
            create_task_project_box.Items.Clear();
            string task_owner = create_task_task_owner_box.Texts;
            int owner_id =  get_id(task_owner);
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string loadcommand = "SELECT * FROM projects WHERE project_handler LIKE @id";
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                    {
                       cmd.Parameters.AddWithValue("@id", "%" + owner_id  +",%");   
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                create_task_project_box.Items.Add(reader["project_name"].ToString());
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
        private int get_id(string owner)
        {
            int owner_id = 0;
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string loadcommand = "SELECT * FROM users WHERE name = @name";
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                    {
                        cmd.Parameters.AddWithValue("@name", owner);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                owner_id = (int)reader["id"];
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }



            return owner_id;
        }
        private void load_category()
        {
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string loadcommand = "SELECT * FROM tasks";
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                    {
            
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            HashSet<string> categories = new HashSet<string>();
                            foreach(string item in create_task_category_box.Items)
                            { 
                            categories.Add(item);
                            }

                            while (reader.Read())
                            {
                                string list = reader["task_category"].ToString();



                                        if (!categories.Contains(list))
                                        {
                                            create_task_category_box.Items.Add(list);

                                            categories.Add(list);
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

        private void load_contact() {
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string loadcommand = "SELECT * FROM projects";
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                    {

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {


                            HashSet<string> set = new HashSet<string>();
                            foreach (string item in create_task_contact_box.Items) { 
                                set.Add(item);
                            }


                            while (reader.Read())
                            {
                                string list = reader["project_contact_name"].ToString();

                                        if (!set.Contains(list))
                                        {
                                            create_task_contact_box.Items.Add(list);
                                            set.Add(list);
                                        }

                                //first look at database if text in create_task_contact_box matches anything in the database, if not, include in the items
                                
                                //create_task_contact_box.Items.Add(reader["project_contact_contact_person"].ToString());
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
        private void add_task_save_button_Click(object sender, EventArgs e)
        {
            task.Owner = create_task_task_owner_box.Texts;
            task.task_name = create_task_task_name_label.Texts;
            task.project = create_task_project_box.Texts;
            task.group = create_task_group_box.Texts;
            task.category = create_task_category_box.Texts;
            task.contact = create_task_contact_box.Texts;
            task.status = create_task_status_box.Texts;
            task.priority  = create_task_priority_box.Texts;  
            task.due_date = create_task_due_date_label.Text;
            task.start_date = create_task_start_date_label.Text ;
            
            task.created_by = user_id.ToString();
           

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string command = "INSERT INTO tasks(task_name,task_owner, task_project, task_group, task_category, task_contact, task_status, task_priority, task_due_date, task_start_date , task_members, created_by) VALUES(@name, @owner, @project, @group, @category, @contact, @status, @priority, @due_date, @start_date , @members, @created_by);";
                    using (MySqlCommand cmd = new MySqlCommand(command, con))
                    {
                        cmd.Parameters.AddWithValue("@name", task.task_name);
                        cmd.Parameters.AddWithValue("@owner", task.Owner);
                        cmd.Parameters.AddWithValue("@project", task.project);
                        cmd.Parameters.AddWithValue("@group", task.group);
                        cmd.Parameters.AddWithValue("@category", task.category);
                        cmd.Parameters.AddWithValue("@contact", task.contact);
                        cmd.Parameters.AddWithValue("@status", task.status);
                        cmd.Parameters.AddWithValue("@priority", task.priority);
                        cmd.Parameters.AddWithValue("@due_date", task.due_date);
                        cmd.Parameters.AddWithValue("@start_date", task.start_date);
                        cmd.Parameters.AddWithValue("@members", task.members);
                        cmd.Parameters.AddWithValue("@created_by", task.created_by);
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
            this.Hide();
            Form add_tasks = new tasks_add_task();
            add_tasks.ShowDialog();
            this.Hide();   
        }

        private void project_add_handler_change_view_button_Click(object sender, EventArgs e)
        {
            project_add_handler_box__TextChanged(sender, e);
            if (create_task_involve_box.Visible == true)
            {
                create_task_involved_panel.Visible = false;
                create_task_add_member_list_panel.Visible = true;
            }
            else
            {

                create_task_involved_panel.Visible = true;
                create_task_add_member_list_panel.Visible = false;

            }

        }

        private void project_add_handler_box__TextChanged(object sender, EventArgs e)
        {
            project_handler_list_box.Items.Clear();

            string constring = "server=localhost;uid=root;pwd=14789653Rm;database=eeipc_crm";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                try
                {
                    string loadcommand = "SELECT * FROM users WHERE state = @state";
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                    {
                        cmd.Parameters.AddWithValue("@state", "approved");
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string name = reader["name"].ToString();
                                if (name.Contains(project_add_handler_box.Texts))
                                {

                                    bool existsinDummylist = false;
                                    //project_handler_list_box.Items.Add(reader["name"]);
                                    foreach (var dummyitem in dummylist.Items)
                                    {
                                        if (dummyitem.ToString() == name)
                                        {
                                            existsinDummylist = true;
                                            break;
                                        }


                                    }
                                    if (!existsinDummylist)
                                    {
                                        project_handler_list_box.Items.Add(name);
                                    }
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

        private void project_add_handler_panel_button_Click(object sender, EventArgs e)
        {

           

            }

        private void create_task_add_member_button_Click(object sender, EventArgs e)
        {
            foreach (String s in project_handler_list_box.CheckedItems)
            {

                dummylist.Items.Add(s);
                create_task_involve_box.Texts = "";
                foreach (string list in dummylist.Items)
                {
                    create_task_involve_box.Texts += list.ToString() + ',';

                }
                create_task_involved_panel.Visible = true;
                create_task_add_member_list_panel.Visible = false;

            }
            parse_handler_list_to_id(create_task_involve_box.Texts);
        }
        private void parse_handler_list_to_id(string list)
        {
            //try_output_id.Texts = null;
            string[] users = list.Split(',');
            foreach (string user in users)
            {
                string parse_con_string = "server=localhost;uid=root;pwd=14789653Rm;database=eeipc_crm";
                using (MySqlConnection con = new MySqlConnection(parse_con_string))
                {
                    try
                    {
                        con.Open();
                        string read_command = "SELECT * FROM users where name = @name";
                        using (MySqlCommand cmd = new MySqlCommand(read_command, con))
                        {
                            cmd.Parameters.AddWithValue("@name", user);
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    //newProject.project_handler += reader["id"].ToString() + ',';
                                    task.members += reader["id"].ToString() + ',';
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
        }

        private void month_calendar_start_date_DateChanged(object sender, DateRangeEventArgs e)
        {
            create_task_start_date_label.Text = month_calendar_start_date.SelectionStart.ToShortDateString();
        }

        private void create_task_task_owner_box_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            load_projects();
        }
    }
}

