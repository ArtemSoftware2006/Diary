using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diary.Forms;
using MySql.Data.MySqlClient;

namespace Diary
{
    public partial class Form_main : Form
    {
        private string connectStr = "server=localhost;uid=root;pwd=1111;database=practic";
        public Form_main()
        {
            InitializeComponent();

            DBConnector.CreateConction(connectStr);
        }

        private void button_newNote_Click(object sender, EventArgs e)
        {
            Form_addNote fm = new Form_addNote();
            fm.ShowDialog();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
