using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diary.Data.Notes;
using Diary.Forms;
using Diary.Properties;
using MySql.Data.MySqlClient;

namespace Diary
{
    public partial class Form_main : Form
    {
        private string connectStr = "server=localhost;uid=root;pwd=1111;database=Diary";
        public Form_main()
        {
            InitializeComponent();
            DBConnector.CreateConction(connectStr);
        }



        public static void CloseMain()
        {
            Application.Exit();
        }
        public static void EnableMain()
        {
            Application.OpenForms[0].Enabled = true;
        }


        private void Form_main_Load(object sender, EventArgs e)
        {
            FileNames.FilePropertyName = $"noteProperty";
            FileNames.FileTextName = $"noteText";
            FileNames.DirectoryName = $"Note";

            Form_entrance fm = new Form_entrance();
            fm.TopMost = true;
            fm.Show();
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

        private void button_showAllNotes_Click(object sender, EventArgs e)
        {
            Form_showNotes fm = new Form_showNotes();
            fm.ShowDialog();
        }
    }
}
