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



namespace EEI_CRM
{
    public partial class user_profile : Form
    {
        StringBuilder projects = new StringBuilder();
        private string constring = Properties.Settings.Default.constring;
        public class User_class
        {
            
            public string name;
            public string email;
            public string department;
            public string position;
            public string reporting_to;
            public string id_number;
            public string phone_number;
            public string user_id;
         



        }

        User_class user = new User_class();
        private bool is_head;
        public int user_id =  Properties.Settings.Default.active_user;
        private bool profile_edit_state = false;
        
        private string current_page = "PROFILE";
        


        public user_profile()
        {
            
            InitializeComponent();
            navbar1.navigation_current_page(current_page);
        }


        


        private void user_profile_Load(object sender, EventArgs e)
        {
            load_user_profile();

           
            
            current_page_label.Text = current_page;

            //labels
            profile_current_user_label.Text = (user.name);
            profile_current_position_label.Text = (user.position);

            user_name_box.Texts = user.name;
            user_email_box.Texts = user.email;
            user_department_box.Texts = user.department;
            user_position_box.Texts = user.position;
            user_reporting_to_box.Texts= user.reporting_to;
            user_phone_number_box.Texts =user.phone_number;
            user_id_number_box.Texts = user.id_number;
            

        }

        private void load_user_profile() 
        {
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string load_command = "SELECT * FROM users where id =@id_number";
                    using (MySqlCommand cmd = new MySqlCommand(load_command, con))
                    {
                        cmd.Parameters.AddWithValue("@id_number", user_id);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {


                                user.name = reader["name"].ToString();
                                user.email = reader["email"].ToString();
                                user.department = reader["department"].ToString();
                                user.position = reader["position"].ToString();
                                user.reporting_to = reader["reporting_to"].ToString();
                                user.id_number = reader["id_number"].ToString();
                                user.phone_number = reader["phone_number"].ToString();
                                user.user_id = reader["id"].ToString();


                            }
                        }
                    }
                    //user_profile_idNumber.Texts = (user.id_number).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR WHILE ACCESSING DATABASE" + ex.Message, "error");
                }



            }
            //check if head of department
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
                                if (user.name == reader[check_dept(user.department)].ToString())
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

            //load all projects
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                int project_counter = 1;
                string loadcommand;
                try
                {
                    con.Open();
                    if (is_head)
                    {
                        if (user.name == "ADMIN")
                        {
                            loadcommand = "SELECT * FROM projects";
                        }
                        else
                        {
                            loadcommand = "SELECT * FROM projects WHERE project_department LIKE @department";
                        }
                    }
                    else
                    {
                        loadcommand = "SELECT * FROM projects WHERE  project_handler LIKE @project_handler";

                    }
                    using (MySqlCommand cmd  = new MySqlCommand(loadcommand,con)) 
                    {
                        cmd.Parameters.AddWithValue("@department","%" +  user.department + "%");
                        cmd.Parameters.AddWithValue("@project_handler", "%" + user.user_id + "%");

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read()) 
                            {
                                projects.AppendLine(project_counter + ": " + reader["project_name"].ToString());
                                project_counter++;
                            }
                        }
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
            project_list_box.Text = projects.ToString();

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
        private void edit_profile_button_Click(object sender, EventArgs e)
        {
            profile_edit_state = !(profile_edit_state);

            if (profile_edit_state)
            {
                //edit the profile
                user_name_box.Enabled = true;
                user_email_box.Enabled = true;
                user_department_box.Enabled = true;
                user_position_box.Enabled = true;
                user_reporting_to_box.Enabled = true;
                user_phone_number_box.Enabled = true;
                user_id_number_box.Enabled = true;





               
                edit_profile_button.Text = "SAVE";
                edit_profile_button.BackColor = Color.FromArgb(16,188,131);




            }
            else
            {
               
          
                profile_edit_saveto_database();

                this.Hide();
                Form refresh = new user_profile();
                refresh.ShowDialog();
                this.Close();

            }

        }
        private void profile_edit_saveto_database() 
        {

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string load_command = "UPDATE users SET name = @name, email = @email, department = @department, position = @position, reporting_to = @reporting_to, phone_number = @phone_number, id_number = @user_id   WHERE id = @id_number;";

                    using (MySqlCommand cmd = new MySqlCommand(load_command, con))
                    {
                        cmd.Parameters.AddWithValue("@name",user_name_box.Texts);
                        cmd.Parameters.AddWithValue("@email", user_email_box.Texts);
                        cmd.Parameters.AddWithValue("@department", user_department_box.Texts);
                        cmd.Parameters.AddWithValue("@position", user_position_box.Texts);
                        cmd.Parameters.AddWithValue("@reporting_to", user_reporting_to_box.Texts);
                        cmd.Parameters.AddWithValue("@phone_number", user_phone_number_box.Texts);
                        cmd.Parameters.AddWithValue("@user_id", user_id_number_box.Texts);
                        cmd.Parameters.AddWithValue("@id_number", user_id);
                        cmd.ExecuteNonQuery();
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message, "ERROR");
                }
            }
          

        }
    }
}
