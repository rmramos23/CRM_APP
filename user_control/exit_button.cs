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
    public partial class exit_button : UserControl
    {
        public exit_button()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form current_form = this.FindForm();
            if (current_form != null) 
            {
                current_form.Close();
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Cursor = Cursors.Hand;
            
        }
    }
}
