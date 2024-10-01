namespace EEI_CRM
{
    partial class data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(data));
            this.navbar1 = new EEI_CRM.navbar();
            this.exit_button1 = new EEI_CRM.exit_button();
            this.SuspendLayout();
            // 
            // navbar1
            // 
            this.navbar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.navbar1.Location = new System.Drawing.Point(0, 0);
            this.navbar1.Name = "navbar1";
            this.navbar1.Size = new System.Drawing.Size(292, 800);
            this.navbar1.TabIndex = 0;
            // 
            // exit_button1
            // 
            this.exit_button1.BackColor = System.Drawing.Color.Transparent;
            this.exit_button1.Location = new System.Drawing.Point(1250, 0);
            this.exit_button1.Name = "exit_button1";
            this.exit_button1.Size = new System.Drawing.Size(30, 30);
            this.exit_button1.TabIndex = 30;
            // 
            // data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.exit_button1);
            this.Controls.Add(this.navbar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EPC CRM";
            this.Load += new System.EventHandler(this.data_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private navbar navbar1;
        private exit_button exit_button1;
    }
}