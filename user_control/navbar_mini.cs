using EEI_CRM.PAGES;
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
    public partial class navbar_mini : UserControl
    {
        private string constring = Properties.Settings.Default.constring;
        public int user_id = Properties.Settings.Default.active_user;
        private class admin_name
        {
            public string gm = "";
            public string gsm = "";
            public string tsg = "";
            public string ra = "";
            public string oi = "";
            public string sp = "";
            public string sbu = "";
            public string pcg = "";
            public string ees = "";
            public string pgb = "";
        }
        private string active_user_name;
        public navbar_mini()
        {

            InitializeComponent();


        }
        public void navigation_current_page(string current_window)
        {
            switch (current_window)
            {
                case "DASHBOARD":
                    navigation_dashboard_button.BackColor = Color.FromArgb(0, 0, 55);
                    break;
                case "PROJECTS":
                    navigation_data_button.BackColor = Color.FromArgb(0, 0, 55);
                    break;
                case "TASKS":
                    navigation_tasks_button.BackColor = Color.FromArgb(0, 0, 55);
                    break;
                case "PROFILE":
                    navigation_profile_button.BackColor = Color.FromArgb(0, 0, 55);
                    break;
                case "SETTINGS":
                    navigation_settings_button.BackColor = Color.FromArgb(0, 0, 55);
                    break;
                case "CLIENT":
                    navigation_client_button.BackColor = Color.FromArgb(0, 0, 55);
                    break;


                default:
                    MessageBox.Show("error navigation back color pull", "error");
                    break;


            }

        }

        private void navigation_dashboard_button_Click(object sender, EventArgs e)
        {

            Form current_form = this.FindForm();
            if (current_form != null)
            {
                current_form.Hide();
                Form index = new index();
                index.ShowDialog();
                current_form.Close();
            }

        }

        private void navigation_profile_button_Click(object sender, EventArgs e)
        {
            Form current_form = this.FindForm();
            if (current_form != null)
            {
                current_form.Hide();
                Form profile = new user_profile();
                profile.ShowDialog();
                current_form.Close();
            }
        }

        private void navigation_logout_button_Click(object sender, EventArgs e)
        {
            Form current_form = this.FindForm();
            if (current_form != null)
            {
                current_form.Hide();
                Form login = new login_page();
                login.ShowDialog();
                current_form.Close();
            }
        }

        private void navigation_data_button_Click(object sender, EventArgs e)
        {
            Form current_form = this.FindForm();
            if (current_form != null)
            {
                current_form.Hide();
                Form project = new project_page();
                project.ShowDialog();
                current_form.Close();
            }
        }

        private void navigation_tasks_button_Click(object sender, EventArgs e)
        {
            Form current_form = this.FindForm();
            if (current_form != null)
            {
                current_form.Hide();
                Form tasks = new tasks();
                tasks.ShowDialog();
                current_form.Close();
            }
        }

        private void navigation_settings_button_Click(object sender, EventArgs e)
        {

            //get name
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string loadcommand = "SELECT * FROM users where id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(loadcommand, con))
                    {
                        cmd.Parameters.AddWithValue("@id", user_id);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                active_user_name = reader["name"].ToString();
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            if (check_creds(active_user_name))
            {
                Form current_form = this.FindForm();
                if (current_form != null)
                {
                    current_form.Hide();
                    Form settings = new settings();
                    settings.ShowDialog();
                    current_form.Close();
                }
            }
            else
            {
                //do not have auth
                MessageBox.Show("CANT ACCESS");
            }


        }
        private bool check_creds(string name)
        {
            Console.WriteLine(name);
            admin_name names = new admin_name();
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
                                names.gm = reader["gm"].ToString();
                                names.gsm = reader["gsm"].ToString();
                                names.tsg = reader["tsg"].ToString();
                                names.ra = reader["ra"].ToString();
                                names.oi = reader["oi"].ToString();
                                names.sp = reader["sp"].ToString();
                                names.sbu = reader["sbu"].ToString();
                                names.pcg = reader["pcg"].ToString();
                                names.ees = reader["ees"].ToString();
                                names.pgb = reader["pgb"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (name == names.gm)
            {
                return true;
            }
            else if (name == names.gsm)
            {
                return true;
            }
            else if (name == names.tsg)
            {
                return true;
            }
            else if (name == names.ra)
            {
                return true;
            }
            else if (name == names.oi)
            {
                return true;
            }
            else if (name == names.sbu)
            {
                return true;
            }
            else if (name == names.pcg)
            {
                return true;
            }
            else if (name == names.ees)
            {
                return true;
            }
            else if (name == names.pgb)
            {
                return true;
            }
            else if (name == "ADMIN")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void navigation_dashboard_button_MouseHover(object sender, EventArgs e)
        {
            navigation_dashboard_button.Cursor = Cursors.Hand;
        }

        private void navigation_data_button_MouseHover(object sender, EventArgs e)
        {
            navigation_data_button.Cursor = Cursors.Hand;
        }

        private void navigation_tasks_button_MouseHover(object sender, EventArgs e)
        {
            navigation_tasks_button.Cursor = Cursors.Hand;
        }

        private void navigation_profile_button_MouseHover(object sender, EventArgs e)
        {
            navigation_profile_button.Cursor = Cursors.Hand;
        }

        private void navigation_settings_button_MouseHover(object sender, EventArgs e)
        {
            navigation_settings_button.Cursor = Cursors.Hand;
        }

        private void navigation_logout_button_MouseHover(object sender, EventArgs e)
        {
            navigation_logout_button.Cursor = Cursors.Hand;
        }


        private void navigation_client_button_Click(object sender, EventArgs e)
        {
            Form current_form = this.FindForm();
            if (current_form != null)
            {
                current_form.Hide();
                Form client = new client();
                client.ShowDialog();
                current_form.Close();
            }

        }
    }
}
