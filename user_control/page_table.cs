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
using System.Transactions;
namespace EEI_CRM
{
    public partial class page_table : UserControl
    {
        string constring = Properties.Settings.Default.constring;
        string current_project_name;

        private class project_details
        {
            public string project_name { get; set; }
            public string project_start_date { get; set; }
            public string project_due_date { get; set; }
            public int project_progress_percent { get; set; }
            public string project_status { get; set; }
            public string project_department { get; set; }

        }
        public page_table()
        {
            InitializeComponent();
        }

        public void update_values(string json) 
        {
            try
            { 
                project_details current_project = JsonSerializer.Deserialize<project_details>(json);
                project_name.Text = current_project.project_name;
                project_start_date.Text =  current_project.project_start_date;
                project_due_date.Text = current_project.project_due_date;
                project_progress_perc.Text =current_project.project_progress_percent + "%";
                project_department.Text = current_project.project_department;
                current_project_name = current_project.project_name;
                if (current_project.project_status == "FINISHED")
                {
                    project_status_label.Text = current_project.project_status;
                    project_status_panel.BackColor = Color.FromArgb(16, 188, 131);

                }
                else
                {
                    project_status_label.Text = current_project.project_status;
                    project_status_panel.BackColor = Color.OrangeRed;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void project_name_Click(object sender, EventArgs e)
        {
            Form current = this.FindForm();
            if (current != null) 
            {
                current.Hide();
                Form project_info = new PAGES.project_details(current_project_name);
                project_info.ShowDialog();
                current.Close();
            }
        }


    }

}
