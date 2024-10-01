namespace EEI_CRM
{
    partial class dashboard_button
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard_button));
            this.rounded_panel1 = new EEI_CRM.rounded_panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DASHBOARD = new System.Windows.Forms.Label();
            this.rounded_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rounded_panel1
            // 
            this.rounded_panel1.BackColor = System.Drawing.Color.Transparent;
            this.rounded_panel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.rounded_panel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rounded_panel1.BorderRadius = 20;
            this.rounded_panel1.BorderSize = 0;
            this.rounded_panel1.Controls.Add(this.pictureBox1);
            this.rounded_panel1.Controls.Add(this.DASHBOARD);
            this.rounded_panel1.ForeColor = System.Drawing.Color.White;
            this.rounded_panel1.Location = new System.Drawing.Point(0, 0);
            this.rounded_panel1.Name = "rounded_panel1";
            this.rounded_panel1.Size = new System.Drawing.Size(260, 60);
            this.rounded_panel1.TabIndex = 0;
            this.rounded_panel1.TextColor = System.Drawing.Color.White;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(26, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // DASHBOARD
            // 
            this.DASHBOARD.AutoSize = true;
            this.DASHBOARD.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DASHBOARD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DASHBOARD.Location = new System.Drawing.Point(108, 21);
            this.DASHBOARD.Name = "DASHBOARD";
            this.DASHBOARD.Size = new System.Drawing.Size(107, 21);
            this.DASHBOARD.TabIndex = 0;
            this.DASHBOARD.Text = "DASHBOARD";
            // 
            // dashboard_button
            // 

            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.rounded_panel1);
            this.Name = "dashboard_button";
            this.Size = new System.Drawing.Size(260, 60);
            this.rounded_panel1.ResumeLayout(false);
            this.rounded_panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private rounded_panel rounded_panel1;
        private System.Windows.Forms.Label DASHBOARD;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
