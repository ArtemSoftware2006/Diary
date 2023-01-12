using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary.Forms
{
    public partial class Form_entrance : Form
    {
        Thread Th_fmRegistr;
        public Form_entrance()
        {
            InitializeComponent();
        }

        private void label_registr_Click(object sender, EventArgs e)
        {
            this.Close();
            Th_fmRegistr = new Thread(ShowRegistr);
            Th_fmRegistr.SetApartmentState(ApartmentState.STA);
            Th_fmRegistr.Start();
        }
        private void ShowRegistr()
        {
            Form_registr fm = new Form_registr();
            fm.Location = this.Location;
            Application.Run(fm);
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
