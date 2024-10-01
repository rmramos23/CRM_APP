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
    public partial class data : Form
    {
        public data()
        {
            InitializeComponent();
        }
        private string current_page = "DATA";
        private void data_Load(object sender, EventArgs e)
        {
            navbar1.navigation_current_page(current_page);
                
        }
    }
}
