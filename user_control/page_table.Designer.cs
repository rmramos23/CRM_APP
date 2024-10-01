namespace EEI_CRM
{
    partial class page_table
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
            this.project_department = new System.Windows.Forms.Label();
            this.project_progress_perc = new System.Windows.Forms.Label();
            this.project_due_date = new System.Windows.Forms.Label();
            this.project_start_date = new System.Windows.Forms.Label();
            this.project_status_panel = new EEI_CRM.rounded_panel();
            this.project_status_label = new System.Windows.Forms.Label();
            this.project_name = new EEI_CRM.rounded_button();
            this.tableLayoutPanel1.SuspendLayout();
            this.project_status_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.Controls.Add(this.project_department, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.project_progress_perc, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.project_due_date, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.project_start_date, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.project_status_panel, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.project_name, 0, 0);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(880, 35);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // project_department
            // 
            this.project_department.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.project_department.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_department.Location = new System.Drawing.Point(633, 2);
            this.project_department.Name = "project_department";
            this.project_department.Size = new System.Drawing.Size(244, 30);
            this.project_department.TabIndex = 12;
            this.project_department.Text = "project_department";
            this.project_department.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // project_progress_perc
            // 
            this.project_progress_perc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.project_progress_perc.AutoSize = true;
            this.project_progress_perc.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_progress_perc.Location = new System.Drawing.Point(459, 10);
            this.project_progress_perc.Name = "project_progress_perc";
            this.project_progress_perc.Size = new System.Drawing.Size(17, 15);
            this.project_progress_perc.TabIndex = 8;
            this.project_progress_perc.Text = "%";
            // 
            // project_due_date
            // 
            this.project_due_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.project_due_date.AutoSize = true;
            this.project_due_date.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_due_date.Location = new System.Drawing.Point(328, 2);
            this.project_due_date.Name = "project_due_date";
            this.project_due_date.Size = new System.Drawing.Size(87, 30);
            this.project_due_date.TabIndex = 3;
            this.project_due_date.Text = "project_due_date";
            // 
            // project_start_date
            // 
            this.project_start_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.project_start_date.AutoSize = true;
            this.project_start_date.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_start_date.Location = new System.Drawing.Point(231, 2);
            this.project_start_date.Name = "project_start_date";
            this.project_start_date.Size = new System.Drawing.Size(90, 30);
            this.project_start_date.TabIndex = 2;
            this.project_start_date.Text = "project_start_date";
            // 
            // project_status_panel
            // 
            this.project_status_panel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.project_status_panel.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.project_status_panel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.project_status_panel.BorderRadius = 5;
            this.project_status_panel.BorderSize = 0;
            this.project_status_panel.Controls.Add(this.project_status_label);
            this.project_status_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.project_status_panel.ForeColor = System.Drawing.Color.White;
            this.project_status_panel.Location = new System.Drawing.Point(519, 3);
            this.project_status_panel.Name = "project_status_panel";
            this.project_status_panel.Size = new System.Drawing.Size(108, 29);
            this.project_status_panel.TabIndex = 13;
            this.project_status_panel.TextColor = System.Drawing.Color.White;
            // 
            // project_status_label
            // 
            this.project_status_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.project_status_label.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.project_status_label.Location = new System.Drawing.Point(-17, 0);
            this.project_status_label.Name = "project_status_label";
            this.project_status_label.Size = new System.Drawing.Size(142, 29);
            this.project_status_label.TabIndex = 14;
            this.project_status_label.Text = "label1";
            this.project_status_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // project_name
            // 
            this.project_name.BackColor = System.Drawing.Color.White;
            this.project_name.BackgroundColor = System.Drawing.Color.White;
            this.project_name.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.project_name.BorderRadius = 5;
            this.project_name.BorderSize = 0;
            this.project_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.project_name.FlatAppearance.BorderSize = 0;
            this.project_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.project_name.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.project_name.Location = new System.Drawing.Point(3, 3);
            this.project_name.Name = "project_name";
            this.project_name.Size = new System.Drawing.Size(222, 29);
            this.project_name.TabIndex = 14;
            this.project_name.Text = "rounded_button1";
            this.project_name.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.project_name.UseVisualStyleBackColor = false;
            this.project_name.Click += new System.EventHandler(this.project_name_Click);
            // 
            // page_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "page_table";
            this.Size = new System.Drawing.Size(880, 35);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.project_status_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label project_due_date;
        private System.Windows.Forms.Label project_start_date;
        private System.Windows.Forms.Label project_progress_perc;
        private System.Windows.Forms.Label project_department;
        private rounded_panel project_status_panel;
        private System.Windows.Forms.Label project_status_label;
        private rounded_button project_name;
    }
}
