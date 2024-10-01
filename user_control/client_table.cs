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

namespace EEI_CRM.user_control
{
    public partial class client_table : UserControl
    {
        string name;
        private class client_details
        {
            public string client_name { get; set; }
            public string client_company { get; set; }
            public string client_position { get; set; }
            public string client_involved_projects { get; set; }
            public string client_phone_number { get; set; }
            public string client_email { get; set; }
        }


            public client_table()
        {
            InitializeComponent();
        }
        public void update_values(string json) { 
        client_details current_details = JsonSerializer.Deserialize<client_details>(json);
            rounded_button1.Text = current_details.client_name; 
            label2.Text = current_details.client_company;
            label3.Text = current_details.client_position;
            label4.Text = current_details.client_phone_number;
            label5.Text = current_details.client_email;
            name = current_details.client_name;
        }



        private void rounded_button1_Click(object sender, EventArgs e)
        {
            Form current_form = this.FindForm();
            if (current_form != null)
            {

                current_form.Hide();
                Form profile = new PAGES.client_profile(name);
                profile.ShowDialog();

                current_form.Close();



            }

        }
    }
}
