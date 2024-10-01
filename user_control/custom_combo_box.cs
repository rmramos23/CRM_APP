using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using Org.BouncyCastle.Asn1.Cmp;
using System.Runtime.Remoting.Messaging;
using System.Drawing.Design;
using System.Security.Permissions;
using System.Threading;
using System.Globalization;
using System.IO;

namespace EEI_CRM
{
    [DefaultEvent("OnSelectedIndexChanged")]
    class combo_box : UserControl
    {
        //fields
        private Color backColor = Color.White;
        private Color iconColor = Color.Navy;
        private Color listBackColor = Color.White;
        private Color listTextColor = Color.Navy;
        private Color borderColor = Color.Navy;
        private int borderSize = 1;
        private bool underLineState = false;
        //items
        private ComboBox cmblist;
        private Label lbltext;
        private Button btnIcon;

        //Constructor
        public combo_box()
        {
            cmblist = new ComboBox();
            lbltext = new Label();
            btnIcon = new Button();
            this.SuspendLayout();
   

            //ComboBox : Dropdown lsit
            cmblist.BackColor = listBackColor;
            cmblist.Font = new Font(this.Font.Name, 10F);
            cmblist.ForeColor = listTextColor;
            cmblist.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            cmblist.TextChanged += new EventHandler(ComboBox_TextChanged);
            cmblist.Dock = DockStyle.Fill;



            //buttton iconv 
            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.BackColor = backColor;
            btnIcon.Size = new Size(30, 30);
            btnIcon.Cursor = Cursors.Hand;
            btnIcon.Click += new EventHandler(Icon_Click);
            btnIcon.Paint += new PaintEventHandler(Icon_Paint);

            //label text
            lbltext.Dock = DockStyle.Fill;
            lbltext.AutoSize = false;
            lbltext.BackColor = backColor;
            lbltext.TextAlign = ContentAlignment.MiddleLeft;
            lbltext.Padding = new Padding(8, 0, 0, 0);
            lbltext.Font = new Font(this.Font.Name, 10F);
            lbltext.Click += new EventHandler(Surface_Click);


            //User Control
            this.Controls.Add(lbltext);
            this.Controls.Add(btnIcon);
            this.Controls.Add(cmblist);
            this.MinimumSize = new Size(200, 30);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.Gray;
            this.Padding = new Padding(borderSize);
            this.Font = new Font(this.Font.Name, 10F);
            base.BackColor = borderColor;
            this.ResumeLayout();
            AdjustComboBoxDimensions();

        }





        [Category("ComBo Box Mod")]
        public new Color BackColor
        {
            get
            {
                return backColor;
            }
            set
            {
                backColor = value;
                lbltext.BackColor = backColor;
                btnIcon.BackColor = backColor;
            }
        }
        [Category("ComBo Box Mod")]

        public Color IconColor
        {
            get
            {
                return iconColor;
            }
            set
            {
                iconColor = value;
                btnIcon.Invalidate();//redraw icon
            }
        }
        [Category("ComBo Box Mod")]

