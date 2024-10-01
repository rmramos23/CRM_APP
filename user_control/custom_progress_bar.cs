using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Org.BouncyCastle.Asn1.Mozilla;
using System.ComponentModel;
namespace EEI_CRM
{
    public class custom_progress_bar : UserControl
    {
        //set variables and default values
        private int min_val = 0;
        private int max_val = 100;
        private int val = 0;
        //set size for the rectangle
        private Color barcolor = Color.Blue;


        //for rectangle container of the progress bar

        private int box_width = 200;
        private int box_height = 40;
        private Color box_border_color = Color.Red;
        private int box_border_size = 2;
        private Color box_background_color = Color.Blue;

        [Category("Custom Property")]
        public int Min_Val 
        {
            get
            {
                return min_val; 
            }
            set
            {
                min_val = value;
            }
        }
        [Category("Custom Property")]
        public int Max_Val
        {
            get
            {
                return max_val ;
            }
            set 
            {
                max_val = value;
            }
        }
        [Category("Custom Property")]
        public int Value
        {
            get
            {
                return val;
            }
            set
            {
                 val = value;
                Invalidate();
            }
        }
        [Category("Custom Property")]
        public Color BarColor 
        {
            get
            {
                return barcolor;
            }
            set
            {
                barcolor = value;
            }
        }
        [Category("Custom Property")]
        public int BoxWidth
        {
            get
            {
                return box_width;
            }
            set
            {
                box_width = value;
                Invalidate();
            }
        }
        [Category("Custom Property")]
        public int BoxHeight
        {
            get
            {
                return box_height;
            }
            set
            {
                box_height = value;
                Invalidate();
            }
        }
        [Category("Custom Property")]
        public Color BoxBackgroundColor 
        {
            get
            {
                return box_background_color;
            }
            set
            {
                box_background_color = value;
                Invalidate();
            }
        }
        [Category("Custom Property")]
        public Color BoxBorderColor
        {
            get
            {
                return box_border_color;
            }
            set
            {
                box_border_color = value;
                Invalidate();
            }
        }
        [Category("Custom Property")]
        public int BoxBorderSize 
        {
            get
            {
                return box_border_size;
            }
            set
            {
                box_border_size = value;
                Invalidate();
            }
        }
        //encapsulate
        //override the onPaint function
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            //draw the background 
            using (SolidBrush backgroundBrush = new SolidBrush(box_background_color))//since this will fill up color for a certain part, use SolidBrush 
            {
                graphics.FillRectangle(backgroundBrush, 0,0,box_width,box_height); 
            }

            //draw the border
            using (Pen borderPen = new Pen(box_border_color,box_border_size)) //since this will draw the border part of the box, use Pen
            {
                graphics.DrawRectangle(borderPen,0,0,box_width, box_height);
            }
            //compute percentage

            float percent = (float)(val - min_val) / (max_val - min_val);
            //create rect for progress part of the progressbar
            Rectangle rect = new Rectangle(0, 0, (int)(box_width * percent), box_height);
            using (SolidBrush progressbrush = new SolidBrush(barcolor)) 
            {
                graphics.FillRectangle(progressbrush, rect);
            }

        }



    }

}
