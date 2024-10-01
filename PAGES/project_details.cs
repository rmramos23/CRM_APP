using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using System.Text.Json;
using EEI_CRM.user_control;
using MySql.Data.Types;

namespace EEI_CRM.PAGES
{
    public partial class project_details : Form
    {
        private string constring = Properties.Settings.Default.constring;
        private string current_project_name;
        private string current_window = "PROJECTS";
        private string current_task_group = "Electrical Works";
        private bool project_details_edit_state = false;
        private int project_id = 0;
        HashSet<string> active_members_list = new HashSet<string> ();
        HashSet<string> project_members_list = new HashSet<string>();
        StringBuilder add_members_active_list = new StringBuilder ();
        private class task_details 
        {
            public string task_name {  get; set; }
            public string status { get; set; }
        };
        public project_details(string project)
        {
            current_project_name = project;
            InitializeComponent();
        }

        private void project_details_Load(object sender, EventArgs e)
        {
            navbar1.navigation_current_page(current_window);
            load_project_task_panel(current_task_group);
            load_data_progress(current_project_name);
            project_name_label.Text = current_project_name;
            using (MySqlConnection con = new MySqlConnection(constring)) 
            {
                try 
                {
                    con.Open();
                    string load_command = "SELECT * FROM projects WHERE project_name = @project_name";
                    using (MySqlCommand cmd  = new MySqlCommand(load_command, con)) 
                    {
                        cmd.Parameters.AddWithValue("@project_name", current_project_name);
                        using (MySqlDataReader reader = cmd.ExecuteReader()) 
                        {
                            while (reader.Read()) 
                            {
                                name_box.Texts = reader["project_name"].ToString();
                                department_box.Texts = reader["project_department"].ToString();
                                client_box.Texts = reader["project_client"].ToString();
                                cost_box.Texts = reader["project_cost"].ToString();
                                location_box.Texts = reader["project_location"].ToString();
                                type_box.Texts = reader["project_type"].ToString();
                                jo_box.Texts = reader["project_jo_number"].ToString();
                                start_date_box.Texts = reader["project_start_date"].ToString();
                                end_date_box.Texts = reader["project_due_date"].ToString();
                                contact_name_box.Texts = reader["project_contact_name"].ToString();
                                contact_company_box.Texts = reader["project_contact_company"].ToString();
                                contact_position_box.Texts = reader["project_contact_position"].ToString();
                                contact_phone_number_box.Texts = reader["project_contact_phone_number"].ToString();
                                contact_email_box.Texts = reader["project_contact_email"].ToString();
                                project_id = (int)reader["project_code"];
                                load_members(reader["project_handler"].ToString());
                                
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
        private void load_members(string list) 
        {
            StringBuilder users = new StringBuilder();
            int current_number = 1;
            if (list != "")
            {
                string[] user_id = list.Split(',');
                foreach (string user in user_id)
                {
                    active_members_list.Add(user);
                    using (MySqlConnection con = new MySqlConnection(constring))
                    {
                        try
                        {
                            con.Open();
                            string loadcommand = "SELECT * FROM users WHERE id = @user_id";
                            using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                            {
                                cmd.Parameters.AddWithValue("@user_id", user);
                                using (MySqlDataReader reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        
                                        users.AppendLine(current_number + ": " + reader["name"].ToString());
                                        current_number++;


                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    members_list_box.Texts = users.ToString();
                  
                }
            }
            else 
            {
                members_list_box.Texts = "";
            }
        }
        private void project_details_edit_button_Click(object sender, EventArgs e)
        {
            project_details_edit_state = !project_details_edit_state;
            if (project_details_edit_state == true)
            {
                name_box.Enabled = true;
                department_box.Enabled = true;
                client_box.Enabled = true;
                cost_box.Enabled = true;
                location_box.Enabled = true;
                type_box.Enabled = true;
                jo_box.Enabled = true;
                start_date_box.Enabled = true;
                end_date_box.Enabled = true;
                contact_name_box.Enabled = true;
                contact_company_box.Enabled = true;
                contact_position_box.Enabled = true;
                contact_phone_number_box.Enabled = true;
                contact_email_box.Enabled = true;
                members_list_box.Enabled=true;
                load_add_members_panel();
                project_add_members_panel.Visible = true;
                project_task_panel.Visible = false ;
                project_details_edit_button.Text = "SAVE";
                project_details_edit_button.BackColor = Color.FromArgb(16, 188, 131);

            }
            else
            {
                string project_handler ="";
                foreach (string id in active_members_list)
                {
                    project_handler += id + ",";
                }
                //remove last ','

                project_handler = project_handler.TrimEnd(',');
                using (MySqlConnection con = new MySqlConnection(constring)) 
                {
                    try 
                    {
                        con.Open();
                        string loadcommand = "UPDATE projects " +
                            " SET   project_name = @project_name," +
                            "       project_type = @project_type," +
                            "       project_location = @project_location," +
                            "       project_department = @project_department," +
                            "       project_client = @project_client," +
                            "       project_cost = @project_cost," +
                            "       project_jo_number = @project_jo_number," +
                            "       project_start_date = @project_start_date," +
                            "       project_due_date = @project_due_date," +
                            "       project_contact_name = @project_contact_name," +
                            "       project_contact_company = @project_contact_company," +
                            "       project_contact_position = @project_contact_position," +
                            "       project_contact_phone_number = @project_contact_phone_number," +
                            "       project_contact_email = @project_contact_email," +
                            "       project_handler = @project_handler" +
                            " WHERE project_code = @project_code;";
                        using (MySqlCommand cmd = new MySqlCommand(loadcommand, con)) 
                        {
                            cmd.Parameters.AddWithValue("@project_name", name_box.Texts);
                            cmd.Parameters.AddWithValue("@project_type", type_box.Texts);
                            cmd.Parameters.AddWithValue("@project_location", location_box.Texts);
                            cmd.Parameters.AddWithValue("@project_department", department_box.Texts);
                            cmd.Parameters.AddWithValue("@project_client", client_box.Texts);
                            cmd.Parameters.AddWithValue("@project_cost", cost_box.Texts );
                            cmd.Parameters.AddWithValue("@project_jo_number", jo_box.Texts );
                            cmd.Parameters.AddWithValue("@project_start_date", start_date_box.Texts );
                            cmd.Parameters.AddWithValue("@project_due_date", end_date_box.Texts );
                            cmd.Parameters.AddWithValue("@project_contact_name", contact_name_box.Texts);
                            cmd.Parameters.AddWithValue("@project_contact_company", contact_company_box.Texts);
                            cmd.Parameters.AddWithValue("@project_contact_position", contact_position_box.Texts);
                            cmd.Parameters.AddWithValue("@project_contact_phone_number", contact_phone_number_box.Texts);
                            cmd.Parameters.AddWithValue("@project_contact_email", contact_email_box.Texts);

                            cmd.Parameters.AddWithValue("@project_handler",project_handler);
                            cmd.Parameters.AddWithValue("@project_code", project_id);
                            cmd.ExecuteNonQuery();

                      




                        }
                    }
                    catch (Exception ex)
                    {
                       MessageBox.Show(ex.Message); 
                    }
                }
                this.Hide();
                Form project_info = new project_details(current_project_name);
                project_info.ShowDialog();
                this.Close();
            }
        }

        private void load_add_members_panel()
        {


            //load active members as  checked
            foreach (string member in active_members_list)
            {
                using (MySqlConnection con = new MySqlConnection(constring))
                {
                    try
                    {
                        con.Open();
                        string loadcommand = "SELECT * FROM users WHERE id = @id AND state = @state AND name LIKE @filter_name";
                        using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                        {
                            cmd.Parameters.AddWithValue("@id", member);
                            cmd.Parameters.AddWithValue("@state", "Approved");
                            cmd.Parameters.AddWithValue("@filter_name", "%" + add_member_search_box.Texts + "%");
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    add_member_list.Items.Add(reader["name"].ToString(), true);
                                    
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

            //load remaining members as unchecked
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string loadcommand = "SELECT * FROM users WHERE state = @state AND name LIKE @filter_name";
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                    {
                        cmd.Parameters.AddWithValue("state", "Approved");
                        cmd.Parameters.AddWithValue("@filter_name", "%" + add_member_search_box.Texts + "%");
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string current_user_id = reader["id"].ToString();
                                string current_user_name = reader["name"].ToString();

                                if (!active_members_list.Contains(current_user_id))
                                {
                                    add_member_list.Items.Add(current_user_name);
                                    project_members_list.Add(current_user_id);
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


            //


        }
        private void project_contact_info_Click(object sender, EventArgs e)
        {
            if (project_contact_panel.Visible)
            {
                ;
            }
            else 
            {
                project_contact_panel.Visible = true;
                project_info_panel.Visible = false;
            }
        }

        private void project_info_button_Click(object sender, EventArgs e)
        {
            if (project_info_panel.Visible)
            {
                ;
            }
            else
            {
                project_info_panel.Visible = true;
                project_contact_panel.Visible = false;

            }
        }
        private void load_project_task_panel(string task_group) 
        {
            task_flowpanel.Controls.Clear();
            //load tasks of the current project
            using (MySqlConnection con = new MySqlConnection (constring)) 
            {
                try 
                {
                    con.Open();
                    string loadcomand = "SELECT * FROM tasks WHERE task_project = @current_project_name AND task_group = @task_group;";
                    using (MySqlCommand cmd = new MySqlCommand(loadcomand, con)) 
                    {
                        cmd.Parameters.AddWithValue("@current_project_name", current_project_name);
                        cmd.Parameters.AddWithValue("@task_group", task_group);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            int yOffset = 0;
                            while (reader.Read()) 
                            {
                                var current_tasks = new task_details()
                                {
                                    task_name = reader["task_name"].ToString(),
                                    status = reader["task_status"].ToString()
                                };


                                project_details_task_table panel = new project_details_task_table
                                {
                                    Location = new Point(0, yOffset)
                                };
                                string details = JsonSerializer.Serialize(current_tasks);
                                task_flowpanel.Controls.Add(panel);
                                panel.update_table_values(details);
                                yOffset += panel.Height + 5;
                                
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

        private void task_mw_button_Click(object sender, EventArgs e)
        {
            task_ew_button.BackColor = Color.Gray;
            task_csaw_button.BackColor = Color.Gray;
            task_mw_button.BackColor = Color.FromArgb(0, 0, 55);
            current_task_group = "Mechanical Works";
            load_project_task_panel(current_task_group);
        }

        private void task_csaw_button_Click(object sender, EventArgs e)
        {

            task_ew_button.BackColor = Color.Gray;
            task_csaw_button.BackColor = Color.FromArgb(0, 0, 55);
            task_mw_button.BackColor = Color.Gray;
            current_task_group = "Civil, Structural and Architectural Works";
            load_project_task_panel(current_task_group);
        }

        private void task_ew_button_Click(object sender, EventArgs e)
        {
            task_ew_button.BackColor = Color.FromArgb(0, 0, 55);
            task_csaw_button.BackColor = Color.Gray;
            task_mw_button.BackColor = Color.Gray;

            current_task_group = "Electrical Works";
            load_project_task_panel(current_task_group);
        }
        private void load_data_progress(string current_project_name)
        {
            float elec_perc = 0.0F, csaw_perc = 0.0F, mw_perc = 0.0F;
            float total_task = 0.0F, finished_task = 0.0F;

            //load electrical works
                using (MySqlConnection con = new MySqlConnection(constring)) 
                {
                
                    try
                    {
                        con.Open();
                    string loadcommand = "SELECT COUNT(*) FROM tasks WHERE task_project = @current_project AND task_group = @current_task_group";
                        using (MySqlCommand cmd = new MySqlCommand(loadcommand, con)) 
                        {
                            cmd.Parameters.AddWithValue("@current_project", current_project_name);
                            cmd.Parameters.AddWithValue("@current_task_group", "Electrical Works");
                            total_task = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                        loadcommand = "SELECT COUNT(*) FROM tasks WHERE task_project = @current_project AND task_group = @current_task_group AND task_status = @task_status" ;
                        using(MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                    {
                        cmd.Parameters.AddWithValue("@current_project", current_project_name);
                        cmd.Parameters.AddWithValue("@current_task_group", "Electrical Works");
                        cmd.Parameters.AddWithValue("@task_status", "Finished");
                        finished_task = Convert.ToInt32(cmd.ExecuteScalar());

                    }
                }
                    catch (Exception ex) 
                    {
                        MessageBox.Show(ex.Message);
                    }

                }


            if (finished_task == 0)
            {
                elec_perc = 0;
            }
            else
            {

                elec_perc = (float)(finished_task / total_task) * 100;
            }

            //Console.WriteLine("Total: {0} \nFinished: {1} \nPercent: {2:F2}\n", total_task, finished_task, elec_perc);


            //load CSA works
            using (MySqlConnection con = new MySqlConnection(constring))
            {

                try
                {
                    con.Open();
                    string loadcommand = "SELECT COUNT(*) FROM tasks WHERE task_project = @current_project AND task_group = @current_task_group";
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                    {
                        cmd.Parameters.AddWithValue("@current_project", current_project_name);
                        cmd.Parameters.AddWithValue("@current_task_group", "Civil, Structural and Architectural Works");
                        total_task = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    loadcommand = "SELECT COUNT(*) FROM tasks WHERE task_project = @current_project AND task_group = @current_task_group AND task_status = @task_status";
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                    {
                        cmd.Parameters.AddWithValue("@current_project", current_project_name);
                        cmd.Parameters.AddWithValue("@current_task_group", "Civil, Structural and Architectural Works");
                        cmd.Parameters.AddWithValue("@task_status", "Finished");
                        finished_task = Convert.ToInt32(cmd.ExecuteScalar());

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            if (finished_task == 0)
            {
                csaw_perc = 0;
            }
            else 
            {

                csaw_perc = (float)(finished_task / total_task) * 100;
            }


            //Console.WriteLine("Total: {0} \nFinished: {1} \nPercent: {2:F2}\n", total_task, finished_task, csaw_perc);

            //load Mechanical works
            using (MySqlConnection con = new MySqlConnection(constring))
            {

                try
                {
                    con.Open();
                    string loadcommand = "SELECT COUNT(*) FROM tasks WHERE task_project = @current_project AND task_group = @current_task_group";
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                    {
                        cmd.Parameters.AddWithValue("@current_project", current_project_name);
                        cmd.Parameters.AddWithValue("@current_task_group", "Mechanical Works");
                        total_task = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    loadcommand = "SELECT COUNT(*) FROM tasks WHERE task_project = @current_project AND task_group = @current_task_group AND task_status = @task_status";
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                    {
                        cmd.Parameters.AddWithValue("@current_project", current_project_name);
                        cmd.Parameters.AddWithValue("@current_task_group", "Mechanical Works");
                        cmd.Parameters.AddWithValue("@task_status", "Finished");
                        finished_task = Convert.ToInt32(cmd.ExecuteScalar());

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            if (finished_task == 0)
            {
                mw_perc = 0;
            }
            else
            {

                mw_perc = (float)(finished_task / total_task) * 100;
            }

            //Console.WriteLine("Total: {0} \nFinished: {1} \nPercent: {2:F2}\n", total_task, finished_task, mw_perc);

            data_progress_ew_bar.Value = (int)elec_perc;
            data_progress_csaw_bar.Value = (int)csaw_perc;
            data_progress_mw_bar.Value =(int)mw_perc;

            data_progress_ew_label.Text = (int)elec_perc + "%";
            data_progress_csaw_label.Text = (int)csaw_perc + "%";
            data_progress_mw_label.Text = (int)mw_perc + "%";






        }

        private void project_details_members_button_Click(object sender, EventArgs e)
        {

            project_details_attachment_button.BackColor = Color.Gray;
            project_details_members_button.BackColor = Color.FromArgb(0, 0, 55);
            if (project_details_members_panel.Visible)
            {
                ;
            }
            else
            {
                project_details_attachments_panel.Visible = false;
                project_details_members_panel.Visible = true;
            }
        }

        private void project_details_attachment_button_Click(object sender, EventArgs e)
        {
            project_details_attachment_button.BackColor = Color.FromArgb(0, 0, 55);
            project_details_members_button.BackColor = Color.Gray;

            if (project_details_attachments_panel.Visible)
            {
                ;
            }
            else
            {
                project_details_attachments_panel.Visible = true;
                project_details_members_panel.Visible = false;
            }
        }

        private void add_member_search_box__TextChanged(object sender, EventArgs e)
        {
            project_members_list.Clear();
            add_member_list.Items.Clear();
            load_add_members_panel();

        }

        private void add_member_list_ItemCheck(object sender, ItemCheckEventArgs e)
        {
          
            CheckedListBox clb = sender as CheckedListBox;
            int index_selected = e.Index;
            int selected_user_id = 0;
            string name_selected = clb.Items[index_selected].ToString();
            bool new_val = Convert.ToBoolean(e.NewValue);
            Console.WriteLine("{0} {1}", name_selected, new_val);
            using (MySqlConnection con =  new MySqlConnection(constring)) 
            {
                try 
                {
                    con.Open();
                    string loadcommand = "SELECT * FROM users WHERE name = @name";
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand,  con)) 
                    {
                        cmd.Parameters.AddWithValue("@name", name_selected);
                        using (MySqlDataReader reader = cmd.ExecuteReader()) 
                        {
                            if (reader.Read()) 
                            {
                                selected_user_id = (int)reader["id"];
                            }
                        }
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }

            }

            //get the id of selected name

            if (new_val)
            {
                if (!active_members_list.Contains(selected_user_id.ToString()))
                {
                    active_members_list.Add(selected_user_id.ToString());
                }
            }
            else 
            {
                active_members_list.Remove(selected_user_id.ToString());
            }
            //save the new active members list to sql
            //using ()

         
        }

        private void add_members_save_button_Click(object sender, EventArgs e)
        {

        }
    }
}
