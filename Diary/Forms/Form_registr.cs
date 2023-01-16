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
        private bool IsMainClose = true;
        private MySqlCommand cmd;
        private MySqlDataReader reader;
        private SelectUser selUser;
        private SelectEmail selEmail;
        private AddUser add;


        public Form_registr()
        {
            InitializeComponent();
        }


        private void button_registr_Click(object sender, EventArgs e)
        {
            if (textBox_emailInput.Text != "" & textBox_loginInput.Text != "" & textBox_pswInput.Text != "")
            {
                DBConnector.Open();

                if (IsLoginInDB(textBox_loginInput.Text))
                {
                    MessageBox.Show("Такой пользователь уже зарегистрирован! Смените ваш логин!","Ошибка");
                }
                else if(IsEmailInDB(textBox_emailInput.Text))
                {
                    MessageBox.Show("Пользователь с такой почтой уже создан! Нельзя иметь два учётные записи с одной почтой!", "Ошибка");
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
                            Person.IsAvtarised = true;
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

        private bool IsEmailInDB(string email)
        {
            if (!(reader == null))
            {
                reader.Close();
            }

            DBConnector.Open();

            selEmail = new SelectEmail(email);
            cmd = new MySqlCommand(selEmail.SqlString, DBConnector.connect);

            reader = cmd.ExecuteReader();

            return reader.Read();
        }
        private bool IsLoginInDB(string login)
        {
            if (!(reader == null))
            {
                reader.Close();
            }

            DBConnector.Open();

            selUser = new SelectUser(login);
            cmd = new MySqlCommand(selUser.SqlString, DBConnector.connect);

            reader = cmd.ExecuteReader();

            return reader.Read();
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
