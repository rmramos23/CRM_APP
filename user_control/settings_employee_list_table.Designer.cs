namespace EEI_CRM.user_control
{
    partial class settings_employee_list_table
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
            this.department_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.email_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.status_box = new EEI_CRM.combo_box();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // department_label
            // 
            this.department_label.Location = new System.Drawing.Point(450, 0);
            this.department_label.Margin = new System.Windows.Forms.Padding(0);
            this.department_label.Name = "department_label";
            this.department_label.Size = new System.Drawing.Size(225, 36);
            this.department_label.TabIndex = 2;
            this.department_label.Text = "Department";
            this.department_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.department_label, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.email_label, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.status_box, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.name_label, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 36);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // email_label
            // 
            this.email_label.Location = new System.Drawing.Point(225, 0);
            this.email_label.Margin = new System.Windows.Forms.Padding(0);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(225, 36);
            this.email_label.TabIndex = 1;
            this.email_label.Text = "Email";
            this.email_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name_label
            // 
            this.name_label.Location = new System.Drawing.Point(0, 0);
            this.name_label.Margin = new System.Windows.Forms.Padding(0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(225, 36);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Name";
            this.name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // status_box
            // 
            this.status_box.BackColor = System.Drawing.Color.OrangeRed;
            this.status_box.BorderColor = System.Drawing.Color.White;
            this.status_box.BorderSize = 1;
            this.status_box.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.status_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.status_box.ForeColor = System.Drawing.Color.White;
            this.status_box.IconColor = System.Drawing.Color.White;
            this.status_box.Items.AddRange(new object[] {
            "Active",
            "Resigned"});
            this.status_box.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.status_box.ListTextColor = System.Drawing.Color.White;
            this.status_box.Location = new System.Drawing.Point(675, 0);
            this.status_box.Margin = new System.Windows.Forms.Padding(0);
            this.status_box.MinimumSize = new System.Drawing.Size(200, 30);
            this.status_box.Name = "status_box";
            this.status_box.Padding = new System.Windows.Forms.Padding(1);
            this.status_box.Size = new System.Drawing.Size(225, 36);
            this.status_box.TabIndex = 3;
            this.status_box.Texts = "Resigned";
            this.status_box.UnderLineState = false;
            this.status_box.OnSelectedIndexChanged += new System.EventHandler(this.status_box_OnSelectedIndexChanged);
            // 
            // settings_employee_list_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "settings_employee_list_table";
            this.Size = new System.Drawing.Size(901, 37);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label department_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label email_label;
        private combo_box status_box;
        private System.Windows.Forms.Label name_label;
    }
}
