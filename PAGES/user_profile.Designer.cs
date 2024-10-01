namespace EEI_CRM
{
    partial class user_profile
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_profile));
            this.current_page_label = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            this.rounded_panel1 = new EEI_CRM.rounded_panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.project_list_box = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.user_id_number_box = new EEI_CRM.text_box_mod();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.user_phone_number_box = new EEI_CRM.text_box_mod();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.user_reporting_to_box = new EEI_CRM.text_box_mod();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.user_position_box = new EEI_CRM.text_box_mod();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.user_department_box = new EEI_CRM.text_box_mod();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.user_email_box = new EEI_CRM.text_box_mod();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.user_name_box = new EEI_CRM.text_box_mod();
            this.label1 = new System.Windows.Forms.Label();
            this.profile_current_position_label = new System.Windows.Forms.Label();
            this.profile_current_user_label = new System.Windows.Forms.Label();
            this.edit_profile_button = new EEI_CRM.rounded_button();
            this.rounded_panel2 = new EEI_CRM.rounded_panel();
            this.exit_button1 = new EEI_CRM.exit_button();
            this.navbar1 = new EEI_CRM.navbar();
            this.label9 = new System.Windows.Forms.Label();
            this.rounded_panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // current_page_label
            // 
            this.current_page_label.AutoSize = true;
            this.current_page_label.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_page_label.Location = new System.Drawing.Point(334, 22);
            this.current_page_label.Name = "current_page_label";
            this.current_page_label.Size = new System.Drawing.Size(187, 32);
            this.current_page_label.TabIndex = 22;
            this.current_page_label.Text = "CURRENT_PAGE";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandTimeout = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // rounded_panel1
            // 
            this.rounded_panel1.BackColor = System.Drawing.Color.White;
            this.rounded_panel1.BackgroundColor = System.Drawing.Color.White;
            this.rounded_panel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rounded_panel1.BorderRadius = 20;
            this.rounded_panel1.BorderSize = 0;
            this.rounded_panel1.Controls.Add(this.label9);
            this.rounded_panel1.Controls.Add(this.panel8);
            this.rounded_panel1.Controls.Add(this.panel7);
            this.rounded_panel1.Controls.Add(this.panel6);
            this.rounded_panel1.Controls.Add(this.panel5);
            this.rounded_panel1.Controls.Add(this.panel4);
            this.rounded_panel1.Controls.Add(this.panel3);
            this.rounded_panel1.Controls.Add(this.panel2);
            this.rounded_panel1.Controls.Add(this.panel1);
            this.rounded_panel1.Controls.Add(this.profile_current_position_label);
            this.rounded_panel1.Controls.Add(this.profile_current_user_label);
            this.rounded_panel1.Controls.Add(this.edit_profile_button);
            this.rounded_panel1.Controls.Add(this.rounded_panel2);
            this.rounded_panel1.ForeColor = System.Drawing.Color.White;
            this.rounded_panel1.Location = new System.Drawing.Point(312, 97);
            this.rounded_panel1.Name = "rounded_panel1";
            this.rounded_panel1.Size = new System.Drawing.Size(950, 663);
            this.rounded_panel1.TabIndex = 2;
            this.rounded_panel1.TextColor = System.Drawing.Color.White;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.project_list_box);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(504, 392);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(369, 224);
            this.panel8.TabIndex = 32;
            // 
            // project_list_box
            // 
            this.project_list_box.BackColor = System.Drawing.Color.White;
            this.project_list_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.project_list_box.ForeColor = System.Drawing.Color.Gray;
            this.project_list_box.Location = new System.Drawing.Point(6, 33);
            this.project_list_box.Multiline = true;
            this.project_list_box.Name = "project_list_box";
            this.project_list_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.project_list_box.Size = new System.Drawing.Size(359, 188);
            this.project_list_box.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 33);
            this.label8.TabIndex = 0;
            this.label8.Text = "Projects";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.user_id_number_box);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(504, 312);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(369, 72);
            this.panel7.TabIndex = 31;
            // 
            // user_id_number_box
            // 
            this.user_id_number_box.BackColor = System.Drawing.Color.White;
            this.user_id_number_box.BorderColor = System.Drawing.Color.White;
            this.user_id_number_box.BorderSize = 2;
            this.user_id_number_box.Enabled = false;
            this.user_id_number_box.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_id_number_box.ForeColor = System.Drawing.Color.Gray;
            this.user_id_number_box.Location = new System.Drawing.Point(4, 37);
            this.user_id_number_box.Margin = new System.Windows.Forms.Padding(4);
            this.user_id_number_box.Multiline = false;
            this.user_id_number_box.Name = "user_id_number_box";
            this.user_id_number_box.OnFocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.user_id_number_box.OnFocusTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.user_id_number_box.Padding = new System.Windows.Forms.Padding(7);
            this.user_id_number_box.PasswordChar = false;
            this.user_id_number_box.Size = new System.Drawing.Size(361, 36);
            this.user_id_number_box.TabIndex = 1;
            this.user_id_number_box.Texts = "ID NUMBER";
            this.user_id_number_box.UnderLinedStyle = false;
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 33);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID Number";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.user_phone_number_box);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(504, 232);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(369, 72);
            this.panel6.TabIndex = 30;
            // 
            // user_phone_number_box
            // 
            this.user_phone_number_box.BackColor = System.Drawing.Color.White;
            this.user_phone_number_box.BorderColor = System.Drawing.Color.White;
            this.user_phone_number_box.BorderSize = 2;
            this.user_phone_number_box.Enabled = false;
            this.user_phone_number_box.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_phone_number_box.ForeColor = System.Drawing.Color.Gray;
            this.user_phone_number_box.Location = new System.Drawing.Point(4, 37);
            this.user_phone_number_box.Margin = new System.Windows.Forms.Padding(4);
            this.user_phone_number_box.Multiline = false;
            this.user_phone_number_box.Name = "user_phone_number_box";
            this.user_phone_number_box.OnFocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.user_phone_number_box.OnFocusTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.user_phone_number_box.Padding = new System.Windows.Forms.Padding(7);
            this.user_phone_number_box.PasswordChar = false;
            this.user_phone_number_box.Size = new System.Drawing.Size(361, 36);
            this.user_phone_number_box.TabIndex = 1;
            this.user_phone_number_box.Texts = "PHONE NUMBER";
            this.user_phone_number_box.UnderLinedStyle = false;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 33);
            this.label6.TabIndex = 0;
            this.label6.Text = "Phone Number";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.user_reporting_to_box);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(88, 544);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(369, 72);
            this.panel5.TabIndex = 29;
            // 
            // user_reporting_to_box
            // 
            this.user_reporting_to_box.BackColor = System.Drawing.Color.White;
            this.user_reporting_to_box.BorderColor = System.Drawing.Color.White;
            this.user_reporting_to_box.BorderSize = 2;
            this.user_reporting_to_box.Enabled = false;
            this.user_reporting_to_box.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_reporting_to_box.ForeColor = System.Drawing.Color.Gray;
            this.user_reporting_to_box.Location = new System.Drawing.Point(4, 37);
            this.user_reporting_to_box.Margin = new System.Windows.Forms.Padding(4);
            this.user_reporting_to_box.Multiline = false;
            this.user_reporting_to_box.Name = "user_reporting_to_box";
            this.user_reporting_to_box.OnFocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.user_reporting_to_box.OnFocusTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.user_reporting_to_box.Padding = new System.Windows.Forms.Padding(7);
            this.user_reporting_to_box.PasswordChar = false;
            this.user_reporting_to_box.Size = new System.Drawing.Size(361, 36);
            this.user_reporting_to_box.TabIndex = 1;
            this.user_reporting_to_box.Texts = "REPORTING TO";
            this.user_reporting_to_box.UnderLinedStyle = false;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 33);
            this.label5.TabIndex = 0;
            this.label5.Text = "Reporting To";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.user_position_box);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(88, 466);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(369, 72);
            this.panel4.TabIndex = 28;
            // 
            // user_position_box
            // 
            this.user_position_box.BackColor = System.Drawing.Color.White;
            this.user_position_box.BorderColor = System.Drawing.Color.White;
            this.user_position_box.BorderSize = 2;
            this.user_position_box.Enabled = false;
            this.user_position_box.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_position_box.ForeColor = System.Drawing.Color.Gray;
            this.user_position_box.Location = new System.Drawing.Point(4, 37);
            this.user_position_box.Margin = new System.Windows.Forms.Padding(4);
            this.user_position_box.Multiline = false;
            this.user_position_box.Name = "user_position_box";
            this.user_position_box.OnFocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.user_position_box.OnFocusTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.user_position_box.Padding = new System.Windows.Forms.Padding(7);
            this.user_position_box.PasswordChar = false;
            this.user_position_box.Size = new System.Drawing.Size(361, 36);
            this.user_position_box.TabIndex = 1;
            this.user_position_box.Texts = "POSITION";
            this.user_position_box.UnderLinedStyle = false;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Position";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.user_department_box);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(88, 388);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(369, 72);
            this.panel3.TabIndex = 28;
            // 
            // user_department_box
            // 
            this.user_department_box.BackColor = System.Drawing.Color.White;
            this.user_department_box.BorderColor = System.Drawing.Color.White;
            this.user_department_box.BorderSize = 2;
            this.user_department_box.Enabled = false;
            this.user_department_box.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_department_box.ForeColor = System.Drawing.Color.Gray;
            this.user_department_box.Location = new System.Drawing.Point(4, 37);
            this.user_department_box.Margin = new System.Windows.Forms.Padding(4);
            this.user_department_box.Multiline = false;
            this.user_department_box.Name = "user_department_box";
            this.user_department_box.OnFocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.user_department_box.OnFocusTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.user_department_box.Padding = new System.Windows.Forms.Padding(7);
            this.user_department_box.PasswordChar = false;
            this.user_department_box.Size = new System.Drawing.Size(361, 36);
            this.user_department_box.TabIndex = 1;
            this.user_department_box.Texts = "DEPARTMENT";
            this.user_department_box.UnderLinedStyle = false;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Department";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.user_email_box);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(88, 310);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 72);
            this.panel2.TabIndex = 28;
            // 
            // user_email_box
            // 
            this.user_email_box.BackColor = System.Drawing.Color.White;
            this.user_email_box.BorderColor = System.Drawing.Color.White;
            this.user_email_box.BorderSize = 2;
            this.user_email_box.Enabled = false;
            this.user_email_box.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_email_box.ForeColor = System.Drawing.Color.Gray;
            this.user_email_box.Location = new System.Drawing.Point(4, 37);
            this.user_email_box.Margin = new System.Windows.Forms.Padding(4);
            this.user_email_box.Multiline = false;
            this.user_email_box.Name = "user_email_box";
            this.user_email_box.OnFocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.user_email_box.OnFocusTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.user_email_box.Padding = new System.Windows.Forms.Padding(7);
            this.user_email_box.PasswordChar = false;
            this.user_email_box.Size = new System.Drawing.Size(361, 36);
            this.user_email_box.TabIndex = 1;
            this.user_email_box.Texts = "EMAIL ";
            this.user_email_box.UnderLinedStyle = false;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.user_name_box);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(88, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 72);
            this.panel1.TabIndex = 27;
            // 
            // user_name_box
            // 
            this.user_name_box.BackColor = System.Drawing.Color.White;
            this.user_name_box.BorderColor = System.Drawing.Color.White;
            this.user_name_box.BorderSize = 2;
            this.user_name_box.Enabled = false;
            this.user_name_box.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name_box.ForeColor = System.Drawing.Color.Gray;
            this.user_name_box.Location = new System.Drawing.Point(4, 37);
            this.user_name_box.Margin = new System.Windows.Forms.Padding(4);
            this.user_name_box.Multiline = false;
            this.user_name_box.Name = "user_name_box";
            this.user_name_box.OnFocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.user_name_box.OnFocusTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.user_name_box.Padding = new System.Windows.Forms.Padding(7);
            this.user_name_box.PasswordChar = false;
            this.user_name_box.Size = new System.Drawing.Size(361, 36);
            this.user_name_box.TabIndex = 1;
            this.user_name_box.Texts = "FULL NAME";
            this.user_name_box.UnderLinedStyle = false;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // profile_current_position_label
            // 
            this.profile_current_position_label.AutoSize = true;
            this.profile_current_position_label.BackColor = System.Drawing.Color.Transparent;
            this.profile_current_position_label.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_current_position_label.ForeColor = System.Drawing.Color.Black;
            this.profile_current_position_label.Location = new System.Drawing.Point(256, 119);
            this.profile_current_position_label.Name = "profile_current_position_label";
            this.profile_current_position_label.Size = new System.Drawing.Size(201, 30);
            this.profile_current_position_label.TabIndex = 26;
            this.profile_current_position_label.Text = "CURRENT_POSITION";
            // 
            // profile_current_user_label
            // 
            this.profile_current_user_label.AutoSize = true;
            this.profile_current_user_label.BackColor = System.Drawing.Color.Transparent;
            this.profile_current_user_label.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_current_user_label.ForeColor = System.Drawing.Color.Black;
            this.profile_current_user_label.Location = new System.Drawing.Point(255, 87);
            this.profile_current_user_label.Name = "profile_current_user_label";
            this.profile_current_user_label.Size = new System.Drawing.Size(186, 32);
            this.profile_current_user_label.TabIndex = 25;
            this.profile_current_user_label.Text = "CURRENT_USER";
            // 
            // edit_profile_button
            // 
            this.edit_profile_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.edit_profile_button.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.edit_profile_button.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.edit_profile_button.BorderRadius = 15;
            this.edit_profile_button.BorderSize = 0;
            this.edit_profile_button.FlatAppearance.BorderSize = 0;
            this.edit_profile_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_profile_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_profile_button.ForeColor = System.Drawing.Color.White;
            this.edit_profile_button.Location = new System.Drawing.Point(774, 20);
            this.edit_profile_button.Name = "edit_profile_button";
            this.edit_profile_button.Size = new System.Drawing.Size(150, 40);
            this.edit_profile_button.TabIndex = 24;
            this.edit_profile_button.Text = "EDIT PROFILE";
            this.edit_profile_button.TextColor = System.Drawing.Color.White;
            this.edit_profile_button.UseVisualStyleBackColor = false;
            this.edit_profile_button.Click += new System.EventHandler(this.edit_profile_button_Click);
            // 
            // rounded_panel2
            // 
            this.rounded_panel2.BackColor = System.Drawing.Color.Transparent;
            this.rounded_panel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.rounded_panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rounded_panel2.BackgroundImage")));
            this.rounded_panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rounded_panel2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rounded_panel2.BorderRadius = 60;
            this.rounded_panel2.BorderSize = 0;
            this.rounded_panel2.ForeColor = System.Drawing.Color.White;
            this.rounded_panel2.Location = new System.Drawing.Point(71, 61);
            this.rounded_panel2.Name = "rounded_panel2";
            this.rounded_panel2.Size = new System.Drawing.Size(138, 131);
            this.rounded_panel2.TabIndex = 23;
            this.rounded_panel2.TextColor = System.Drawing.Color.White;
            // 
            // exit_button1
            // 
            this.exit_button1.BackColor = System.Drawing.Color.Transparent;
            this.exit_button1.Location = new System.Drawing.Point(1250, 0);
            this.exit_button1.Name = "exit_button1";
            this.exit_button1.Size = new System.Drawing.Size(30, 30);
            this.exit_button1.TabIndex = 1;
            // 
            // navbar1
            // 
            this.navbar1.Location = new System.Drawing.Point(0, 0);
            this.navbar1.Name = "navbar1";
            this.navbar1.Size = new System.Drawing.Size(292, 800);
            this.navbar1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label9.Location = new System.Drawing.Point(258, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 23);
            this.label9.TabIndex = 33;
            this.label9.Text = "XXXX-XX-XX TO XXXX-XX-XX";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // user_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.current_page_label);
            this.Controls.Add(this.rounded_panel1);
            this.Controls.Add(this.exit_button1);
            this.Controls.Add(this.navbar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "user_profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EPC CRM";
            this.Load += new System.EventHandler(this.user_profile_Load);
            this.rounded_panel1.ResumeLayout(false);
            this.rounded_panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private navbar navbar1;
        private exit_button exit_button1;
        private rounded_panel rounded_panel1;
        private System.Windows.Forms.Label current_page_label;
        private rounded_panel rounded_panel2;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private rounded_button edit_profile_button;
        private System.Windows.Forms.Label profile_current_position_label;
        private System.Windows.Forms.Label profile_current_user_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private text_box_mod user_name_box;
        private System.Windows.Forms.Panel panel4;
        private text_box_mod user_position_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private text_box_mod user_department_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private text_box_mod user_email_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private text_box_mod user_reporting_to_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private text_box_mod user_phone_number_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private text_box_mod user_id_number_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox project_list_box;
        private System.Windows.Forms.Label label9;
    }
}