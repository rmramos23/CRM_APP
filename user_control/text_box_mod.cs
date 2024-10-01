using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEI_CRM
{
    [DefaultEvent("_TextChanged")]

    public partial class text_box_mod : UserControl
    {
        //fields
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underLinedStyle = false;
        private Color onFocusBorderColor = Color.DarkGray;
        private bool onFocusState = false;
        private Color onFocusTextColor = Color.Navy;
        //constructors
        public text_box_mod()
        {
            InitializeComponent();
        }
        //events
        public event EventHandler _TextChanged;

        //properties

        [Category("TextBox Mod")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate(); //syntax to redraw the property
            }

        }
        [Category("TextBox Mod")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        [Category("TextBox Mod")]
        public bool UnderLinedStyle
        {
            get
            {
                return underLinedStyle;
            }
            set
            {
                underLinedStyle = value;
                this.Invalidate();
            }
        }
        [Category("TextBox Mod")]
        public bool PasswordChar
        {
            get
            {
                return textBox1.UseSystemPasswordChar;

            }
            set
            {
                textBox1.UseSystemPasswordChar = value;
            }
        }
        [Category("TextBox Mod")]
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }
        [Category("TextBox Mod")]
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }
        [Category("TextBox Mod")]
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (DesignMode)
                {
                    UpdateControlHeight();
                }
            }
        }
        [Category("TextBox Mod")]
        public String Texts
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }
        [Category("TextBox Mod")]
        public bool Multiline
        {
            get
            {
                return textBox1.Multiline;
            }
            set
            {
                textBox1.Multiline = value;
            }

        }

        [Category("TextBox Mod")]
        public Color OnFocusBorderColor
        {
            get
            {
                return onFocusBorderColor;
            }
            set
            {
                onFocusBorderColor = value;
            }

        }
        [Category("TextBox Mod")]
        public Color OnFocusTextColor
        {
            get
            {
                return onFocusTextColor;
            }
            set
            {
                onFocusTextColor = value;
            }

        }


        //Overriden methods

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            //draw border
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (onFocusState)
                {
                    penBorder.Color = onFocusBorderColor;
                    if (underLinedStyle)//if the underlinedStyle property is true 
                    {
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1); // (penBorder, x_start, y_start, x_finish, y_finish)
                    }
                    else
                    {
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }

                }
                else
                {
                    if (underLinedStyle)//if the underlinedStyle property is true 
                    {
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1); // (penBorder, x_start, y_start, x_finish, y_finish)
                    }
                    else
                    {
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }

                }



            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
            {

                UpdateControlHeight();
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {

                int txtHeight = TextRenderer.MeasureText("TEST", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;

            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
            {
                _TextChanged.Invoke(sender, e);
            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            this.OnKeyDown(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            this.OnMouseHover(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            onFocusState = true;
            textBox1.ForeColor = onFocusTextColor;
            this.Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.ForeColor = this.ForeColor;
            onFocusState = false;
            this.Invalidate();
        }

    }
}
