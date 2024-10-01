using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EEI_CRM
{
    public partial class login_page : Form
    {
        //string constring = "server=localhost;uid=root;pwd=14789653Rm;database=eeipc_crm";
        string constring = Properties.Settings.Default.constring;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;


        // Place public variables here RM
        public login_page()
        {
            InitializeComponent();
        }
        private void login_page_Load(object sender, EventArgs e)
        {
            login_email_box.Texts = Properties.Settings.Default.Username;
            login_password_box.Texts = Properties.Settings.Default.Password;
            if (Properties.Settings.Default.Remember_me == true)
            {
                login_rememberme_box.Checked = true;
            }
            else 
            {
                login_rememberme_box.Checked = false;
            }
        }




        private void login_Click(object sender, EventArgs e)
        {

           

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();

                    string sql = "SELECT * FROM users WHERE email=@email AND passkey=@password";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@email", login_email_box.Texts);
                        cmd.Parameters.AddWithValue("@password", login_password_box.Texts);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string state = (reader["state"].ToString()).ToLower();
                                if (state == "approved")
                                {
                                    string firstName = reader["name"].ToString();
                                  

                         

                                        if (login_rememberme_box.Checked)
                                        {
                                            Properties.Settings.Default.Username = login_email_box.Texts;
                                            Properties.Settings.Default.Password = login_password_box.Texts;
                                            Properties.Settings.Default.Remember_me = true; 
                                            Properties.Settings.Default.Save();

                                        }
                                        else
                                        {
                                            Properties.Settings.Default.Username = "";
                                            Properties.Settings.Default.Password = "";
                                            Properties.Settings.Default.Remember_me = false;
                                            Properties.Settings.Default.Save();
                                        }
                                        int active_user_id = (int)reader["id"];
                                        Properties.Settings.Default.active_user = active_user_id;
                                        this.Hide();
                                        
                                        Form indexForm = new index(); 
                                        indexForm.ShowDialog(); 
                                        this.Close();
                                }


                                
                                else
                                {
                                    login_email_box.Texts = "";
                                    login_password_box.Texts = "";
                                    MessageBox.Show("User not yet approved, wait for approval of supervisor", "EEI POWER CORP.", MessageBoxButtons.OK);

                                }

                            }
                            else
                            {
                                // If no user is found, clear the input fields and show an error message
                                login_email_box.Texts = "";
                                login_password_box.Texts = "";
                                MessageBox.Show("ENTER A VALID USERNAME AND PASSWORD", "EEI POWER CORP.", MessageBoxButtons.OK);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur, such as database connection issues
                    //MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Please Check Database Settings\n ERROR:" + ex.Message, "DATABASE ERROR", MessageBoxButtons.OK);
                }
            }
        }





        private void login_create_profile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form register = new Register_account();
            register.ShowDialog();
            this.Close();
        }
        private void login_create_profile_MouseHover(object sender, EventArgs e)
        {
            login_create_profile.Cursor = Cursors.Hand;  
        }




        private void login_page_MouseDown(object sender, MouseEventArgs e)
        {

            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void login_page_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void login_page_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void exit_button_hover(object sender, EventArgs e)
        {
            exit_button.Cursor = Cursors.Hand;
        }

        private void exit_button_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void login_username_box_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true;
            }
        }

        private void login_username_box__TextChanged(object sender, EventArgs e)
        {

        }

        private void login_password_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_Click(sender, e);
            }

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rounded_button1_Click(object sender, EventArgs e)
        {
            if (login_settings_panel.Visible)
            {
                login_settings_panel.Visible = false;
            }
            else
            {
                login_settings_panel.Visible = true ;

            }
        }

        private void server_edit_save_button_Click(object sender, EventArgs e)
        {
            string new_constring = "server=" + server_box.Texts+";uid=" + uid_box.Texts + ";pwd=" + password_box.Texts + ";database=" + database_box.Texts ;
            Properties.Settings.Default.constring = new_constring;

            this.Hide();
            Form refresh = new login_page();
            refresh.ShowDialog();  
            this.Close();

        }

        private void server_box_Enter(object sender, EventArgs e)
        {
            if (server_box.Texts == "Insert Server/Host") 
            {
                server_box.Texts = "";
            }
        }

        private void uid_box_Enter(object sender, EventArgs e)
        {
            if (uid_box.Texts == "Insert UID")
            {
                uid_box.Texts = "";
            }

        }

        private void password_box_Enter(object sender, EventArgs e)
        {
            if (password_box.Texts == "Insert Password")
            {
                password_box.Texts = "";
                password_box.PasswordChar = true;
            }

        }

        private void database_box_Enter(object sender, EventArgs e)
        {
            if (database_box.Texts == "Insert Database")
            {
                database_box.Texts = "";
            }

        }

        private void rounded_button1_MouseHover(object sender, EventArgs e)
        {
            //rounded_button1.BackColor = Color.DimGray;
        }
    }
}
