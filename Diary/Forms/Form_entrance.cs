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
    public partial class Form_entrance : Form
    {
        public Form_entrance()
        {
            InitializeComponent();
        }

        private void label_registr_Click(object sender, EventArgs e)
        {
            Form_registr fm = new Form_registr();
            fm.Show();
            this.Close();
        }

        private void label_registr_Enter(object sender, EventArgs e)
        {
            this.label_registr.ForeColor= Color.FromArgb(0, 0, 192);
        }

        private void label_registr_Leave(object sender, EventArgs e)
        {
            this.label_registr.ForeColor = Color.Blue;
        }

        private void Form_entrance_Load(object sender, EventArgs e)
        {
           
        }
    }
}
