namespace EEI_CRM
{
    partial class index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.panel10 = new System.Windows.Forms.Panel();
            this.current_position_label = new System.Windows.Forms.Label();
            this.current_user_label = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.index_current_page_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dash_project_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.notification_panel = new EEI_CRM.rounded_panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.notif_acknowledge_button = new EEI_CRM.rounded_button();
            this.notification_new_tasks_panel = new EEI_CRM.text_box_mod();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.notification_new_project_box = new EEI_CRM.text_box_mod();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.unverified_count = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Notification = new System.Windows.Forms.Label();
            this.navbar1 = new EEI_CRM.navbar();
            this.notification_bell_button = new EEI_CRM.rounded_button();
            this.exit_button1 = new EEI_CRM.exit_button();
            this.index_char_panel = new EEI_CRM.rounded_panel();
            this.label13 = new System.Windows.Forms.Label();
            this.index_project_name_label2 = new System.Windows.Forms.Label();
            this.MW_Chart_percent = new System.Windows.Forms.Label();
            this.CSA_Chart_percent = new System.Windows.Forms.Label();
            this.EW_Chart_percent = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mechanical_work_progress_bar = new EEI_CRM.custom_progress_bar();
            this.csa_work_progress_bar = new EEI_CRM.custom_progress_bar();
            this.elec_work_progress_bar = new EEI_CRM.custom_progress_bar();
            this.rounded_panel4 = new EEI_CRM.rounded_panel();
            this.search_bar_box = new EEI_CRM.combo_box();
            this.dash_project_panel = new EEI_CRM.rounded_panel();
            this.label9 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.activity_history_panel = new EEI_CRM.rounded_panel();
            this.label12 = new System.Windows.Forms.Label();
            this.index_project_name_label1 = new System.Windows.Forms.Label();
            this.dashboard_project_panel_button = new EEI_CRM.rounded_panel();
            this.index_activity_log = new EEI_CRM.text_box_mod();
            this.rounded_button2 = new EEI_CRM.rounded_button();
            this.text_box_mod1 = new EEI_CRM.text_box_mod();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.notification_panel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.index_char_panel.SuspendLayout();
            this.rounded_panel4.SuspendLayout();
            this.dash_project_panel.SuspendLayout();
            this.activity_history_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.Controls.Add(this.current_position_label);
            this.panel10.Controls.Add(this.current_user_label);
            this.panel10.Controls.Add(this.pictureBox3);
            this.panel10.Location = new System.Drawing.Point(942, 12);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(291, 60);
            this.panel10.TabIndex = 13;
            // 
            // current_position_label
            // 
            this.current_position_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.current_position_label.BackColor = System.Drawing.Color.Transparent;
            this.current_position_label.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_position_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.current_position_label.Location = new System.Drawing.Point(4, 34);
            this.current_position_label.Name = "current_position_label";
            this.current_position_label.Size = new System.Drawing.Size(247, 15);
            this.current_position_label.TabIndex = 12;
            this.current_position_label.Text = "position";
            this.current_position_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // current_user_label
            // 
            this.current_user_label.BackColor = System.Drawing.Color.Transparent;
            this.current_user_label.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_user_label.ForeColor = System.Drawing.Color.Black;
            this.current_user_label.Location = new System.Drawing.Point(3, 7);
            this.current_user_label.Name = "current_user_label";
            this.current_user_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.current_user_label.Size = new System.Drawing.Size(247, 21);
            this.current_user_label.TabIndex = 11;
            this.current_user_label.Text = "user";
            this.current_user_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(258, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // index_current_page_label
            // 
            this.index_current_page_label.AutoSize = true;
            this.index_current_page_label.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.index_current_page_label.Location = new System.Drawing.Point(310, 28);
            this.index_current_page_label.Name = "index_current_page_label";
            this.index_current_page_label.Size = new System.Drawing.Size(187, 32);
            this.index_current_page_label.TabIndex = 21;
            this.index_current_page_label.Text = "CURRENT_PAGE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "List of Projects";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(350, 20);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(15, 15);
            this.pictureBox6.TabIndex = 23;
            this.pictureBox6.TabStop = false;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandTimeout = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 38);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(399, 587);
            this.flowLayoutPanel1.TabIndex = 36;
            // 
            // dash_project_label
            // 
            this.dash_project_label.AutoSize = true;
            this.dash_project_label.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash_project_label.Location = new System.Drawing.Point(10, 10);
            this.dash_project_label.Name = "dash_project_label";
            this.dash_project_label.Size = new System.Drawing.Size(99, 25);
            this.dash_project_label.TabIndex = 24;
            this.dash_project_label.Text = "PROJECTS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Project";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label4.Location = new System.Drawing.Point(12, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "Chart";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Project";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label6.Location = new System.Drawing.Point(11, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Activity History";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.progressBar1.Location = new System.Drawing.Point(109, 179);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(251, 41);
            this.progressBar1.TabIndex = 27;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // notification_panel
            // 
            this.notification_panel.BackColor = System.Drawing.Color.White;
            this.notification_panel.BackgroundColor = System.Drawing.Color.White;
            this.notification_panel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.notification_panel.BorderRadius = 10;
            this.notification_panel.BorderSize = 0;
            this.notification_panel.Controls.Add(this.panel3);
            this.notification_panel.Controls.Add(this.panel2);
            this.notification_panel.Controls.Add(this.panel1);
            this.notification_panel.Controls.Add(this.Notification);
            this.notification_panel.ForeColor = System.Drawing.Color.Black;
            this.notification_panel.Location = new System.Drawing.Point(747, 94);
            this.notification_panel.Name = "notification_panel";
            this.notification_panel.Size = new System.Drawing.Size(485, 339);
            this.notification_panel.TabIndex = 38;
            this.notification_panel.TextColor = System.Drawing.Color.Black;
            this.notification_panel.Visible = false;
            this.notification_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.notification_panel_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.notif_acknowledge_button);
            this.panel3.Controls.Add(this.notification_new_tasks_panel);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(250, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 238);
            this.panel3.TabIndex = 39;
            // 
            // notif_acknowledge_button
            // 
            this.notif_acknowledge_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.notif_acknowledge_button.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.notif_acknowledge_button.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.notif_acknowledge_button.BorderRadius = 5;
            this.notif_acknowledge_button.BorderSize = 0;
            this.notif_acknowledge_button.FlatAppearance.BorderSize = 0;
            this.notif_acknowledge_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notif_acknowledge_button.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notif_acknowledge_button.ForeColor = System.Drawing.Color.White;
            this.notif_acknowledge_button.Location = new System.Drawing.Point(118, 3);
            this.notif_acknowledge_button.Name = "notif_acknowledge_button";
            this.notif_acknowledge_button.Size = new System.Drawing.Size(99, 24);
            this.notif_acknowledge_button.TabIndex = 6;
            this.notif_acknowledge_button.Text = "Acknowledge";
            this.notif_acknowledge_button.TextColor = System.Drawing.Color.White;
            this.notif_acknowledge_button.UseVisualStyleBackColor = false;
            this.notif_acknowledge_button.Click += new System.EventHandler(this.notif_acknowledge_button_Click);
            // 
            // notification_new_tasks_panel
            // 
            this.notification_new_tasks_panel.BackColor = System.Drawing.Color.White;
            this.notification_new_tasks_panel.BorderColor = System.Drawing.Color.White;
            this.notification_new_tasks_panel.BorderSize = 2;
            this.notification_new_tasks_panel.Enabled = false;
            this.notification_new_tasks_panel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notification_new_tasks_panel.ForeColor = System.Drawing.Color.Gray;
            this.notification_new_tasks_panel.Location = new System.Drawing.Point(4, 35);
            this.notification_new_tasks_panel.Margin = new System.Windows.Forms.Padding(4);
            this.notification_new_tasks_panel.Multiline = true;
            this.notification_new_tasks_panel.Name = "notification_new_tasks_panel";
            this.notification_new_tasks_panel.OnFocusBorderColor = System.Drawing.Color.White;
            this.notification_new_tasks_panel.OnFocusTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.notification_new_tasks_panel.Padding = new System.Windows.Forms.Padding(7);
            this.notification_new_tasks_panel.PasswordChar = false;
            this.notification_new_tasks_panel.Size = new System.Drawing.Size(214, 198);
            this.notification_new_tasks_panel.TabIndex = 5;
            this.notification_new_tasks_panel.Texts = "";
            this.notification_new_tasks_panel.UnderLinedStyle = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.panel5.Location = new System.Drawing.Point(2, 28);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(218, 2);
            this.panel5.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label15.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 31);
            this.label15.TabIndex = 3;
            this.label15.Text = "New Tasks : ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.notification_new_project_box);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(9, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 238);
            this.panel2.TabIndex = 38;
            // 
            // notification_new_project_box
            // 
            this.notification_new_project_box.BackColor = System.Drawing.Color.White;
            this.notification_new_project_box.BorderColor = System.Drawing.Color.White;
            this.notification_new_project_box.BorderSize = 2;
            this.notification_new_project_box.Enabled = false;
            this.notification_new_project_box.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notification_new_project_box.ForeColor = System.Drawing.Color.Gray;
            this.notification_new_project_box.Location = new System.Drawing.Point(6, 36);
            this.notification_new_project_box.Margin = new System.Windows.Forms.Padding(4);
            this.notification_new_project_box.Multiline = true;
            this.notification_new_project_box.Name = "notification_new_project_box";
            this.notification_new_project_box.OnFocusBorderColor = System.Drawing.Color.White;
            this.notification_new_project_box.OnFocusTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.notification_new_project_box.Padding = new System.Windows.Forms.Padding(7);
            this.notification_new_project_box.PasswordChar = false;
            this.notification_new_project_box.Size = new System.Drawing.Size(214, 198);
            this.notification_new_project_box.TabIndex = 4;
            this.notification_new_project_box.Texts = "";
            this.notification_new_project_box.UnderLinedStyle = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.panel4.Location = new System.Drawing.Point(3, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(218, 2);
            this.panel4.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label14.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label14.Location = new System.Drawing.Point(3, 1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(218, 31);
            this.label14.TabIndex = 2;
            this.label14.Text = "New Projects : ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.unverified_count);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(9, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 37);
            this.panel1.TabIndex = 37;
            // 
            // unverified_count
            // 
            this.unverified_count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.unverified_count.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.unverified_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.unverified_count.Location = new System.Drawing.Point(219, 7);
            this.unverified_count.Name = "unverified_count";
            this.unverified_count.Size = new System.Drawing.Size(242, 25);
            this.unverified_count.TabIndex = 1;
            this.unverified_count.Text = "label11";
            this.unverified_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label10.Location = new System.Drawing.Point(3, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Number of Unverified Users: ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Notification
            // 
            this.Notification.AutoSize = true;
            this.Notification.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notification.Location = new System.Drawing.Point(10, 10);
            this.Notification.Name = "Notification";
            this.Notification.Size = new System.Drawing.Size(114, 25);
            this.Notification.TabIndex = 36;
            this.Notification.Text = "Notification";
            // 
            // navbar1
            // 
            this.navbar1.Location = new System.Drawing.Point(0, 0);
            this.navbar1.Name = "navbar1";
            this.navbar1.Size = new System.Drawing.Size(292, 800);
            this.navbar1.TabIndex = 34;
            // 
            // notification_bell_button
            // 
            this.notification_bell_button.BackColor = System.Drawing.Color.OrangeRed;
            this.notification_bell_button.BackgroundColor = System.Drawing.Color.OrangeRed;
            this.notification_bell_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("notification_bell_button.BackgroundImage")));
            this.notification_bell_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.notification_bell_button.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.notification_bell_button.BorderRadius = 10;
            this.notification_bell_button.BorderSize = 0;
            this.notification_bell_button.FlatAppearance.BorderSize = 0;
            this.notification_bell_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notification_bell_button.ForeColor = System.Drawing.Color.White;
            this.notification_bell_button.Location = new System.Drawing.Point(907, 28);
            this.notification_bell_button.Name = "notification_bell_button";
            this.notification_bell_button.Size = new System.Drawing.Size(33, 29);
            this.notification_bell_button.TabIndex = 30;
            this.notification_bell_button.TextColor = System.Drawing.Color.White;
            this.notification_bell_button.UseVisualStyleBackColor = false;
            this.notification_bell_button.Click += new System.EventHandler(this.notification_bell_button_Click);
            // 
            // exit_button1
            // 
            this.exit_button1.BackColor = System.Drawing.Color.Transparent;
            this.exit_button1.Location = new System.Drawing.Point(1250, 0);
            this.exit_button1.Name = "exit_button1";
            this.exit_button1.Size = new System.Drawing.Size(30, 30);
            this.exit_button1.TabIndex = 29;
            // 
            // index_char_panel
            // 
            this.index_char_panel.BackColor = System.Drawing.Color.White;
            this.index_char_panel.BackgroundColor = System.Drawing.Color.White;
            this.index_char_panel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.index_char_panel.BorderRadius = 10;
            this.index_char_panel.BorderSize = 0;
            this.index_char_panel.Controls.Add(this.label13);
            this.index_char_panel.Controls.Add(this.index_project_name_label2);
            this.index_char_panel.Controls.Add(this.MW_Chart_percent);
            this.index_char_panel.Controls.Add(this.CSA_Chart_percent);
            this.index_char_panel.Controls.Add(this.EW_Chart_percent);
            this.index_char_panel.Controls.Add(this.label8);
            this.index_char_panel.Controls.Add(this.label3);
            this.index_char_panel.Controls.Add(this.label1);
            this.index_char_panel.Controls.Add(this.mechanical_work_progress_bar);
            this.index_char_panel.Controls.Add(this.csa_work_progress_bar);
            this.index_char_panel.Controls.Add(this.elec_work_progress_bar);
            this.index_char_panel.ForeColor = System.Drawing.Color.Black;
            this.index_char_panel.Location = new System.Drawing.Point(746, 453);
            this.index_char_panel.Name = "index_char_panel";
            this.index_char_panel.Size = new System.Drawing.Size(485, 285);
            this.index_char_panel.TabIndex = 26;
            this.index_char_panel.TextColor = System.Drawing.Color.Black;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 17);
            this.label13.TabIndex = 38;
            this.label13.Text = "Chart";
            // 
            // index_project_name_label2
            // 
            this.index_project_name_label2.AutoSize = true;
            this.index_project_name_label2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.index_project_name_label2.Location = new System.Drawing.Point(10, 10);
            this.index_project_name_label2.Name = "index_project_name_label2";
            this.index_project_name_label2.Size = new System.Drawing.Size(140, 25);
            this.index_project_name_label2.TabIndex = 37;
            this.index_project_name_label2.Text = "Choose Project";
            // 
            // MW_Chart_percent
            // 
            this.MW_Chart_percent.AutoSize = true;
            this.MW_Chart_percent.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MW_Chart_percent.Location = new System.Drawing.Point(409, 230);
            this.MW_Chart_percent.Name = "MW_Chart_percent";
            this.MW_Chart_percent.Size = new System.Drawing.Size(29, 20);
            this.MW_Chart_percent.TabIndex = 9;
            this.MW_Chart_percent.Text = "0%";
            // 
            // CSA_Chart_percent
            // 
            this.CSA_Chart_percent.AutoSize = true;
            this.CSA_Chart_percent.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSA_Chart_percent.Location = new System.Drawing.Point(409, 158);
            this.CSA_Chart_percent.Name = "CSA_Chart_percent";
            this.CSA_Chart_percent.Size = new System.Drawing.Size(29, 20);
            this.CSA_Chart_percent.TabIndex = 8;
            this.CSA_Chart_percent.Text = "0%";
            // 
            // EW_Chart_percent
            // 
            this.EW_Chart_percent.AutoSize = true;
            this.EW_Chart_percent.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EW_Chart_percent.Location = new System.Drawing.Point(409, 88);
            this.EW_Chart_percent.Name = "EW_Chart_percent";
            this.EW_Chart_percent.Size = new System.Drawing.Size(29, 20);
            this.EW_Chart_percent.TabIndex = 7;
            this.EW_Chart_percent.Text = "0%";
            this.EW_Chart_percent.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Mechanical Works";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Civil, Structural and Architectural Works";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Electrical Works";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mechanical_work_progress_bar
            // 
            this.mechanical_work_progress_bar.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.mechanical_work_progress_bar.BoxBackgroundColor = System.Drawing.Color.White;
            this.mechanical_work_progress_bar.BoxBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.mechanical_work_progress_bar.BoxBorderSize = 2;
            this.mechanical_work_progress_bar.BoxHeight = 30;
            this.mechanical_work_progress_bar.BoxWidth = 365;
            this.mechanical_work_progress_bar.Location = new System.Drawing.Point(39, 226);
            this.mechanical_work_progress_bar.Max_Val = 100;
            this.mechanical_work_progress_bar.Min_Val = 0;
            this.mechanical_work_progress_bar.Name = "mechanical_work_progress_bar";
            this.mechanical_work_progress_bar.Size = new System.Drawing.Size(365, 30);
            this.mechanical_work_progress_bar.TabIndex = 3;
            this.mechanical_work_progress_bar.Value = 0;
            // 
            // csa_work_progress_bar
            // 
            this.csa_work_progress_bar.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.csa_work_progress_bar.BoxBackgroundColor = System.Drawing.Color.White;
            this.csa_work_progress_bar.BoxBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.csa_work_progress_bar.BoxBorderSize = 2;
            this.csa_work_progress_bar.BoxHeight = 30;
            this.csa_work_progress_bar.BoxWidth = 365;
            this.csa_work_progress_bar.Location = new System.Drawing.Point(39, 154);
            this.csa_work_progress_bar.Max_Val = 100;
            this.csa_work_progress_bar.Min_Val = 0;
            this.csa_work_progress_bar.Name = "csa_work_progress_bar";
            this.csa_work_progress_bar.Size = new System.Drawing.Size(365, 30);
            this.csa_work_progress_bar.TabIndex = 2;
            this.csa_work_progress_bar.Value = 0;
            // 
            // elec_work_progress_bar
            // 
            this.elec_work_progress_bar.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.elec_work_progress_bar.BoxBackgroundColor = System.Drawing.Color.White;
            this.elec_work_progress_bar.BoxBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.elec_work_progress_bar.BoxBorderSize = 2;
            this.elec_work_progress_bar.BoxHeight = 30;
            this.elec_work_progress_bar.BoxWidth = 365;
            this.elec_work_progress_bar.Location = new System.Drawing.Point(39, 83);
            this.elec_work_progress_bar.Max_Val = 100;
            this.elec_work_progress_bar.Min_Val = 0;
            this.elec_work_progress_bar.Name = "elec_work_progress_bar";
            this.elec_work_progress_bar.Size = new System.Drawing.Size(365, 30);
            this.elec_work_progress_bar.TabIndex = 1;
            this.elec_work_progress_bar.Value = 0;
            // 
            // rounded_panel4
            // 
            this.rounded_panel4.BackColor = System.Drawing.Color.White;
            this.rounded_panel4.BackgroundColor = System.Drawing.Color.White;
            this.rounded_panel4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rounded_panel4.BorderRadius = 10;
            this.rounded_panel4.BorderSize = 0;
            this.rounded_panel4.Controls.Add(this.search_bar_box);
            this.rounded_panel4.ForeColor = System.Drawing.Color.White;
            this.rounded_panel4.Location = new System.Drawing.Point(544, 16);
            this.rounded_panel4.Name = "rounded_panel4";
            this.rounded_panel4.Size = new System.Drawing.Size(357, 53);
            this.rounded_panel4.TabIndex = 33;
            this.rounded_panel4.TextColor = System.Drawing.Color.White;
            // 
            // search_bar_box
            // 
            this.search_bar_box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.search_bar_box.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.search_bar_box.BackColor = System.Drawing.Color.White;
            this.search_bar_box.BorderColor = System.Drawing.Color.White;
            this.search_bar_box.BorderSize = 1;
            this.search_bar_box.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.search_bar_box.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_bar_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.search_bar_box.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.search_bar_box.ListBackColor = System.Drawing.Color.White;
            this.search_bar_box.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.search_bar_box.Location = new System.Drawing.Point(3, 4);
            this.search_bar_box.MinimumSize = new System.Drawing.Size(200, 30);
            this.search_bar_box.Name = "search_bar_box";
            this.search_bar_box.Padding = new System.Windows.Forms.Padding(1);
            this.search_bar_box.Size = new System.Drawing.Size(349, 46);
            this.search_bar_box.TabIndex = 0;
            this.search_bar_box.Texts = "Search for client of project";
            this.search_bar_box.UnderLineState = false;
            this.search_bar_box.OnSelectedIndexChanged += new System.EventHandler(this.search_bar_box_OnSelectedIndexChanged);
            // 
            // dash_project_panel
            // 
            this.dash_project_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dash_project_panel.AutoScroll = true;
            this.dash_project_panel.AutoScrollMinSize = new System.Drawing.Size(405, 645);
            this.dash_project_panel.AutoSize = true;
            this.dash_project_panel.BackColor = System.Drawing.Color.White;
            this.dash_project_panel.BackgroundColor = System.Drawing.Color.White;
            this.dash_project_panel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dash_project_panel.BorderRadius = 10;
            this.dash_project_panel.BorderSize = 0;
            this.dash_project_panel.Controls.Add(this.label9);
            this.dash_project_panel.Controls.Add(this.flowLayoutPanel2);
            this.dash_project_panel.ForeColor = System.Drawing.Color.Black;
            this.dash_project_panel.Location = new System.Drawing.Point(316, 93);
            this.dash_project_panel.Name = "dash_project_panel";
            this.dash_project_panel.Size = new System.Drawing.Size(424, 645);
            this.dash_project_panel.TabIndex = 26;
            this.dash_project_panel.TextColor = System.Drawing.Color.Black;
            this.dash_project_panel.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dash_project_panel_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 25);
            this.label9.TabIndex = 35;
            this.label9.Text = "Projects";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(17, 48);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(394, 585);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // activity_history_panel
            // 
            this.activity_history_panel.BackColor = System.Drawing.Color.White;
            this.activity_history_panel.BackgroundColor = System.Drawing.Color.White;
            this.activity_history_panel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.activity_history_panel.BorderRadius = 10;
            this.activity_history_panel.BorderSize = 0;
            this.activity_history_panel.Controls.Add(this.label12);
            this.activity_history_panel.Controls.Add(this.index_project_name_label1);
            this.activity_history_panel.ForeColor = System.Drawing.Color.Black;
            this.activity_history_panel.Location = new System.Drawing.Point(747, 94);
            this.activity_history_panel.Name = "activity_history_panel";
            this.activity_history_panel.Size = new System.Drawing.Size(485, 339);
            this.activity_history_panel.TabIndex = 25;
            this.activity_history_panel.TextColor = System.Drawing.Color.Black;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 17);
            this.label12.TabIndex = 37;
            this.label12.Text = "Activity History";
            // 
            // index_project_name_label1
            // 
            this.index_project_name_label1.AutoSize = true;
            this.index_project_name_label1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.index_project_name_label1.Location = new System.Drawing.Point(10, 10);
            this.index_project_name_label1.Name = "index_project_name_label1";
            this.index_project_name_label1.Size = new System.Drawing.Size(140, 25);
            this.index_project_name_label1.TabIndex = 36;
            this.index_project_name_label1.Text = "Choose Project";
            // 
            // dashboard_project_panel_button
            // 
            this.dashboard_project_panel_button.BackColor = System.Drawing.Color.Transparent;
            this.dashboard_project_panel_button.BackgroundColor = System.Drawing.Color.Transparent;
            this.dashboard_project_panel_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dashboard_project_panel_button.BackgroundImage")));
            this.dashboard_project_panel_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dashboard_project_panel_button.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dashboard_project_panel_button.BorderRadius = 10;
            this.dashboard_project_panel_button.BorderSize = 0;
            this.dashboard_project_panel_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard_project_panel_button.ForeColor = System.Drawing.Color.White;
            this.dashboard_project_panel_button.Location = new System.Drawing.Point(392, 10);
            this.dashboard_project_panel_button.Name = "dashboard_project_panel_button";
            this.dashboard_project_panel_button.Size = new System.Drawing.Size(22, 19);
            this.dashboard_project_panel_button.TabIndex = 35;
            this.dashboard_project_panel_button.TextColor = System.Drawing.Color.White;
            this.dashboard_project_panel_button.Click += new System.EventHandler(this.dashboard_projects_panel_button_Click);
            this.dashboard_project_panel_button.MouseEnter += new System.EventHandler(this.dashboard_project_panel_button_MouseEnter);
            this.dashboard_project_panel_button.MouseLeave += new System.EventHandler(this.dashboard_project_panel_button_MouseLeave);
            // 
            // index_activity_log
            // 
            this.index_activity_log.BackColor = System.Drawing.SystemColors.Window;
            this.index_activity_log.BorderColor = System.Drawing.Color.White;
            this.index_activity_log.BorderSize = 0;
            this.index_activity_log.Enabled = false;
            this.index_activity_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.index_activity_log.ForeColor = System.Drawing.Color.DimGray;
            this.index_activity_log.Location = new System.Drawing.Point(15, 60);
            this.index_activity_log.Margin = new System.Windows.Forms.Padding(4);
            this.index_activity_log.Multiline = true;
            this.index_activity_log.Name = "index_activity_log";
            this.index_activity_log.OnFocusBorderColor = System.Drawing.Color.DarkGray;
            this.index_activity_log.OnFocusTextColor = System.Drawing.Color.Navy;
            this.index_activity_log.Padding = new System.Windows.Forms.Padding(7);
            this.index_activity_log.PasswordChar = false;
            this.index_activity_log.Size = new System.Drawing.Size(457, 261);
            this.index_activity_log.TabIndex = 26;
            this.index_activity_log.Texts = "";
            this.index_activity_log.UnderLinedStyle = false;
            // 
            // rounded_button2
            // 
            this.rounded_button2.BackColor = System.Drawing.Color.Transparent;
            this.rounded_button2.BackgroundColor = System.Drawing.Color.Transparent;
            this.rounded_button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rounded_button2.BackgroundImage")));
            this.rounded_button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rounded_button2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rounded_button2.BorderRadius = 20;
            this.rounded_button2.BorderSize = 0;
            this.rounded_button2.FlatAppearance.BorderSize = 0;
            this.rounded_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rounded_button2.ForeColor = System.Drawing.Color.White;
            this.rounded_button2.Location = new System.Drawing.Point(311, 10);
            this.rounded_button2.Name = "rounded_button2";
            this.rounded_button2.Size = new System.Drawing.Size(33, 29);
            this.rounded_button2.TabIndex = 32;
            this.rounded_button2.TextColor = System.Drawing.Color.White;
            this.rounded_button2.UseVisualStyleBackColor = false;
            // 
            // text_box_mod1
            // 
            this.text_box_mod1.BackColor = System.Drawing.Color.White;
            this.text_box_mod1.BorderColor = System.Drawing.Color.White;
            this.text_box_mod1.BorderSize = 1;
            this.text_box_mod1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_box_mod1.ForeColor = System.Drawing.Color.DimGray;
            this.text_box_mod1.Location = new System.Drawing.Point(-68, 50);
            this.text_box_mod1.Margin = new System.Windows.Forms.Padding(4);
            this.text_box_mod1.Multiline = false;
            this.text_box_mod1.Name = "text_box_mod1";
            this.text_box_mod1.OnFocusBorderColor = System.Drawing.Color.White;
            this.text_box_mod1.OnFocusTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.text_box_mod1.Padding = new System.Windows.Forms.Padding(7);
            this.text_box_mod1.PasswordChar = false;
            this.text_box_mod1.Size = new System.Drawing.Size(282, 31);
            this.text_box_mod1.TabIndex = 31;
            this.text_box_mod1.Texts = "";
            this.text_box_mod1.UnderLinedStyle = false;
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.notification_panel);
            this.Controls.Add(this.navbar1);
            this.Controls.Add(this.notification_bell_button);
            this.Controls.Add(this.exit_button1);
            this.Controls.Add(this.index_char_panel);
            this.Controls.Add(this.index_current_page_label);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.rounded_panel4);
            this.Controls.Add(this.dash_project_panel);
            this.Controls.Add(this.activity_history_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 800);
            this.MinimizeBox = false;
            this.Name = "index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "2";
            this.Load += new System.EventHandler(this.index_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.index_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.index_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.index_MouseUp);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.notification_panel.ResumeLayout(false);
            this.notification_panel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.index_char_panel.ResumeLayout(false);
            this.index_char_panel.PerformLayout();
            this.rounded_panel4.ResumeLayout(false);
            this.dash_project_panel.ResumeLayout(false);
            this.dash_project_panel.PerformLayout();
            this.activity_history_panel.ResumeLayout(false);
            this.activity_history_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label current_user_label;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label current_position_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label index_current_page_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private rounded_panel activity_history_panel;
        private rounded_panel index_char_panel;
        private rounded_panel dash_project_panel;
        private System.Windows.Forms.Label dash_project_label;
        private exit_button exit_button1;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private rounded_button notification_bell_button;
        private text_box_mod text_box_mod1;
        private rounded_button rounded_button2;
        private rounded_panel rounded_panel4;
        private navbar navbar1;
        private rounded_panel dashboard_project_panel_button;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private text_box_mod index_activity_log;
        private System.Windows.Forms.ProgressBar progressBar1;
        private custom_progress_bar elec_work_progress_bar;
        private custom_progress_bar mechanical_work_progress_bar;
        private custom_progress_bar csa_work_progress_bar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label EW_Chart_percent;
        private System.Windows.Forms.Label MW_Chart_percent;
        private System.Windows.Forms.Label CSA_Chart_percent;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label index_project_name_label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label index_project_name_label1;
        private combo_box search_bar_box;
        private rounded_panel notification_panel;
        private System.Windows.Forms.Label Notification;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label unverified_count;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private text_box_mod notification_new_project_box;
        private text_box_mod notification_new_tasks_panel;
        private rounded_button notif_acknowledge_button;
    }
}