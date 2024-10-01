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

namespace EEI_CRM.PAGES
{
    public partial class client_profile : Form
    {
        string client;
        private string constring = Properties.Settings.Default.constring;
        StringBuilder projects = new StringBuilder();
        private string current_window = "CLIENT";
        private int client_id = 0;
        private bool edit_state = false;
        public client_profile(string client_name)
        {
             client = client_name;
            InitializeComponent();
        }
        public void update_client_details(string client_details) {
            Console.WriteLine(client_details);
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string loadcommand = "SELECT * FROM clients WHERE client_name LIKE @client_name;";
                    using (MySqlCommand cmd  = new MySqlCommand (loadcommand, con)) 
                    {
                        cmd.Parameters.AddWithValue("@client_name","%" + client_details + "%");
                        using (MySqlDataReader reader = cmd.ExecuteReader()) 
                        {
                            while (reader.Read())
                            {
                             
                                client_profile_name.Text = reader["client_name"].ToString() + " - " + reader["client_company"].ToString();
                                client_profile_position.Text = reader["client_position"].ToString();
                                //name
                                client_profile_name_box.Texts = reader["client_name"].ToString();
                                //position
                                client_profile_position_box.Texts = reader["client_position"].ToString();
                                //company
                                client_profile_company_box.Texts = reader["client_company"].ToString ();
                                //email
                                client_profile_email_box.Texts = reader["client_email"].ToString();
                                //phone number
                                client_profile_phone_number_box.Texts = reader["client_phone_number"].ToString();
                                //date of birth
                                client_industry_type_box.Texts = reader["client_industry_type"].ToString();
                                //address street
                                client_address_street_box.Texts = reader["address_street"].ToString();
                                //address city
                                client_address_city_box.Texts = reader["address_city"].ToString();
                                //address state
                                client_address_state_box.Texts = reader["address_state"].ToString();
                                //address zip
                                client_address_zip_box.Texts = reader["address_zip"].ToString();
                                //address country
                                client_address_country_box.Texts = reader["address_country"].ToString();
                                //asst. name
                                client_asst_name_box.Texts = reader["assistant_name"].ToString();
                                client_asst_position_box.Texts = reader["assistant_position"].ToString();
                                client_asst_email_box.Texts = reader["assistant_email"].ToString();
                                client_asst_phone_number_box.Texts = reader["assistant_phone_number"].ToString();
                                //asst. phone number
                                //client_id
                                client_id = (int)reader["client_id"];
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

        private void client_profile_Load(object sender, EventArgs e)
        {

            navbar1.navigation_current_page(current_window);
            update_client_details(client);
            load_connected_projects(client);
        }


        private void load_connected_projects(string client) 
        {
            int count = 1;
            //load all projects that the current client is the client of the project
            using (MySqlConnection con  =  new MySqlConnection(constring)) 
            {
                try 
                {
                    con.Open();
                    string loadcommand = "SELECT * FROM projects WHERE project_client = @project_client";
                    using (MySqlCommand cmd =  new MySqlCommand(loadcommand, con)) 
                    {
                        cmd.Parameters.AddWithValue("@project_client", client);
                        using (MySqlDataReader reader = cmd.ExecuteReader()) 
                        {
                            while (reader.Read()) 
                            {
                                projects.AppendLine(count + ": " + reader["project_name"].ToString());
                                count++;
                            }
                        }
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
            client_connected_projects.Texts = projects.ToString(); 

        }
        private void client_information_buttn_Click(object sender, EventArgs e)
        {
            if (client_info_panel.Visible)
            {
                ;
            }
            else
            {
                client_asst_panel.Visible = false;
                client_info_panel.Visible = true;
                client_mail_panel.Visible = false;
            }
        }

        private void client_email_button_Click(object sender, EventArgs e)
        {
            if (client_mail_panel.Visible)
            {
                ;
            }
            else
            {
                client_asst_panel.Visible = false;
                client_info_panel.Visible = false;
                client_mail_panel.Visible = true;
            }

        }

        private void client_asst_button_Click(object sender, EventArgs e)
        {
            if (client_asst_panel.Visible)
            {
                ;
            }
            else
            {
                client_asst_panel.Visible = true;
                client_info_panel.Visible = false;
                client_mail_panel.Visible = false;
            }

        }
        private void edit_client_button_Click(object sender, EventArgs e)
        {

            edit_state = !edit_state ;
            if (edit_state)
            {
                edit_client_button.Text = "Save";
                edit_client_button.BackColor = Color.FromArgb(16, 188, 131);
                //enable all textbox
                //information
                client_profile_name_box.Enabled = true;
                client_profile_position_box.Enabled = true;
                client_profile_company_box.Enabled = true;
                client_profile_email_box.Enabled = true;
                client_profile_phone_number_box.Enabled = true;
                client_industry_type_box.Enabled = true;
                //address
                client_address_street_box.Enabled = true;
                client_address_city_box.Enabled= true;
                client_address_state_box.Enabled = true;   
                client_address_zip_box.Enabled = true;
                client_address_country_box.Enabled = true;
                //asst.
                client_asst_name_box.Enabled = true;
                client_asst_position_box.Enabled = true;
                client_asst_email_box.Enabled = true;
                client_asst_phone_number_box.Enabled = true;
                

            }
            else 
            {
                //save data to database
                using (MySqlConnection con = new MySqlConnection(constring)) 
                {
                    try 
                    {
                        con.Open();
                        string load_command = "UPDATE clients SET" +
                            " client_name = @client_name," +
                            " client_position = @client_position," +
                            " client_company = @client_company," +
                            " client_email = @client_email," +
                            " client_phone_number = @client_phone_number," +
                            " client_industry_type = @client_industry_type," +
                            " assistant_name = @assistant_name," +
                            " assistant_position = @assistant_position," +
                            " assistant_email = @assistant_email," +
                            " assistant_phone_number = @assistant_phone_number," +
                            " address_street = @client_address_street," +
                            " address_city = @client_address_city," +
                            " address_state = @client_address_state," +
                            " address_zip = @client_address_zip," +
                            " address_country = @client_address_country " +
                            "WHERE client_id = @client_id;";
                        using (MySqlCommand cmd = new MySqlCommand(load_command, con))
                        {
                            cmd.Parameters.AddWithValue("@client_name", client_profile_name_box.Texts.ToString());
                            cmd.Parameters.AddWithValue("@client_position", client_profile_position_box.Texts.ToString());
                            cmd.Parameters.AddWithValue("@client_company", client_profile_company_box.Texts.ToString());
                            cmd.Parameters.AddWithValue("@client_email", client_profile_email_box.Texts.ToString());
                            cmd.Parameters.AddWithValue("@client_phone_number", client_profile_phone_number_box.Texts.ToString());
                            cmd.Parameters.AddWithValue("@client_industry_type", client_industry_type_box.Texts.ToString());
                            cmd.Parameters.AddWithValue("@assistant_name", client_asst_name_box.Texts.ToString());
                            cmd.Parameters.AddWithValue("@assistant_position", client_asst_position_box.Texts.ToString());
                            cmd.Parameters.AddWithValue("@assistant_email", client_asst_email_box.Texts.ToString());
                            cmd.Parameters.AddWithValue("@assistant_phone_number", client_asst_phone_number_box.Texts.ToString());
                            cmd.Parameters.AddWithValue("@client_address_street", client_address_street_box.Texts.ToString());
                            cmd.Parameters.AddWithValue("@client_address_city", client_address_city_box.Texts.ToString());
                            cmd.Parameters.AddWithValue("@client_address_state", client_address_state_box.Texts.ToString());
                            cmd.Parameters.AddWithValue("@client_address_zip", client_address_zip_box.Texts.ToString());
                            cmd.Parameters.AddWithValue("@client_address_country", client_address_country_box.Texts.ToString());
                            cmd.Parameters.AddWithValue("@client_id",client_id.ToString());
                            cmd.ExecuteNonQuery();

                        }
                    }
                    catch(Exception ex) 
                    {
                        MessageBox.Show(ex.Message);
                    } 

                }
                //close window
                this.Hide();
                Form client_page = new client();
                client_page.ShowDialog();
                this.Close();


            }

        }

    }
}
