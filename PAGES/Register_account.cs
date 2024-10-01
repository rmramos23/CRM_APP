using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EEI_CRM
{
    public partial class Register_account : Form
    {

        string constring = Properties.Settings.Default.constring;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private class heads
        {
            public string gsm = "";
            public string tsg;
            public string ra;
            public string oi;
            public string sp;
            public string sbu;
            public string pcg;
            public string ees;
            public string pgb;

        }

        heads dept_names = new heads();
        class New_user
        {

            public string name;
            public string email;
            public string departent;
            public string position;
            public string reporting_to;
            public string password;
            public string username;




        }
        public Register_account()
        {
            InitializeComponent();
        }




        private void Register_account_Load(object sender, EventArgs e)
        {
            load_heads();
            //register_account_reportingto_Focus_Leave(sender, e);
        }

        private void register_account_register_button_Click(object sender, EventArgs e)
        {
            // Define the connection string to connect to MySQL database
            New_user user = new New_user();
            int error_state = check_for_empty();
            switch (error_state)
            {
                case 1:
                    MessageBox.Show("ENTER NAME", "EEI POWER CORP.", MessageBoxButtons.OK);
                    break;
                case 2:
                    MessageBox.Show("ENTER EMAIL", "EEI POWER CORP.", MessageBoxButtons.OK);
                    break;
                case 3:
                    MessageBox.Show("ENTER DEPARTMENT", "EEI POWER CORP.", MessageBoxButtons.OK);
                    break;
                case 4:
                    MessageBox.Show("PASSWORD DO NOT MATCH", "EEI POWER CORP.", MessageBoxButtons.OK);
                    break;
                case 5:
                    MessageBox.Show("Enter Positino", "EEI POWER CORP.", MessageBoxButtons.OK);
                    break;
                default:
                    user.name = register_account_name_box.Texts;
                    user.email = register_account_email_box.Texts;
                    user.password = register_account_password1_box.Texts;
                    user.position = register_account_position_box.Texts;
                    //user.reporting_to = register_account_department_box.Texts;
                    user.departent = register_account_department_box.Texts;
                    user.reporting_to = load_reporting_to(user.departent);
                    using (MySqlConnection con = new MySqlConnection(constring))
                    {
                        try
                        {
                            con.Open();
                            string user_input = "INSERT INTO users(name, email,department, position, passkey, reporting_to, state) VALUES( @name, @email,@department,@position, @password, @reportingto, @state)";

                            using (MySqlCommand cmd = new MySqlCommand(user_input, con))
                            {
                                cmd.Parameters.AddWithValue("@name", user.name);
                                cmd.Parameters.AddWithValue("@email", user.email);
                                cmd.Parameters.AddWithValue("@department", user.departent);
                                cmd.Parameters.AddWithValue("@position", user.position);
                                cmd.Parameters.AddWithValue("@password", user.password);
                                cmd.Parameters.AddWithValue("@reportingto", user.reporting_to);
                                cmd.Parameters.AddWithValue("@state", "Unverified");

                                // Execute the command
                                cmd.ExecuteNonQuery();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    DialogResult result;
                    result = MessageBox.Show("Welcome to EEI Power, " + user.name + "\nWait For the Approval of your Superior", "EEI POWER CORP.", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        this.Hide();
                        Form login = new login_page();
                        login.ShowDialog();
                    }
                    break;
            }
        }


        private void load_heads() 
        {
            using (MySqlConnection con = new MySqlConnection(constring)) 
            {
                try 
                {
                    con.Open();
                    string loadcommand = "SELECT * FROM department";
                    using (MySqlCommand cmd  =  new MySqlCommand (loadcommand, con )) 
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader()) 
                        {
                            if (reader.Read()) 
                            {
                                dept_names.gsm = reader["gsm"].ToString();
                                dept_names.tsg = reader["tsg"].ToString();
                                dept_names.ra = reader["ra"].ToString();
                                dept_names.oi = reader["oi"].ToString();
                                dept_names.sp = reader["sp"].ToString();
                                dept_names.sbu = reader["sbu"].ToString();
                                dept_names.pcg = reader["pcg"].ToString();
                                dept_names.ees = reader["ees"].ToString();
                                dept_names.pgb = reader["pgb"].ToString();

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
        private string load_reporting_to(string department) 
        {

            string reporting_to= "";
            switch (department) 
            {
                case "GENERAL SERVICES AND MARKETING":
                    reporting_to = dept_names.gsm;
                    break;
                case "TECHNICAL SERVICE GROUP":
                    reporting_to = dept_names.tsg;
                    break;
                case "REGULATORY AFFAIRS":
                    reporting_to = dept_names.ra;
                    break;
                case "OPERATIONS AND INNOVATIONS":
                    reporting_to = dept_names.oi;
                    break;
                case "STRATEGY AND PLANNING":
                    reporting_to = dept_names.sp;
                    break;
                case "SOLAR BUSINESS UNIT":
                    reporting_to = dept_names.sbu;
                    break;
                case "POWER CONTRACTING GROUP":
                    reporting_to = dept_names.pcg;
                    break;
                case "ENERGY EFFICIENCY SERVICES":
                    reporting_to = dept_names.ees;
                    break;
                case "POWER GENERATION BUSINESS DEV/RES":
                    reporting_to = dept_names.pgb;
                    break;
                default:
                    break;
            }
            


            return reporting_to;
        }
       
        private int check_for_empty() {
            if (register_account_name_box.Texts == "")
            {
                return 1;
            }
            else if (register_account_email_box.Texts == "")
            {
                return 2;
            }
            else if (register_account_department_box.Texts == "")
            {
                return 3;
            }
            else if (register_account_password1_box.Texts != register_account_password2_box.Texts) {

                register_account_password1_box.Texts = "";
                register_account_password2_box.Texts = "";
                return 4;


            }
            else if (register_account_position_box.Texts == "") 
            {
                return 5;
            }
                return 0;
        }





        private void nav_bar1_mousedown(object sender, MouseEventArgs e)
        {

            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void nav_bar1_mousemove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void nav_bar1_mouseup(object sender, MouseEventArgs e)
        {
            dragging = false;
        }






        private void register_account_password2_box__TextChanged(object sender, EventArgs e)
        {

        }

        private void register_account_reportingto_Enter(object sender, EventArgs e)
        {


        }

        private void register_account_reportingto_Leave(object sender, EventArgs e)
        {

       
        }

        private void register_account_reportingto_Focus_Enter(object sender, EventArgs e)
        {
            register_account_department_box.IconColor = Color.FromArgb(0, 0, 55);
            //register_account_department_box.BorderColor = Color.FromArgb(0, 0, 55);
            register_account_department_box.ForeColor = Color.FromArgb(0, 0, 55);
        }

        private void register_account_reportingto_Focus_Leave(object sender, EventArgs e)
        {
            register_account_department_box.IconColor = Color.Gray;
            //register_account_department_box.BorderColor = Color.FromArgb(169, 169, 169);
            register_account_department_box.ForeColor = Color.Gray;
        }


        private void register_account_name_box__TextChanged(object sender, EventArgs e)
        {
            if (register_account_name_box.Texts.Length == 0) {
             
                register_account_name_box.Texts = (register_account_name_box.Text).ToUpper();
            }
        }

        private void Register_account_KeyDown(object sender, KeyEventArgs e)
        {
        
        }

        private void register_account_password2_box_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                register_account_register_button_Click(sender, e);
            }
        }

 
    }
}
