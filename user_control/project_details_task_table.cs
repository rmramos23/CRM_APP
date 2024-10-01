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
    public partial class project_details_task_table : UserControl
    {
        private class task_details
        {
            public string task_name { get; set; }
            public string status { get; set; }
            
        };
        public project_details_task_table()
        {
            InitializeComponent();
        }
        public void update_table_values(string details) 
        {
            try
            {
                task_details current_details = JsonSerializer.Deserialize<task_details>(details);  
                task_name.Text = current_details.task_name;
                task_status.Text = current_details.status;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
