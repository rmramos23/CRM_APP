using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using System.Text.Json;
using EEI_CRM.PAGES;
namespace EEI_CRM
{
    public partial class settings : Form
    {
        private class unverified_user 
        {
            public string name { get; set; }
            public string email { get; set; }   
            public string department { get; set; }
            public string state { get; set; }
        }
        private string constring = Properties.Settings.Default.constring;
        private string current_page = "SETTINGS";
        public settings()
        {

            InitializeComponent();
        }

        private void settings_Load(object sender, EventArgs e)
        {
            navbar1.navigation_current_page(current_page);

        }

        private void settings_department_head_button_Click(object sender, EventArgs e)
        {

 
            this.Hide();
            Form department_heads = new settings_department_head();
            department_heads.ShowDialog();
            this.Close();
        }



        //department_head_panel

        //load_dh_from_db
       
       

        private void settings_unverified_users_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form unverified_panel = new settings_unverified_accounts();
            unverified_panel.ShowDialog();
            this.Close();
        
        }

        private void settings_employee_list_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form employee_list =  new settings_employee_list();
            employee_list.ShowDialog();
            this.Close();  
        }
    }
}
