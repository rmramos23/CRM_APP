namespace EEI_CRM.user_control
{
    partial class project_details_task_table
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.task_name = new System.Windows.Forms.Label();
            this.task_status = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.task_status, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.task_name, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(349, 23);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // task_name
            // 
            this.task_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.task_name.Location = new System.Drawing.Point(3, 0);
            this.task_name.Name = "task_name";
            this.task_name.Size = new System.Drawing.Size(168, 23);
            this.task_name.TabIndex = 0;
            this.task_name.Text = "label1";
            this.task_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // task_status
            // 
            this.task_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.task_status.Location = new System.Drawing.Point(177, 0);
            this.task_status.Name = "task_status";
            this.task_status.Size = new System.Drawing.Size(169, 23);
            this.task_status.TabIndex = 1;
            this.task_status.Text = "label2";
            this.task_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // project_details_task_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "project_details_task_table";
            this.Size = new System.Drawing.Size(349, 23);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label task_status;
        private System.Windows.Forms.Label task_name;
    }
}
