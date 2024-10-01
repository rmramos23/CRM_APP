namespace EEI_CRM.PAGES
{
    partial class client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(client));
            this.index_current_page_label = new System.Windows.Forms.Label();
            this.client_add_client = new EEI_CRM.rounded_button();
            this.task_sorting_table_panel = new EEI_CRM.rounded_panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.task_main_table_panel = new EEI_CRM.rounded_panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.exit_button1 = new EEI_CRM.exit_button();
            this.navbar1 = new EEI_CRM.navbar();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.task_sorting_table_panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.task_main_table_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // index_current_page_label
            // 
            this.index_current_page_label.AutoSize = true;
            this.index_current_page_label.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.index_current_page_label.Location = new System.Drawing.Point(312, 20);
            this.index_current_page_label.Name = "index_current_page_label";
            this.index_current_page_label.Size = new System.Drawing.Size(91, 32);
            this.index_current_page_label.TabIndex = 38;
            this.index_current_page_label.Text = "CLIENT";
            // 
            // client_add_client
            // 
            this.client_add_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.client_add_client.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.client_add_client.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.client_add_client.BorderRadius = 10;
            this.client_add_client.BorderSize = 0;
            this.client_add_client.Cursor = System.Windows.Forms.Cursors.Hand;
            this.client_add_client.FlatAppearance.BorderSize = 0;
            this.client_add_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.client_add_client.ForeColor = System.Drawing.Color.White;
            this.client_add_client.Location = new System.Drawing.Point(1104, 49);
            this.client_add_client.Name = "client_add_client";
            this.client_add_client.Size = new System.Drawing.Size(128, 40);
            this.client_add_client.TabIndex = 41;
            this.client_add_client.Text = "ADD CLIENT";
            this.client_add_client.TextColor = System.Drawing.Color.White;
            this.client_add_client.UseVisualStyleBackColor = false;
            this.client_add_client.Click += new System.EventHandler(this.client_add_client_Click);
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
            this.task_sorting_table_panel.TabIndex = 39;
            this.task_sorting_table_panel.TextColor = System.Drawing.Color.White;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(880, 35);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label7.Location = new System.Drawing.Point(774, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label6.Location = new System.Drawing.Point(572, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label3.Location = new System.Drawing.Point(52, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Client Name";
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
            this.task_main_table_panel.TabIndex = 40;
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
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label5.Location = new System.Drawing.Point(235, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Company";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(415, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Position";
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.client_add_client);
            this.Controls.Add(this.task_sorting_table_panel);
            this.Controls.Add(this.task_main_table_panel);
            this.Controls.Add(this.index_current_page_label);
            this.Controls.Add(this.exit_button1);
            this.Controls.Add(this.navbar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "client";
            this.Load += new System.EventHandler(this.client_Load);
            this.task_sorting_table_panel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.task_main_table_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private navbar navbar1;
        private exit_button exit_button1;
        private System.Windows.Forms.Label index_current_page_label;
        private rounded_button client_add_client;
        private rounded_panel task_sorting_table_panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private rounded_panel task_main_table_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}