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
namespace EEI_CRM
{
    public partial class settings_unverified_table : UserControl
    {
        private string constring = Properties.Settings.Default.constring;
        private class unverified_user
        {
            public string name { get; set; }
            public string email { get; set; }
            public string department { get; set; }
            public string state { get; set; }
        }
        public settings_unverified_table()
        {
            InitializeComponent();
        }
        public void update_values(string info)
        {
            try
            {
                unverified_user unverified_user_info = JsonSerializer.Deserialize<unverified_user>(info);
                this.name_label.Text = unverified_user_info.name;
                this.email_label.Text = unverified_user_info.email;
                this.department_label.Text = unverified_user_info.department;
                this.state_box.Texts = unverified_user_info.state;
                if (state_box.Texts.ToLower() == "unverified" ) 
                {
                    state_box.BackColor = Color.OrangeRed;
                    state_box.ListBackColor = Color.OrangeRed;
                }
                else
                {
                    state_box.BackColor = Color.FromArgb(16, 188, 131);
                    state_box.ListBackColor = Color.FromArgb(16, 188, 131);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }   
        }

        private void state_box_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(constring)) 
            {
                try
                {
                    con.Open();
                    string loadcommand = "UPDATE users SET state = @state, employment_status = @employment_status WHERE name = @name AND email = @email";
                    using (MySqlCommand cmd =  new MySqlCommand(loadcommand, con)) 
                    {
                        cmd.Parameters.AddWithValue("@state", state_box.Texts);
                        cmd.Parameters.AddWithValue("@employment_status", "Active");
                        cmd.Parameters.AddWithValue("@name", name_label.Text);
                        cmd.Parameters.AddWithValue("@email", email_label.Text);
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
                Form settings = new settings();
                settings.ShowDialog();
                reload.Close();                                                                      
            }
        }
    }
}
