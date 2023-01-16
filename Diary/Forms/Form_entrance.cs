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
        private SelectPerson selectUser;
        private SelectLoginAndPsw selectloginAndPsd;
        private DataTable table;
        private MySqlDataAdapter adapter;
        private MySqlDataReader reader;
        private bool IsMainClose = true;
        public Form_entrance()
        {
            InitializeComponent();
        }

        private void button_entrance_Click(object sender, EventArgs e)
        {
            DBConnector.Open();

            if (textBox_loginInput.Text != "" && textBox_pswInput.Text != "")
            {
                DBConnector.Open();

                selectloginAndPsd = new SelectLoginAndPsw(textBox_loginInput.Text, textBox_pswInput.Text);
                cmd = new MySqlCommand(selectloginAndPsd.SqlString, DBConnector.connect);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    reader.Close();

                    selectUser = new SelectPerson(textBox_loginInput.Text);
                    table = new DataTable("Person");

                    adapter = new MySqlDataAdapter(selectUser.SqlString, DBConnector.connect);
                    adapter.Fill(table);
                   
                    Person.IdUser = Convert.ToInt32(table.Rows[0].ItemArray[0]);
                    Person.Login = table.Rows[0].ItemArray[1].ToString();
                    Person.Password = table.Rows[0].ItemArray[2].ToString();
                    Person.Email = table.Rows[0].ItemArray[3].ToString();

                    Form_main.EnableMain(); 
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Мы не нашли такого пользователя!", "Ошибка!");
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
