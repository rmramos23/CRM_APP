namespace EEI_CRM
{
    partial class index_perproject_panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index_perproject_panel));
            this.project_name = new System.Windows.Forms.Label();
            this.project_cost = new System.Windows.Forms.Label();
            this.rounded_panel3 = new EEI_CRM.rounded_panel();
            this.rounded_panel1 = new EEI_CRM.rounded_panel();
            this.rounded_panel2 = new EEI_CRM.rounded_panel();
            this.rounded_panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // project_name
            // 
            this.project_name.AutoSize = true;
            this.project_name.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.project_name.Location = new System.Drawing.Point(87, 10);
            this.project_name.Name = "project_name";
            this.project_name.Size = new System.Drawing.Size(66, 30);
            this.project_name.TabIndex = 0;
            this.project_name.Text = "label1";
            // 
            // project_cost
            // 
            this.project_cost.AutoSize = true;
            this.project_cost.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_cost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.project_cost.Location = new System.Drawing.Point(90, 37);
            this.project_cost.Name = "project_cost";
            this.project_cost.Size = new System.Drawing.Size(39, 15);
            this.project_cost.TabIndex = 1;
            this.project_cost.Text = "label2";
            // 
            // rounded_panel3
            // 
            this.rounded_panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(188)))), ((int)(((byte)(131)))));
            this.rounded_panel3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(188)))), ((int)(((byte)(131)))));
            this.rounded_panel3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rounded_panel3.BorderRadius = 20;
            this.rounded_panel3.BorderSize = 0;
            this.rounded_panel3.ForeColor = System.Drawing.Color.White;
            this.rounded_panel3.Location = new System.Drawing.Point(17, 10);
            this.rounded_panel3.Name = "rounded_panel3";
            this.rounded_panel3.Size = new System.Drawing.Size(40, 40);
            this.rounded_panel3.TabIndex = 3;
            this.rounded_panel3.TextColor = System.Drawing.Color.White;
            // 
            // rounded_panel1
            // 
            this.rounded_panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rounded_panel1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.rounded_panel1.BorderColor = System.Drawing.Color.White;
            this.rounded_panel1.BorderRadius = 5;
            this.rounded_panel1.BorderSize = 0;
            this.rounded_panel1.Controls.Add(this.rounded_panel2);
            this.rounded_panel1.Controls.Add(this.rounded_panel3);
            this.rounded_panel1.Controls.Add(this.project_cost);
            this.rounded_panel1.Controls.Add(this.project_name);
            this.rounded_panel1.ForeColor = System.Drawing.Color.White;
            this.rounded_panel1.Location = new System.Drawing.Point(0, 0);
            this.rounded_panel1.Name = "rounded_panel1";
            this.rounded_panel1.Size = new System.Drawing.Size(380, 60);
            this.rounded_panel1.TabIndex = 37;
            this.rounded_panel1.TextColor = System.Drawing.Color.White;
            // 
            // rounded_panel2
            // 
            this.rounded_panel2.BackColor = System.Drawing.Color.Transparent;
            this.rounded_panel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.rounded_panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rounded_panel2.BackgroundImage")));
            this.rounded_panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rounded_panel2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rounded_panel2.BorderRadius = 5;
            this.rounded_panel2.BorderSize = 0;
            this.rounded_panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rounded_panel2.ForeColor = System.Drawing.Color.White;
            this.rounded_panel2.Location = new System.Drawing.Point(339, 12);
            this.rounded_panel2.Name = "rounded_panel2";
            this.rounded_panel2.Size = new System.Drawing.Size(29, 36);
            this.rounded_panel2.TabIndex = 4;
            this.rounded_panel2.TextColor = System.Drawing.Color.White;
            this.rounded_panel2.Click += new System.EventHandler(this.rounded_panel2_Click);
            // 
            // index_perproject_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.rounded_panel1);
            this.Name = "index_perproject_panel";
            this.Size = new System.Drawing.Size(380, 60);
            this.rounded_panel1.ResumeLayout(false);
            this.rounded_panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label project_name;
        private System.Windows.Forms.Label project_cost;
        private rounded_panel rounded_panel3;
        private rounded_panel rounded_panel1;
        private rounded_panel rounded_panel2;
    }
}
