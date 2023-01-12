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
    public partial class Form_registr : Form
    {
        private Thread Th_fmRegistr;
        public Form_registr()
        {
            InitializeComponent();
        }

        private void label_registr_Click(object sender, EventArgs e)
        {
            this.Close();
            Th_fmRegistr = new Thread(ShowEntrance);
            Th_fmRegistr.SetApartmentState(ApartmentState.STA);
            Th_fmRegistr.Start();
        }
        private void ShowEntrance()
        {
            Form_entrance fm = new Form_entrance();
            fm.Location = this.Location;
            Application.Run(fm);
        }
    }
}
