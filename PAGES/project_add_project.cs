using Google.Protobuf;
using MySql.Data.MySqlClient;
using Mysqlx.Prepare;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
//using System.IO;


namespace EEI_CRM.PAGES
{

    public partial class project_add_project : Form
    {
        private class AddProject {
            public string project_name;
            public string project_type;
            public string project_location;
            public string project_department;
            public string project_client;
            public string project_cost;
            public string project_jo_number;
            public string project_start_date;
            public string project_due_date;
            public string project_handler;
            public string project_contact_name;
            public string project_contact_company;
            public string project_contact_position;
            public string project_contact_phone_number;
            public string project_contact_email;





        }
        private int number_members = 0;
        private string constring = Properties.Settings.Default.constring;
        private string current_page = "PROJECTS";
        private int current_user = Properties.Settings.Default.active_user;
        private List<string> items = new List<string>();
        HashSet<string> clients = new HashSet<string>();
        HashSet <string> contacts = new HashSet<string>();

        AddProject newProject = new AddProject();
        public project_add_project()
        {
            InitializeComponent();
            navbar_mini1.navigation_current_page(current_page);
        }





        private void project_add_project_Load(object sender, EventArgs e)
        {
            add_project_start_date.Text = DateTime.Today.ToShortDateString();
            load_clients();
            load_contacts();
        }


