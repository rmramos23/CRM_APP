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
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using EEI_CRM.PAGES;

namespace EEI_CRM.user_control
{
    public partial class settings_employee_list_table : UserControl
    {
        private string constring  =  Properties.Settings.Default.constring;
        private class employee_info
        {
            public string name { get; set; }
            public string email { get; set; }
            public string department { get; set; }
            public string status { get; set; }
        }
        public settings_employee_list_table()
        {
            InitializeComponent();
        }
        public void update_info(string info) 
        {
            employee_info current_info = JsonSerializer.Deserialize<employee_info>(info);
            name_label.Text = current_info.name;
            email_label.Text = current_info.email;
            department_label.Text = current_info.department;
            status_box.Texts = current_info.status;
            if (status_box.Texts == "Active")
            {
                status_box.BackColor = Color.FromArgb(16, 188, 131);
                status_box.ListBackColor = Color.FromArgb(16, 188, 131);
                //name_label.ForeColor = Color.FromArgb(16, 188, 131);
                //email_label.ForeColor = Color.FromArgb(16, 188, 131);
                //department_label.ForeColor = Color.FromArgb(16, 188, 131);
            }
            else
            {
                status_box.BackColor = Color.OrangeRed;
                status_box.ListBackColor = Color.OrangeRed;
                //name_label.ForeColor = Color.OrangeRed;
                //email_label.ForeColor = Color.OrangeRed;
                //department_label.ForeColor = Color.OrangeRed;

            }


        }

        private void status_box_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection con  = new MySqlConnection(constring)) 
            {
                try
                {
                    con.Open();
                    string loadcommand = "UPDATE users SET employment_status = @status WHERE name = @name AND email = @email AND department = @department";
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con)) 
                    {
                        cmd.Parameters.AddWithValue("@status", status_box.Texts);
                        cmd.Parameters.AddWithValue("@name", name_label.Text);
                        cmd.Parameters.AddWithValue("@email", email_label.Text);
                        cmd.Parameters.AddWithValue("@department", department_label.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }

            }
            Form reload = this.FindForm();
            if (reload != null)
            {
                reload.Hide();
                Form employee_list = new settings_employee_list();
                employee_list.ShowDialog();
                reload.Close();
            }
            
        }
    }
}
