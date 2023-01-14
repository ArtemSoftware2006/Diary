using Diary.SQL;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
        private MySqlCommand cmd;
        private SelectUser selUser;
        private MySqlDataReader reader;
        public Form_entrance()
        {
            InitializeComponent();
        }

        private void label_registr_Click(object sender, EventArgs e)
        {
            Form_registr fm = new Form_registr();
            fm.TopMost = true;
            this.Close();
            if (this .IsDisposed)
            {
                fm.Show();
            }
        }
        private void button_entrance_Click(object sender, EventArgs e)
        {
            DBConnector.Open();

            selUser = new SelectUser(textBox_loginInput.Text, textBox_pswInput.Text);
            cmd = new MySqlCommand(selUser.SqlString, DBConnector.connect);

            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                this.Dispose();

                Application.OpenForms[0].Enabled= true;
            }
            else
            {
                MessageBox.Show("Мы не нашли такого пользователя!", "Ошибка!");
            }

            DBConnector.Close();
        }



        private void label_registr_MouseMove(object sender, MouseEventArgs e)
        {
            this.label_registr.ForeColor = Color.Red;
        }

        private void label_registr_MouseLeave(object sender, EventArgs e)
        {
            this.label_registr.ForeColor = Color.Blue;
        }

        private void Form_entrance_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Если вы выйдете, то все данные удалятся!", "Вы хотите выйты?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Dispose();
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
