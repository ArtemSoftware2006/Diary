using Diary.Data.Directory;
using Diary.Data.Entity;
using Diary.Data.User.FileUserDirectory;
using Diary.Data.User.Tools;
using Diary.Properties;
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
    public partial class Form_registr : Form
    {
        private bool IsMainClose = true;
        private Users user;
        private FindUserByLogin findUserByLogin;
        private FindUserByEmail findUserByEmail;
        private FileUserSaving fileUserSaving;
        private PathUser pathUser;

        public Form_registr()
        {
            InitializeComponent();
        }


        private void button_registr_Click(object sender, EventArgs e)
        {
            if (textBox_emailInput.Text != "" & textBox_loginInput.Text != "" & textBox_pswInput.Text != "")
            {
                user = new Users();

                user.IdUser = Settings.Default.CounterUser;
                user.Login = textBox_loginInput.Text;
                user.Password = textBox_pswInput.Text;
                user.Email = textBox_emailInput.Text;

                pathUser = new PathUser();

                pathUser.CreateNewDirectory(FileUsersNames.DirectoryName + Settings.Default.CounterUser.ToString());
                pathUser.CreateNewPath(FileUsersNames.FileName + Settings.Default.CounterUser.ToString());

                fileUserSaving = new FileUserSaving(pathUser.PathFile);

                findUserByLogin = new FindUserByLogin(user.Login, pathUser.PathFile);
                findUserByEmail = new FindUserByEmail(user.Email, pathUser.PathFile);


                if (fileUserSaving.Find(findUserByLogin))
                {
                    MessageBox.Show("Такой пользователь уже зарегистрирован! Смените ваш логин!","Ошибка");
                }
                else if(fileUserSaving.Find(findUserByEmail))
                {
                    MessageBox.Show("Пользователь с такой почтой уже создан! Нельзя иметь два учётные записи с одной почтой!", "Ошибка");
                }
                else
                {
                    try
                    {
                        fileUserSaving.Create(user);

                        if (fileUserSaving.Find(findUserByLogin))
                        {
                            Settings.Default.CounterUser++;
                            Settings.Default.Save();

                            Person.IdUser = user.IdUser;
                            Person.Email = user.Email;
                            Person.Login = user.Login;
                            Person.Password = user.Password;

                            Form_main.EnableMain();
                            this.Dispose();
                        }
                    }
                    catch (Exception)
                    {
                        throw new Exception("Ошибка регистрации пользователя!");
                    }
                }

                //DBConnector.Close();
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
