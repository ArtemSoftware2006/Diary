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
    public partial class Form_entrance : Form
    {
        private bool IsMainClose = true;
        private List<Users> listUsers;
        //private MySqlCommand cmd;
        //private SelectPerson selectUser;
        //private SelectLoginAndPsw selectloginAndPsd;
        //private DataTable table;
        //private MySqlDataAdapter adapter;
        //private MySqlDataReader reader;

        private SelectUserByPath selectUserByPath;
        private FileUserSaving fileUserSaving;
        private PathUser pathUser;
        private FindUserByLoginAndPwd findUserEntrance;
        public Form_entrance()
        {
            InitializeComponent();
        }

        private void button_entrance_Click(object sender, EventArgs e)
        {
            if (textBox_loginInput.Text != "" && textBox_pswInput.Text != "")
            {

                listUsers = new List<Users>();
                pathUser = new PathUser();

                for (int i = 0; i < Settings.Default.CounterUser; i++)
                {
                    
                    pathUser.CreateNewDirectory(FileUsersNames.DirectoryName + i.ToString());
                    pathUser.CreateNewPath(FileUsersNames.FileName + i.ToString());

                    findUserEntrance = new FindUserByLoginAndPwd(pathUser.PathFile, textBox_loginInput.Text, textBox_pswInput.Text);
                    selectUserByPath = new SelectUserByPath(pathUser.PathFile);
                    fileUserSaving = new FileUserSaving(pathUser.PathFile);

                    if (fileUserSaving.Find(findUserEntrance))
                    {
                        listUsers = fileUserSaving.Select(selectUserByPath);
                    }
                }

                if (listUsers.Count > 0)
                {
                    Person.IdUser = listUsers[0].IdUser;
                    Person.Login = listUsers[0].Login;
                    Person.Password = listUsers[0].Password;
                    Person.Email = listUsers[0].Email; 

                    Form_main.EnableMain(); 
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Ошибка в логине или пароле!", "Ошибка!");
                }

                DBConnector.Close();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!","Ошибка") ;
            }

        }



        private void label_registr_MouseMove(object sender, MouseEventArgs e)
        {
            this.label_registr.ForeColor = Color.Red;
        }

        private void label_registr_MouseLeave(object sender, EventArgs e)
        {
            this.label_registr.ForeColor = Color.Blue;
        }

        private void label_registr_Click(object sender, EventArgs e)
        {
            Form_registr fm = new Form_registr();
            fm.TopMost = true;

            IsMainClose = false;
            this.Close();

            if (this.IsDisposed)
            {
                fm.Show();
            }
        }

        private void Form_entrance_FormClosing(object sender, FormClosingEventArgs e)
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
