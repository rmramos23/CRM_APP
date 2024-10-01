using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEI_CRM.PAGES
{

    public partial class add_client : Form
    {
        private string current_page = "CLIENT";
        private string constring = Properties.Settings.Default.constring;
        private class client_info 
        {
            //info
            public string client_name;
            public string client_position;
            public string client_company;
            public string client_email;
            public string client_phone_number;
            public string client_industry_type;
            //assistant
            public string assistant_name;
            public string assistant_position;
            public string assistant_email;
            public string assistant_phone_number;
            //address
            public string address_street;
            public string address_city;
            public string address_state;
            public string address_zip;
            public string address_country;


        }
        client_info info = new client_info();
        public add_client()
        {
            InitializeComponent();
        }

        private void add_client_Load(object sender, EventArgs e)
        {
            navbar_mini1.navigation_current_page(current_page);

        }
        private void client_assistant_active_button_CheckStateChanged(object sender, EventArgs e)
        {
            if (client_assistant_active_button.Checked)
            {
                client_asst_name_box.Enabled = true;
                client_asst_position_box.Enabled = true;
                client_asst_email_box.Enabled= true;
                client_asst_phone_number_box.Enabled= true; 
            }
            else
            {


                client_asst_name_box.Enabled = false;
                client_asst_position_box.Enabled = false;
                client_asst_email_box.Enabled = false;
                client_asst_phone_number_box.Enabled = false;
            }
        }




        private void save_client_button_Click(object sender, EventArgs e)
        {
            switch (gather_data()) {
                case 1:
                    MessageBox.Show("Please complete the details", "Incomplete Data", MessageBoxButtons.OK);
                    break;
                default:
                    using (MySqlConnection con = new MySqlConnection(constring))
                    {
                        try
                        {
                            con.Open();
                            string loadcommand = "INSERT INTO clients(client_name, client_position, client_company, client_email, client_phone_number, client_industry_type, assistant_name, assistant_position, assistant_email, assistant_phone_number, address_street, address_city, address_state, address_zip, address_country) " +
                                "VALUES(@client_name, @client_position, @client_company, @client_email, @client_phone_number, @client_industry_type, @assistant_name, @assistant_position, @assistant_email, @assistant_phone_number, @address_street, @address_city, @address_state, @address_zip, @address_country);";
                            using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                            {
                                //info
                                cmd.Parameters.AddWithValue("@client_name", info.client_name);
                                cmd.Parameters.AddWithValue("@client_position", info.client_position);
                                cmd.Parameters.AddWithValue("@client_company", info.client_company);
                                cmd.Parameters.AddWithValue("@client_email", info.client_email);
                                cmd.Parameters.AddWithValue("@client_phone_number", info.client_phone_number);
                                cmd.Parameters.AddWithValue("@client_industry_type", info.client_industry_type);
                                //assistant
                                cmd.Parameters.AddWithValue("@assistant_name", info.assistant_name);
                                cmd.Parameters.AddWithValue("@assistant_position", info.assistant_position);
                                cmd.Parameters.AddWithValue("@assistant_email", info.assistant_email);
                                cmd.Parameters.AddWithValue("@assistant_phone_number", info.assistant_phone_number);
                                
                                //address
                                cmd.Parameters.AddWithValue("@address_street", info.address_street);
                                cmd.Parameters.AddWithValue("@address_city", info.address_city);
                                cmd.Parameters.AddWithValue("@address_state", info.address_state);
                                cmd.Parameters.AddWithValue("@address_zip", info.address_zip);
                                cmd.Parameters.AddWithValue("@address_country", info.address_country);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    this.Hide();
                    Form client_page = new client();
                    client_page.ShowDialog();
                    this.Close();
                    break;
            }
             //gather data 
            //save to db
          
        }
        private int gather_data()
        {
            int error_state = 0;
            if (client_name_box.Texts == "" || client_name_box.Texts == "Insert Name")
            {
                client_name_rounded_panel.BorderColor = Color.Red;
                error_state = 1;
                
            }
             if (client_position_box.Texts == "" || client_position_box.Texts == "Insert Position")
            {
                client_position_rounded_panel.BorderColor = Color.Red;
                error_state = 1;

            }
             if (client_company_box.Texts == "" || client_company_box.Texts == "Insert Company")
            {
                client_company_rounded_panel.BorderColor = Color.Red;
                error_state = 1;

            }
             if (client_email_box.Texts == "" || client_email_box.Texts == "Insert Email")
            {
                client_email_rounded_panel.BorderColor = Color.Red;
                error_state = 1;

            }
             if (client_phone_number_box.Texts == "" || client_phone_number_box.Texts == "Insert Phone Number")
            {
                client_phone_number_rounded_panel.BorderColor = Color.Red;
                error_state = 1;

            }
             if (client_industry_type_box.Texts == "" || client_industry_type_box.Texts == "YYYY-MM-DD")
            {
                client_date_of_birth_rounded_panel.BorderColor = Color.Red;
                error_state = 1;

            }
             if (error_state == 1) 
            {
                return 1;
            }
            info.client_name = client_name_box.Texts;
            info.client_position = client_position_box.Texts;
            info.client_company = client_company_box.Texts;
            info.client_email = client_email_box.Texts;
            info.client_phone_number = client_phone_number_box.Texts;
            info.client_industry_type = client_industry_type_box.Texts;


            if (client_assistant_active_button.Checked)
            {

                info.assistant_name = client_asst_name_box.Texts;
                info.assistant_position = client_asst_position_box.Texts;
                info.assistant_email = client_asst_email_box.Texts;
                info.assistant_phone_number = client_asst_position_box.Texts;
                
            }
            else {
                
                info.assistant_name = "n/a";
                info.assistant_position = "n/a";
                info.assistant_email = "n/a";
                info.assistant_phone_number = "n/a";
            }
            info.address_street = client_mailing_st_box.Texts;
            info.address_city = client_mailing_city_box.Texts;
            info.address_state = client_mailing_state_box.Texts;
            info.address_zip = client_mailing_zip_box.Texts;
            info.address_country = client_mailing_country_box.Texts;
            return 0;
        }

        private void client_name_box_Enter(object sender, EventArgs e)
        {
            if (client_name_box.Texts == "Insert Name")
            {
                client_name_box.Texts = "";

            }
        }

        private void client_position_box_Enter(object sender, EventArgs e)
        {
            if (client_position_box.Texts == "Insert Position")
            {
                client_position_box.Texts = "";

            }

        }

        private void client_company_box_Enter(object sender, EventArgs e)
        {
            if (client_company_box.Texts == "Insert Company")
            {
                client_company_box.Texts = "";

            }

        }

        private void client_email_box_Enter(object sender, EventArgs e)
        {
            if (client_email_box.Texts == "Insert Email")
            {
                client_email_box.Texts = "";

            }

        }

        private void client_phone_number_box_Enter(object sender, EventArgs e)
        {
            if (client_phone_number_box.Texts == "Insert Phone Number")
            {
                client_phone_number_box.Texts = "";

            }

        }
        private void client_industry_type_box_Enter(object sender, EventArgs e)
        {
            if (client_industry_type_box.Texts == "Insert Industry Type") 
            {
                client_industry_type_box.Texts = "";
            }

        }


        private void client_mailing_st_box_Enter(object sender, EventArgs e)
        {
            if (client_mailing_st_box.Texts == "Insert Street")
            {
                client_mailing_st_box.Texts = "";

            }

        }

        private void client_mailing_city_box_Enter(object sender, EventArgs e)
        {
            if (client_mailing_city_box.Texts == "Insert City")
            {
                client_mailing_city_box.Texts = "";

            }

        }

        private void client_mailing_state_box_Enter(object sender, EventArgs e)
        {
            if (client_mailing_state_box.Texts == "Insert State")
            {
                client_mailing_state_box.Texts = "";

            }

        }

        private void client_mailing_zip_box_Enter(object sender, EventArgs e)
        {
            if (client_mailing_zip_box.Texts == "Insert Zip")
            {
                client_mailing_zip_box.Texts = "";

            }

        }

        private void client_mailing_country_box_Enter(object sender, EventArgs e)
        {
            if (client_mailing_country_box.Texts == "Insert Country")
            {
                client_mailing_country_box.Texts = "";

            }

        }

        private void client_asst_name_box_Enter(object sender, EventArgs e)
        {
            if (client_asst_name_box.Texts == "Insert Name") 
            {
                client_asst_name_box.Texts = "";
            }
        }

        private void client_asst_position_box_Enter(object sender, EventArgs e)
        {
            if (client_asst_position_box.Texts == "Insert Position") 
            {
                client_asst_position_box.Texts = "";
            }
        }

        private void client_asst_email_box_Enter(object sender, EventArgs e)
        {
            if (client_asst_email_box.Texts == "Insert Email") 
            {
                client_asst_email_box.Texts = "";
            }

        }

        private void client_asst_phone_number_box_Enter(object sender, EventArgs e)
        {
            if (client_asst_phone_number_box.Texts == "Insert Phone Number") 
            {
                client_asst_phone_number_box.Texts = "";
            }
        }


    }
}