        public Color ListBackColor
        {
            get
            {
                return listBackColor;
            }
            set
            {
                listBackColor = value;
                cmblist.BackColor = listBackColor;

            }
        }
        [Category("ComBo Box Mod")]
        public Color ListTextColor
        {
            get
            {
                return listTextColor;
            }
            set
            {
                listTextColor = value;
                cmblist.ForeColor = listTextColor;
            }

        }
        [Category("ComBo Box Mod")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                base.BackColor = borderColor;
            }
        }
        [Category("ComBo Box Mod")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Padding = new Padding(borderSize);
                AdjustComboBoxDimensions();

            }
        }
        [Category("ComBo Box Mod")]


        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                lbltext.ForeColor = value;
            }
        }
        [Category("ComBo Box Mod")]
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                lbltext.Font = value;
                cmblist.Font = value;

            }

        }
        [Category("ComBo Box Mod")]
        public string Texts
        {
            get
            {
                return lbltext.Text;
            }
            set
            {
                lbltext.Text = value;
            }
        }
        [Category("ComBo Box Mod")]
        public ComboBoxStyle DropdownStyle
        {
            get
            {
                return cmblist.DropDownStyle;
            }
            set
            {
                if (cmblist.DropDownStyle != ComboBoxStyle.Simple)
                {
                    cmblist.DropDownStyle = value;
                }
            }
        }
        [Category("ComBo Box Mod")]
        public bool UnderLineState
        {
            get
            {
                return underLineState;
            }
            set
            {
                underLineState = value;
            }
        }


        //data

        [Category("ComBo Box Data")]
        //--datasource
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items
        {
            get
            {
                return cmblist.Items;
            }
        }



        [Category("ComBo Box Data")]
        //--datasource
        [DefaultValue(null)]
        [RefreshProperties(RefreshProperties.Repaint)]
        [AttributeProvider(typeof(IListSource))]

        public object DataSource
        {
            get
            {
                return cmblist.DataSource;
            }
            set
            {
                cmblist.DataSource = value;
            }
        }

        [Category("ComBo Box Data")]
        //--autocompletestring
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Localizable(true)]

        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get
            {
                return cmblist.AutoCompleteCustomSource;
            }
            set
            {
                cmblist.AutoCompleteCustomSource = value;
            }
        }

        [Category("ComBo Box Data")]
        //--autocompletesource
        [DefaultValue(AutoCompleteSource.None)]

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource
        {
            get
            {
                return cmblist.AutoCompleteSource;
            }
            set
            {
                cmblist.AutoCompleteSource = value;
            }

        }

        [Category("ComBo Box Data")]
        //--autoCompletemode
        [DefaultValue(AutoCompleteMode.None)]

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode
        {
            get
            {
                return cmblist.AutoCompleteMode;
            }
            set
            {
                cmblist.AutoCompleteMode = value;
            }
        }

        [Category("ComBo Box Data")]
        //--SelectedItem
        [Browsable(false)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]

        public object SelectedItem
        {
            get
            {
                return cmblist.SelectedItem;
            }
            set
            {
                cmblist.SelectedItem = value;
            }
        }

        [Category("ComBo Box Data")]
        //--SelectedIndex
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]

        public int SelectedIndex
        {
            get
            {
                return cmblist.SelectedIndex;
            }
            set
            {
                cmblist.SelectedIndex = value;
            }
        }




        //
        // Summary:
        //     Raises the System.Windows.Forms.Control.TextChanged event.
        //
        // Parameters:
        //   e:
        //     An System.EventArgs that contains the event data.



        //events

        public event EventHandler OnSelectedIndexChanged;//default event
        //public event EventHandler TextChanged;

        //private methods


        private void AdjustComboBoxDimensions()
        {

            cmblist.Width = lbltext.Width;

            cmblist.Location = new Point()
            {
                X = this.Width - this.Padding.Right - cmblist.Width,
                Y = lbltext.Bottom - cmblist.Height
            };
        }

        private void Surface_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
            //select combo box
            cmblist.Select();
            if (cmblist.DropDownStyle == ComboBoxStyle.DropDownList)
            {
                cmblist.DroppedDown = true;
            }
        }



        private void Icon_Click(object sender, EventArgs e)
        {
            cmblist.Select();
            cmblist.DroppedDown = true;
        }

        public void ComboBox_TextChanged(object sender, EventArgs e)
        {
            lbltext.Text = cmblist.Text;



        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
            {
                OnSelectedIndexChanged.Invoke(sender, e);
                lbltext.Text = cmblist.Text;
            }
        }

        //draw icon
        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            int iconWidth = 14;
            int iconHeight = 6;

            var rectIcon = new Rectangle((btnIcon.Width - iconWidth) / 2, (btnIcon.Height - iconHeight) / 2, iconWidth, iconHeight);
            Graphics graph = e.Graphics;
        


            //Draw arrow down icon
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(iconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidth / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidth / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);


                graph.DrawPath(pen, path);


            }
            //using (Pen penborder = new Pen(IconColor, 3))
            //{
            //    penborder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
            //    if (UnderLineState )
            //    { 
            //        graph.DrawLine(penborder, 0 , this.Height-1,this.Width,this.Height-1);
            //    }


            //}



        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // combo_box
            // 
            this.Name = "combo_box";
            this.ResumeLayout(false);

        }
    }

}
