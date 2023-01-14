using Diary.SQL;
using MySql.Data.MySqlClient;
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
        private MySqlCommand cmd;
        private MySqlDataReader reader;
        private SelectLogin selUser;
        private AddUser add;
        private bool IsMainClose = true;
        public Form_registr()
        {
            InitializeComponent();
        }


        private void button_registr_Click(object sender, EventArgs e)
        {
            if (textBox_emailInput.Text != "" & textBox_loginInput.Text != "" & textBox_pswInput.Text != "")
            {
                DBConnector.Open();

                selUser = new SelectLogin(textBox_loginInput.Text);
                cmd = new MySqlCommand(selUser.SqlString, DBConnector.connect);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Такой пользователь уже зарегистрирован! Смените ваш логин!","Ошибка");
                }
                else
                {
                    try
                    {
                        reader.Close();

                        add = new AddUser(textBox_loginInput.Text, textBox_pswInput.Text, textBox_emailInput.Text);

                        cmd = new MySqlCommand(add.SqlString, DBConnector.connect);

                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            Form_main.EnableMain();
                            this.Dispose();
                        }
                    }
                    catch (Exception)
                    {
                        throw new Exception("Ошибка регистрации пользователя!");
                    }
                }

                DBConnector.Close();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка");
            }
        }


        private void Form_registr_MouseLeave(object sender, EventArgs e)
        {
            this.label_registr.ForeColor = Color.Red;
        }

        private void Form_registr_MouseMove(object sender, MouseEventArgs e)
        {
            this.label_registr.ForeColor = Color.Blue;
        }


        private void label_registr_Click(object sender, EventArgs e)
        {
            Form_entrance fm = new Form_entrance();
            fm.TopMost = true;

            IsMainClose = false;
            this.Close();

            if (this.IsDisposed)
            {
                fm.Show();
            }
        }

        private void Form_registr_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsMainClose)
            {
                this.Dispose();
                Form_main.CloseMain();
            }
            else
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
}
