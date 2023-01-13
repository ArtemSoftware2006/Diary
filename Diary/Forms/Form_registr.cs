using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary.Forms
{
    public partial class Form_registr : Form
    {
        public Form_registr()
        {
            InitializeComponent();
        }

        private void label_registr_Click(object sender, EventArgs e)
        {
            Form_entrance fm = new Form_entrance();
            fm.Location = this.Location;
            fm.TopMost = true;
            fm.Show();
            this.Close();
        }
    }
}
