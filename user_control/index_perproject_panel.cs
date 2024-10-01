using EEI_CRM.PAGES;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEI_CRM
{
    public partial class index_perproject_panel : UserControl
    {
        public class AddProject
        {
            public string project_name { get; set; }
            public string project_cost { get; set; }
            public string project_status { get; set; }
        }

        public index_perproject_panel()
        {
            InitializeComponent();
        }

        public void update_value(string json_project)
        {
            try
            {
                AddProject project = JsonSerializer.Deserialize<AddProject>(json_project); // saving deserialized data of json_project to AddProject project class

                this.project_name.Text = project.project_name;
                project_cost.Text = "$" + project.project_cost; // Format as currency

                if (project.project_status == "FINISHED")
                {
                    rounded_panel3.BackColor = Color.FromArgb(16, 188, 131);
                }
                else {
                    rounded_panel3.BackColor = Color.OrangeRed;
                }
                //label3.Text = project.ProjectStatus
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                Console.WriteLine("An error occurred while updating values: " + ex.Message);
            }
        }

     

        private void rounded_panel2_Click(object sender, EventArgs e)
        {

            index index = this.FindForm() as index;
            if (index != null)
            {
                string current_project = this.project_name.Text;
                index.dashboard_update_data(current_project);
                index.load_chart_panel();

            }

        }
    }
}
