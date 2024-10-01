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
namespace EEI_CRM.PAGES
{
    public partial class settings_unverified_accounts : Form
    {
        string constring = Properties.Settings.Default.constring;
        private class unverified_user
        {
            public string name { get; set; }
            public string email { get; set; }
            public string department { get; set; }
            public string state { get; set; }
        }
        public settings_unverified_accounts()
        {
            InitializeComponent();
        }


        private void settings_unverified_accounts_Load(object sender, EventArgs e)
        {
            load_unverified_users();
        }

        private void load_unverified_users() 
        {
            using (MySqlConnection con  = new MySqlConnection(constring)) 
            {

                try 
                {
                    con.Open();
                    string loadcommand = "SELECT * FROM users where state = @state";
                    using (MySqlCommand cmd =  new MySqlCommand(loadcommand, con))
                    {
                        cmd.Parameters.AddWithValue("@state", "Unverified");
                        using (MySqlDataReader reader =  cmd.ExecuteReader())
                        {
                            int yOffSet = 0;
                            while (reader.Read()) 
                            {
                                
                                unverified_user user = new unverified_user
                                {
                                    name = reader["name"].ToString(),
                                    email = reader["email"].ToString(),
                                    department = reader["department"].ToString(),
                                    state = reader["state"].ToString()
                                };
                                string user_info =  JsonSerializer.Serialize(user);



                                var table = new settings_unverified_table
                                {
                                    Location = new Point(0, yOffSet)
                                };
                                flowLayoutPanel1.Controls.Add(table);
                                table.update_values(user_info);
                                yOffSet += 10 + table.Height;
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

        private void settings_back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form settings_page = new settings();
            settings_page.ShowDialog();
            this.Close();

        }
    }
}
