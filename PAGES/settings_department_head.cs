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
    public partial class settings_department_head : Form
    {
        private string constring =  Properties.Settings.Default.constring;
        private class dept_head 
        {
            public string gm;
            public string gsm;
            public string tsg;
            public string ra;
            public string oi;
            public string sp;
            public string sbu;
            public string pcg;
            public string ees;
            public string pgb;
        }
        public settings_department_head()
        {
            InitializeComponent();


        }

        private void settings_department_head_Load(object sender, EventArgs e)
        {
            load_current_head();
            load_department_head_options();
        }
        private void load_current_head() 
        {

            //gsm_box.Texts = "awelhfawebuifhaewiufuew";
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
                                gm_box.Texts = reader["gm"].ToString();
                                gsm_box.Texts = reader["gsm"].ToString();
                                tsg_box.Texts = reader["tsg"].ToString();
                                ra_box.Texts = reader["ra"].ToString();
                                oi_box.Texts = reader["oi"].ToString();
                                sp_box.Texts = reader["sp"].ToString();
                                sbu_box.Texts = reader["sbu"].ToString();
                                pcg_box.Texts = reader["pcg"].ToString();
                                ees_box.Texts = reader["ees"].ToString();
                                pgb_box.Texts = reader["pgb"].ToString();
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
        private void load_department_head_options() 
        {
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string loadcommand = "SELECT * FROM users WHERE state = @state";
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con)) 
                    {
                        cmd.Parameters.AddWithValue("@state", "Approved");
                        using (MySqlDataReader reader =  cmd.ExecuteReader())
                        {
                            while (reader.Read()) 
                            {
                                string name = reader["name"].ToString();
                                gm_box.Items.Add(name);
                                gsm_box.Items.Add(name);
                                tsg_box.Items.Add(name);
                                ra_box.Items.Add(name);
                                oi_box.Items.Add(name);
                                sp_box.Items.Add(name);
                                sbu_box.Items.Add(name);
                                pcg_box.Items.Add(name);
                                ees_box.Items.Add(name);
                                pgb_box.Items.Add(name);
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

        private void settings_department_head_save_button_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con =  new MySqlConnection(constring)) 
            {
                try 
                {
                    con.Open();
                    string loadcommand = "UPDATE department SET gm = @gm, gsm = @gsm, tsg = @tsg, ra = @ra, oi = @oi, sp = @sp, sbu = @sbu, pcg = @pcg, ees = @ees, pgb = @pgb";
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                    {
                        cmd.Parameters.AddWithValue("@gm", gm_box.Texts);
                        cmd.Parameters.AddWithValue("@gsm", gsm_box.Texts);
                        cmd.Parameters.AddWithValue("@tsg", tsg_box.Texts);
                        cmd.Parameters.AddWithValue("@ra", ra_box.Texts);
                        cmd.Parameters.AddWithValue("@oi", oi_box.Texts);
                        cmd.Parameters.AddWithValue("@sp", sp_box.Texts);
                        cmd.Parameters.AddWithValue("@sbu", sbu_box.Texts);
                        cmd.Parameters.AddWithValue("@pcg", pcg_box.Texts);
                        cmd.Parameters.AddWithValue("@ees", ees_box.Texts);
                        cmd.Parameters.AddWithValue("@pgb", pgb_box.Texts);
                        cmd.ExecuteNonQuery();

                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
            settings_back_button_Click(sender, e);
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
