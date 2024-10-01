namespace EEI_CRM.PAGES
{
    partial class load_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(load_screen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            this.custom_progress_bar1 = new EEI_CRM.custom_progress_bar();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(115, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 194);
            this.panel1.TabIndex = 0;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandTimeout = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // custom_progress_bar1
            // 
            this.custom_progress_bar1.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.custom_progress_bar1.BoxBackgroundColor = System.Drawing.Color.Transparent;
            this.custom_progress_bar1.BoxBorderColor = System.Drawing.Color.Red;
            this.custom_progress_bar1.BoxBorderSize = 2;
            this.custom_progress_bar1.BoxHeight = 28;
            this.custom_progress_bar1.BoxWidth = 306;
            this.custom_progress_bar1.Location = new System.Drawing.Point(72, 308);
            this.custom_progress_bar1.Max_Val = 100;
            this.custom_progress_bar1.Min_Val = 0;
            this.custom_progress_bar1.Name = "custom_progress_bar1";
            this.custom_progress_bar1.Size = new System.Drawing.Size(306, 28);
            this.custom_progress_bar1.TabIndex = 1;
            this.custom_progress_bar1.Value = 20;
            // 
            // load_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 380);
            this.Controls.Add(this.custom_progress_bar1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "load_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "load_screen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private custom_progress_bar custom_progress_bar1;
    }
}