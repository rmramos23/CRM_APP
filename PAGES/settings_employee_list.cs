using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using MySql.Data.MySqlClient;
using MySqlConnector.Logging;
using EEI_CRM.user_control;

namespace EEI_CRM.PAGES
{
    public partial class settings_employee_list : Form
    {
        private class employee_info 
        {
            public string name { get; set; }
            public string email { get; set; }
            public string department { get; set; }
            public string status { get; set; }
        }
        public string constring = Properties.Settings.Default.constring;
        public settings_employee_list()
        {
            InitializeComponent();
        }

        private void settings_employee_list_Load(object sender, EventArgs e)
        {
            
            load_list();
        }
        private void load_list() 
        {
            flowLayoutPanel1.Controls.Clear();
            using (MySqlConnection con =  new MySqlConnection(constring)) 
            {
                try
                {
                    con.Open();
                    string loadcommand = "SELECT * FROM users WHERE department LIKE @department AND employment_status LIKE @employment_status";
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                    {
                        //sorters
                        if (department_box.Texts == "Department (ALL)")
                        {
                            cmd.Parameters.AddWithValue("@department", "%%");

                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@department", "%" + department_box.Texts + "%");
                        }
                        if (employment_status_box.Texts == "Status (ALL)")
                        {
                            cmd.Parameters.AddWithValue("@employment_status", "%%");

                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@employment_status", "%" + employment_status_box.Texts + "%");

                        }
                        using (MySqlDataReader reader =  cmd.ExecuteReader()) 
                        {
                            int yOffSet = 0;
                            while(reader.Read())
                            {
                                employee_info info = new employee_info
                                {
                                    name = reader["name"].ToString(),
                                    email = reader["email"].ToString(),
                                    department = reader["department"].ToString(),
                                    status = reader["employment_status"].ToString()

                                };
                                string send_info = JsonSerializer.Serialize(info);
                                var table = new settings_employee_list_table
                                {
                                    Location = new Point(0, yOffSet)
                                };
                                flowLayoutPanel1.Controls.Add(table);
                                table.update_info(send_info);
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

        private void department_box_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            load_list();
        }

        private void employment_status_box_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            load_list();

        }
    }
}