        private void project_add_handler_box__TextChanged(object sender, EventArgs e)
        {
            project_handler_list_box.Items.Clear();

             constring = "server=localhost;uid=root;pwd=14789653Rm;database=eeipc_crm";
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
        private void parse_handler_list_to_id(string list)
        {
            //try_output_id.Texts = null;
            string[] users = list.Split(',');
            foreach (string user in users)
            {
                 string parse_con_string = "server=localhost;uid=root;pwd=14789653Rm;database=eeipc_crm";
                using(MySqlConnection con = new MySqlConnection(parse_con_string))
                {
                    try
                    {
                        con.Open();
                        string read_command = "SELECT * FROM users where name = @name";
                        using (MySqlCommand cmd = new MySqlCommand(read_command, con)) 
                        {
                            cmd.Parameters.AddWithValue("@name", user);
                            using (MySqlDataReader reader = cmd.ExecuteReader()) {
                                while (reader.Read()) 
                                {
                                   newProject.project_handler += reader["id"].ToString() +',';
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
        private void add_project_save_button_Click(object sender, EventArgs e)
        {
            switch (gather_data()) {
                case true:
                    MessageBox.Show("Please complete the details", "Incomplete Data", MessageBoxButtons.OK);
                    break;
                default:

                    using (MySqlConnection con = new MySqlConnection(constring))
                    {
                        try
                        {
                            con.Open();
                            string loadcommand = "INSERT INTO projects(project_name, project_type, project_location, project_department, project_client, project_cost, project_jo_number, project_start_date, project_due_date, project_handler, project_status, project_contact_name, project_contact_company, project_contact_position, project_contact_phone_number, project_contact_email)" +
                                                             " VALUES(@project_name, @project_type, @project_location, @project_department, @project_client, @project_cost, @project_jo_number, @project_start_date, @project_due_date, @project_handler, @project_status, @project_contact_name, @project_contact_company, @project_contact_position, @project_contact_phone_number, @project_contact_email)";
                            using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                            {
                                cmd.Parameters.AddWithValue("@project_name", newProject.project_name);
                                cmd.Parameters.AddWithValue("@project_type", newProject.project_type);
                                cmd.Parameters.AddWithValue("@project_location", newProject.project_location);
                                cmd.Parameters.AddWithValue("@project_department", newProject.project_department);
                                cmd.Parameters.AddWithValue("@project_client", newProject.project_client);
                                cmd.Parameters.AddWithValue("@project_cost", newProject.project_cost);
                                cmd.Parameters.AddWithValue("@project_jo_number", newProject.project_jo_number);
                                cmd.Parameters.AddWithValue("@project_start_date", newProject.project_start_date);
                                cmd.Parameters.AddWithValue("@project_due_date", newProject.project_due_date);
                                cmd.Parameters.AddWithValue("@project_handler", newProject.project_handler);
                                cmd.Parameters.AddWithValue("@project_status", "ONGOING");
                                cmd.Parameters.AddWithValue("@project_contact_name", newProject.project_contact_name);
                                cmd.Parameters.AddWithValue("@project_contact_company", newProject.project_contact_company);
                                cmd.Parameters.AddWithValue("@project_contact_position", newProject.project_contact_position);
                                cmd.Parameters.AddWithValue("@project_contact_phone_number", newProject.project_contact_phone_number);
                                cmd.Parameters.AddWithValue("@project_contact_email", newProject.project_contact_email);

                                cmd.ExecuteNonQuery();
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    this.Hide();
                    Form project_page = new project_page();
                    project_page.ShowDialog();
                    this.Close();

                    break;
            
            
            }



            

        }
        private bool gather_data()
        {
            bool error_state = false;

            if (add_project_name.Texts == "" || add_project_name.Texts == "Insert Name of Project")
            {
                error_state = true;
                name_line.BackColor = Color.Red;
            }
            if (add_project_type.Texts == "" || add_project_type.Texts == "Select Type of Project")
            {
                error_state = true;
                type_line.BackColor = Color.Red;
            }
            if (add_project_location.Texts == "" || add_project_location.Texts == "Insert Location of Project")
            {
                error_state = true;
                location_line.BackColor = Color.Red;
            }
            if (add_project_department.Texts == "" || add_project_department.Texts == "Select Department")
            {
                error_state = true;
                department_line.BackColor = Color.Red;
            }
            if (add_project_client.Texts == "" || add_project_client.Texts == "Select or Insert Client")
            {
                error_state = true;
                client_line.BackColor = Color.Red;
            }
            if (add_project_cost.Texts == "" || add_project_cost.Texts == "Insert Project Cost")
            {
                error_state = true;
                cost_line.BackColor = Color.Red;
            }
            if (add_project_jo_number.Texts == "" || add_project_jo_number.Texts == "Insert JO Number")
            {
                error_state = true;
                jo_line.BackColor = Color.Red;
            }

            if (add_project_start_date.Text == "" || add_project_start_date.Text == "YYYY-MM-DD")
            {
                error_state = true;
                start_date_line.BackColor = Color.Red;
            }
            if (add_project_due_date.Text == "" || add_project_due_date.Text == "YYYY-MM-DD")
            {
                error_state = true;
                due_date_line.BackColor = Color.Red;
            }
            if (add_project_members.Text == "" || add_project_members.Text == "Select Members")
            {
                error_state = true;
                members_line.BackColor = Color.Red;

            }

            newProject.project_name = add_project_name.Texts;
            newProject.project_type = add_project_type.Texts;
            newProject.project_location = add_project_location.Texts;
            newProject.project_department = add_project_department.Texts;
            newProject.project_client = add_project_client.Texts;
            newProject.project_cost = add_project_cost.Texts;
            newProject.project_jo_number = add_project_jo_number.Texts;
            newProject.project_start_date = add_project_start_date.Text;
            newProject.project_due_date = add_project_due_date.Text;

            newProject.project_contact_name = add_project_contact_name.Texts;
            newProject.project_contact_company = add_project_contact_company.Texts;
            newProject.project_contact_position = add_project_contact_position.Texts;
            newProject.project_contact_phone_number = add_project_contact_phone_number.Texts;
            newProject.project_contact_email = add_project_contact_email.Texts;
            if(error_state) 
            {
                return true;
            }

            return false;
        }
        private void combo_box1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_project_member_button_Click(object sender, EventArgs e)
        {
            if (scroll_panel_members_list.Visible)
            {

                ;
            }
            else
            {
                add_project_scroll_label.Text = "Members:";
                scroll_panel_members_list.Visible = true;
                scroll_panel_search_button.Visible = true;
                scroll_panel_start_date.Visible = false;
                scroll_panel_due_date.Visible = false;
                scroll_panel_members_search.Visible = false;
            }
        }

        private void scroll_panel_search_button_Click(object sender, EventArgs e)
        {
            project_add_handler_box__TextChanged(sender, e);
            if (scroll_panel_members_list.Visible == true)
            {
                scroll_panel_members_list.Visible = false;
                scroll_panel_members_search.Visible = true;
            }
            else
            {

                scroll_panel_members_list.Visible = true;
                scroll_panel_members_search.Visible = false;

            }
        }

        private void add_project_due_date_button_Click(object sender, EventArgs e)
        {

            if (scroll_panel_due_date.Visible)
            {
                ;
            }
            else
            {
                add_project_scroll_label.Text = "Due Date:";
                scroll_panel_members_list.Visible = false;
                scroll_panel_search_button.Visible = false;
                scroll_panel_start_date.Visible = false;
                scroll_panel_due_date.Visible = true;
                scroll_panel_members_search.Visible = false;
            }
        }

        private void add_project_start_date_button_Click(object sender, EventArgs e)
        {
            if (scroll_panel_start_date.Visible)
            {

                ;


            }
            else
            {
                add_project_scroll_label.Text = "Start Date:";
                scroll_panel_members_list.Visible = false;
                scroll_panel_search_button.Visible = false;
                scroll_panel_start_date.Visible = true;
                scroll_panel_due_date.Visible = false;
                scroll_panel_members_search.Visible = false;
            }

        }



        private void add_project_name_Click(object sender, EventArgs e)
        {

        }

        private void add_project_name__TextChanged(object sender, EventArgs e)
        {

        }

        private void add_project_name_Enter(object sender, EventArgs e)
        {
            if (add_project_name.Texts == "Insert Name of Project")
            {
                add_project_name.Texts = null;
            }
        }

        private void add_project_location_Enter(object sender, EventArgs e)
        {
            if (add_project_location.Texts == "Insert Location of Project")
            {
                add_project_location.Texts = null;
            }
        }

        private void add_project_cost_Enter(object sender, EventArgs e)
        {
            if (add_project_cost.Texts == "Insert Project Cost")
            {
                add_project_cost.Texts = null;
            }

        }

        private void add_project_jo_number_Enter(object sender, EventArgs e)
        {
            if (add_project_jo_number.Texts == "Insert JO Number")
            {
                add_project_jo_number.Texts = null;
            }

        }



        private void add_project_contact_company_Enter(object sender, EventArgs e)
        {
            if (add_project_contact_company.Texts == "Insert Company Name")
            {
                add_project_contact_company.Texts = null;
            }
        }

        private void add_project_contact_position_Enter(object sender, EventArgs e)
        {
            if (add_project_contact_position.Texts == "Insert Contact Position")
            {
                add_project_contact_position.Texts = null;
            }

        }

        private void add_project_contact_phone_number_Enter(object sender, EventArgs e)
        {
            if (add_project_contact_phone_number.Texts == "Insert Phone Number")
            {
                add_project_contact_phone_number.Texts = null;
            }

        }

        private void add_project_contact_email_Enter(object sender, EventArgs e)
        {
            if (add_project_contact_email.Texts == "Insert Email")
            {
                add_project_contact_email.Texts = null;
            }

        }

        private void create_task_add_member_button_Click(object sender, EventArgs e)
        {
            foreach (String s in project_handler_list_box.CheckedItems)
            {

                dummylist.Items.Add(s);
             
                add_project_member_box.Texts = "";
                foreach (string list in dummylist.Items)
                {
                    number_members++;
                    add_project_member_box.Texts += list.ToString() + ',';

                }
                scroll_panel_members_list.Visible = true;
                scroll_panel_members_search.Visible = false;

            }
            add_project_members.Text = number_members.ToString();
            parse_handler_list_to_id(add_project_member_box.Texts);
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            add_project_due_date.Text = monthCalendar2.SelectionStart.ToShortDateString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            add_project_start_date.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }
        private void load_clients() 
        {
            using (MySqlConnection con = new MySqlConnection(constring)) 
            {
                try
                {
                    con.Open();
                    string loadcommand = "SELECT * FROM clients";
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            foreach (string client in add_project_client.Items)
                            {
                                clients.Add(client);
                            }
                            while (reader.Read()) 
                            {
                                string current_client = reader["client_name"].ToString();
                                if (!clients.Contains(current_client)) 
                                {
                                    clients.Add(current_client);
                                    add_project_client.Items.Add(current_client);

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

        private void same_as_client_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (same_as_client_checkbox.Checked)
            {
                string current_client = add_project_client.Texts.ToString();
                //get basic info of client and load it to contact information
                using (MySqlConnection con = new MySqlConnection(constring)) 
                {
                    try 
                    {
                        con.Open();
                        string loadcommand = "SELECT * FROM clients WHERE client_name = @client_name";
                        using (MySqlCommand cmd = new MySqlCommand(loadcommand,con)) 
                        {
                            cmd.Parameters.AddWithValue("@client_name", current_client);
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read()) 
                                {
                                    add_project_contact_name.Texts = reader["client_name"].ToString();
                                    add_project_contact_company.Texts = reader["client_company"].ToString();
                                    add_project_contact_position.Texts = reader["client_position"].ToString();
                                    add_project_contact_phone_number.Texts = reader["client_phone_number"].ToString();
                                    add_project_contact_email.Texts = reader["client_email"].ToString();
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

            else 
            {
                //clear contact information
                add_project_contact_name.Texts = "";
                add_project_contact_company.Texts = "";
                add_project_contact_position.Texts = "";
                add_project_contact_phone_number.Texts = "";
                add_project_contact_email.Texts = "";
            }
        }
        private void load_contacts() 
        {
            using (MySqlConnection con = new MySqlConnection(constring)) 
            {
                try 
                {
                    con.Open();
                    string loadcommand = "SELECT * FROM projects WHERE project_handler LIKE @project_handler";
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con)) 
                    {
                        cmd.Parameters.AddWithValue("@project_handler", "%" + current_user + ",%");
                        using (MySqlDataReader reader = cmd.ExecuteReader()) 
                        {
                            foreach (string contact in add_project_contact_name.Items)
                            {
                                contacts.Add(contact);
                            }
                            while (reader.Read()) 
                            {
                                string current_contact = reader["project_contact_name"].ToString();
                                if (!contacts.Contains(current_contact) && current_contact != "") 
                                {
                                    contacts.Add(current_contact);
                                    add_project_contact_name.Items.Add(current_contact);
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
    }
}
