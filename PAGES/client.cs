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
using EEI_CRM.user_control;
namespace EEI_CRM.PAGES
{

    public partial class client : Form
    {
        private string constring = Properties.Settings.Default.constring;
        private string current_window = "CLIENT";
        private int user_id = Properties.Settings.Default.active_user;
        private class client_details { 
            public string client_name { get; set; }
            public string client_company { get; set; } 
            public string client_position { get; set; }
            public string client_involved_projects {  get; set; }
            public string client_phone_number { get; set; }
            public string client_email {  get; set; }
        
        
        
        
        } 
        public client()
        {
            InitializeComponent();
        }

        private void client_Load(object sender, EventArgs e)
        {
            navbar1.navigation_current_page(current_window);
            load_clients();
        }
        private void load_clients() {
            
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string loadcommand = "SELECT * FROM clients";
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand,con)) 
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            flowLayoutPanel1.Controls.Clear();
                        



                            int yoffset = 0;
                            while (reader.Read())
                            {
                                var current_client = new client_details
                                {
                                    client_name = reader["client_name"].ToString(),
                                    client_company = reader["client_company"].ToString(),
                                    client_position = reader["client_position"].ToString(),
                                    client_involved_projects = reader["client_involved_projects"].ToString(),
                                    client_phone_number = reader["client_phone_number"].ToString(),
                                    client_email = reader["client_email"].ToString()


                                };
                                string client_json = JsonSerializer.Serialize(current_client);
                                client_table table = new client_table
                                {
                                    Location = new Point(10, yoffset)

                                };
                                flowLayoutPanel1.Controls.Add(table);
                                table.update_values(client_json);
                                yoffset += 10;
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

        private void client_add_client_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form client_add = new add_client();
            client_add.ShowDialog();
            this.Close();

        }
    }

}
