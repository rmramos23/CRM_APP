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
using MySql.Data.MySqlClient;
namespace EEI_CRM
{
    public partial class task_table : UserControl
    {
        string constring = "server=localhost;uid=root;pwd=14789653Rm;database=eeipc_crm";
        Button status_button = new Button();
        Label project_label = new Label(); 
        private class TaskDetails
        {
            public string task_name { get; set; }
            public string task_group { get; set; }
            public string task_category { get; set; }
            public string task_due_date { get; set; }
            public string task_status { get; set; }
            public string task_project { get; set; }
            public string task_priority { get; set; }   
            public bool is_sort_state { get; set; }


        }

        public task_table()
        { 
            InitializeComponent();
        }
        public void update_values(string json) 
        {
            try
            {
                TaskDetails current_task = JsonSerializer.Deserialize<TaskDetails>(json); // saving deserialized data of json_project to AddProject project class
                task_task_name.Text = current_task.task_name;
                task_task_group.Text = current_task.task_group;
                task_task_category.Text = current_task.task_category;
                task_task_due_date.Text = current_task.task_due_date;
                task_task_priority.Text = current_task.task_priority;
                task_task_project.Text = current_task.task_project;

                task_task_status.Texts = current_task.task_status;
                if (task_task_status.Texts == "Not Started")
                {
                    task_task_status.BackColor = Color.OrangeRed;
                    task_task_status.ListBackColor = Color.OrangeRed;
                }
                else if (task_task_status.Texts == "Ongoing")
                {

                    task_task_status.BackColor = Color.FromArgb(59, 59, 59);
                    task_task_status.ListBackColor = Color.FromArgb(59, 59, 59);
                }
                else if (task_task_status.Texts == "Finished")
                {
                    task_task_status.BackColor = Color.FromArgb(16, 188, 131);
                    task_task_status.ListBackColor = Color.FromArgb(16, 188, 131);
                }


            }
            catch (Exception ex)
            {
                // Handle or log the exception
                Console.WriteLine("An error occurred while updating values: " + ex.Message);
            }

        }

        private void task_task_status_OnSelectedIndexChanged(object sender, EventArgs e)
        {

            //Not Started
            //Ongoing
            //Finished
            if (task_task_status.Texts == "Not Started") {
                task_task_status.BackColor = Color.OrangeRed; 
                task_task_status.ListBackColor = Color.OrangeRed;
            }
            else if (task_task_status.Texts == "Ongoing") {

                task_task_status.BackColor = Color.FromArgb(59,59,59);
                task_task_status.ListBackColor = Color.FromArgb(59, 59, 59);
            }
            else if(task_task_status.Texts == "Finished") {
                task_task_status.BackColor = Color.FromArgb(16, 188, 131);
                task_task_status.ListBackColor = Color.FromArgb(16, 188, 131);
            }

            update_database_task_table();

        }
        private void update_database_task_table() {

            using (MySqlConnection con = new MySqlConnection(constring)) 
            {
                try 
                {
                    con.Open();
                    string command = "UPDATE tasks SET task_status = @status WHERE task_name = @task_name AND task_project = @task_project";
                    using (MySqlCommand cmd = new MySqlCommand(command, con)) 
                    {
                        cmd.Parameters.AddWithValue("@task_name", task_task_name.Text);
                        cmd.Parameters.AddWithValue("@task_project", task_task_project.Text);
                        cmd.Parameters.AddWithValue("@status", task_task_status.Texts);
                        //MessageBox.Show(task_task_name.Text + "," + task_task_project.Text + "," + task_task_status.Texts);
                        cmd.ExecuteNonQuery();  


                    }
                    

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        
        
        
        
        
        
        }
    }
}
