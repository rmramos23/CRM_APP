namespace EEI_CRM
{
    partial class tasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tasks));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.index_current_page_label = new System.Windows.Forms.Label();
            this.tasks_current_page_label = new System.Windows.Forms.Label();
            this.task_existing_task_add_button = new EEI_CRM.rounded_button();
            this.task_sorting_table_panel = new EEI_CRM.rounded_panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.task_sorter_group_box = new EEI_CRM.combo_box();
            this.task_sorter_project_box = new EEI_CRM.combo_box();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.navbar1 = new EEI_CRM.navbar();
            this.exit_button1 = new EEI_CRM.exit_button();
            this.task_main_table_panel = new EEI_CRM.rounded_panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.welcome_panel_no_task = new EEI_CRM.rounded_panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.welcome_panel_no_task_add_button = new EEI_CRM.rounded_button();
            this.task_sorting_table_panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.task_main_table_panel.SuspendLayout();
            this.welcome_panel_no_task.SuspendLayout();
            this.SuspendLayout();
            // 
            // index_current_page_label
            // 
            this.index_current_page_label.AutoSize = true;
            this.index_current_page_label.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.index_current_page_label.Location = new System.Drawing.Point(312, 20);
            this.index_current_page_label.Name = "index_current_page_label";
            this.index_current_page_label.Size = new System.Drawing.Size(21, 32);
            this.index_current_page_label.TabIndex = 37;
            this.index_current_page_label.Text = " ";
            // 
            // tasks_current_page_label
            // 
            this.tasks_current_page_label.AutoSize = true;
            this.tasks_current_page_label.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasks_current_page_label.Location = new System.Drawing.Point(315, 20);
            this.tasks_current_page_label.Name = "tasks_current_page_label";
            this.tasks_current_page_label.Size = new System.Drawing.Size(187, 32);
            this.tasks_current_page_label.TabIndex = 38;
            this.tasks_current_page_label.Text = "CURRENT_PAGE";
            // 
            // task_existing_task_add_button
            // 
            this.task_existing_task_add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.task_existing_task_add_button.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.task_existing_task_add_button.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.task_existing_task_add_button.BorderRadius = 10;
            this.task_existing_task_add_button.BorderSize = 0;
            this.task_existing_task_add_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.task_existing_task_add_button.FlatAppearance.BorderSize = 0;
            this.task_existing_task_add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.task_existing_task_add_button.ForeColor = System.Drawing.Color.White;
            this.task_existing_task_add_button.Location = new System.Drawing.Point(1104, 49);
            this.task_existing_task_add_button.Name = "task_existing_task_add_button";
            this.task_existing_task_add_button.Size = new System.Drawing.Size(128, 40);
            this.task_existing_task_add_button.TabIndex = 36;
            this.task_existing_task_add_button.Text = "ADD TASK";
            this.task_existing_task_add_button.TextColor = System.Drawing.Color.White;
            this.task_existing_task_add_button.UseVisualStyleBackColor = false;
            this.task_existing_task_add_button.Click += new System.EventHandler(this.task_existing_task_add_button_Click);
            // 
            // task_sorting_table_panel
            // 
            this.task_sorting_table_panel.BackColor = System.Drawing.Color.White;
            this.task_sorting_table_panel.BackgroundColor = System.Drawing.Color.White;
            this.task_sorting_table_panel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.task_sorting_table_panel.BorderRadius = 10;
            this.task_sorting_table_panel.BorderSize = 0;
            this.task_sorting_table_panel.Controls.Add(this.tableLayoutPanel1);
            this.task_sorting_table_panel.ForeColor = System.Drawing.Color.White;
            this.task_sorting_table_panel.Location = new System.Drawing.Point(337, 95);
            this.task_sorting_table_panel.Name = "task_sorting_table_panel";
            this.task_sorting_table_panel.Size = new System.Drawing.Size(916, 55);
            this.task_sorting_table_panel.TabIndex = 34;
            this.task_sorting_table_panel.TextColor = System.Drawing.Color.White;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Controls.Add(this.task_sorter_group_box, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.task_sorter_project_box, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(880, 35);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // task_sorter_group_box
            // 
            this.task_sorter_group_box.BackColor = System.Drawing.Color.White;
            this.task_sorter_group_box.BorderColor = System.Drawing.Color.White;
            this.task_sorter_group_box.BorderSize = 1;
            this.task_sorter_group_box.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.task_sorter_group_box.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_sorter_group_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.task_sorter_group_box.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.task_sorter_group_box.Items.AddRange(new object[] {
            "Task Group(ALL)",
            "Electrical Works",
            "Civil, Structural and Architectural Works",
            "Mechanical Works"});
            this.task_sorter_group_box.ListBackColor = System.Drawing.Color.White;
            this.task_sorter_group_box.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.task_sorter_group_box.Location = new System.Drawing.Point(128, 3);
            this.task_sorter_group_box.MinimumSize = new System.Drawing.Size(100, 20);
            this.task_sorter_group_box.Name = "task_sorter_group_box";
            this.task_sorter_group_box.Padding = new System.Windows.Forms.Padding(1);
            this.task_sorter_group_box.Size = new System.Drawing.Size(119, 29);
            this.task_sorter_group_box.TabIndex = 6;
            this.task_sorter_group_box.Texts = "Task Group(ALL)";
            this.task_sorter_group_box.UnderLineState = false;
            this.task_sorter_group_box.OnSelectedIndexChanged += new System.EventHandler(this.task_sorter_group_box_OnSelectedIndexChanged);
            // 
            // task_sorter_project_box
            // 
            this.task_sorter_project_box.BackColor = System.Drawing.Color.White;
            this.task_sorter_project_box.BorderColor = System.Drawing.Color.White;
            this.task_sorter_project_box.BorderSize = 1;
            this.task_sorter_project_box.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.task_sorter_project_box.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_sorter_project_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.task_sorter_project_box.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.task_sorter_project_box.ListBackColor = System.Drawing.Color.White;
            this.task_sorter_project_box.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.task_sorter_project_box.Location = new System.Drawing.Point(753, 3);
            this.task_sorter_project_box.MinimumSize = new System.Drawing.Size(100, 20);
            this.task_sorter_project_box.Name = "task_sorter_project_box";
            this.task_sorter_project_box.Padding = new System.Windows.Forms.Padding(1);
            this.task_sorter_project_box.Size = new System.Drawing.Size(124, 29);
            this.task_sorter_project_box.TabIndex = 0;
            this.task_sorter_project_box.Texts = "Projects(ALL)";
            this.task_sorter_project_box.UnderLineState = false;
            this.task_sorter_project_box.OnSelectedIndexChanged += new System.EventHandler(this.task_sorter_project_box_OnSelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label8.Location = new System.Drawing.Point(652, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Task Priority";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label7.Location = new System.Drawing.Point(529, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Task Status";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label6.Location = new System.Drawing.Point(397, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Task due Date";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label5.Location = new System.Drawing.Point(272, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Task Category";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label3.Location = new System.Drawing.Point(30, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Task Name";
            // 
            // navbar1
            // 
            this.navbar1.Location = new System.Drawing.Point(0, 0);
            this.navbar1.Name = "navbar1";
            this.navbar1.Size = new System.Drawing.Size(292, 800);
            this.navbar1.TabIndex = 31;
            // 
            // exit_button1
            // 
            this.exit_button1.BackColor = System.Drawing.Color.Transparent;
            this.exit_button1.Location = new System.Drawing.Point(1250, 0);
            this.exit_button1.Name = "exit_button1";
            this.exit_button1.Size = new System.Drawing.Size(30, 30);
            this.exit_button1.TabIndex = 30;
            // 
            // task_main_table_panel
            // 
            this.task_main_table_panel.BackColor = System.Drawing.Color.White;
            this.task_main_table_panel.BackgroundColor = System.Drawing.Color.White;
            this.task_main_table_panel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.task_main_table_panel.BorderRadius = 20;
            this.task_main_table_panel.BorderSize = 0;
            this.task_main_table_panel.Controls.Add(this.flowLayoutPanel1);
            this.task_main_table_panel.ForeColor = System.Drawing.Color.White;
            this.task_main_table_panel.Location = new System.Drawing.Point(318, 156);
            this.task_main_table_panel.Name = "task_main_table_panel";
            this.task_main_table_panel.Size = new System.Drawing.Size(950, 605);
            this.task_main_table_panel.TabIndex = 35;
            this.task_main_table_panel.TextColor = System.Drawing.Color.White;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(40, 19);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(880, 571);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // welcome_panel_no_task
            // 
            this.welcome_panel_no_task.BackColor = System.Drawing.Color.White;
            this.welcome_panel_no_task.BackgroundColor = System.Drawing.Color.White;
            this.welcome_panel_no_task.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.welcome_panel_no_task.BorderRadius = 20;
            this.welcome_panel_no_task.BorderSize = 0;
            this.welcome_panel_no_task.Controls.Add(this.label2);
            this.welcome_panel_no_task.Controls.Add(this.label1);
            this.welcome_panel_no_task.Controls.Add(this.welcome_panel_no_task_add_button);
            this.welcome_panel_no_task.ForeColor = System.Drawing.Color.White;
            this.welcome_panel_no_task.Location = new System.Drawing.Point(463, 220);
            this.welcome_panel_no_task.Name = "welcome_panel_no_task";
            this.welcome_panel_no_task.Size = new System.Drawing.Size(646, 361);
            this.welcome_panel_no_task.TabIndex = 32;
            this.welcome_panel_no_task.TextColor = System.Drawing.Color.White;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(199, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "CREATE YOUR FIRST TASK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(62, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "NO TASKS YET CONNECTED TO YOUR ACCOUNT";
            // 
            // welcome_panel_no_task_add_button
            // 
            this.welcome_panel_no_task_add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.welcome_panel_no_task_add_button.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.welcome_panel_no_task_add_button.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.welcome_panel_no_task_add_button.BorderRadius = 10;
            this.welcome_panel_no_task_add_button.BorderSize = 0;
            this.welcome_panel_no_task_add_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.welcome_panel_no_task_add_button.FlatAppearance.BorderSize = 0;
            this.welcome_panel_no_task_add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.welcome_panel_no_task_add_button.ForeColor = System.Drawing.Color.White;
            this.welcome_panel_no_task_add_button.Location = new System.Drawing.Point(264, 267);
            this.welcome_panel_no_task_add_button.Name = "welcome_panel_no_task_add_button";
            this.welcome_panel_no_task_add_button.Size = new System.Drawing.Size(128, 40);
            this.welcome_panel_no_task_add_button.TabIndex = 2;
            this.welcome_panel_no_task_add_button.Text = "ADD TASK";
            this.welcome_panel_no_task_add_button.TextColor = System.Drawing.Color.White;
            this.welcome_panel_no_task_add_button.UseVisualStyleBackColor = false;
            this.welcome_panel_no_task_add_button.Click += new System.EventHandler(this.welcome_panel_no_task_add_button_Click);
            // 
            // tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.tasks_current_page_label);
            this.Controls.Add(this.index_current_page_label);
            this.Controls.Add(this.task_existing_task_add_button);
            this.Controls.Add(this.task_sorting_table_panel);
            this.Controls.Add(this.navbar1);
            this.Controls.Add(this.exit_button1);
            this.Controls.Add(this.task_main_table_panel);
            this.Controls.Add(this.welcome_panel_no_task);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tasks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "2";
            this.Load += new System.EventHandler(this.tasks_Load);
            this.task_sorting_table_panel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.task_main_table_panel.ResumeLayout(false);
            this.welcome_panel_no_task.ResumeLayout(false);
            this.welcome_panel_no_task.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private exit_button exit_button1;
        private navbar navbar1;
        private rounded_panel welcome_panel_no_task;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private rounded_button welcome_panel_no_task_add_button;
        private rounded_panel task_sorting_table_panel;
        private rounded_panel task_main_table_panel;
        private rounded_button task_existing_task_add_button;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private combo_box task_sorter_project_box;
        private System.Windows.Forms.Label index_current_page_label;
        private combo_box task_sorter_group_box;
        private System.Windows.Forms.Label tasks_current_page_label;
    }
}