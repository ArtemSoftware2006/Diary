using Diary.SQL;
using MySql.Data.MySqlClient;
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
    public partial class Form_addNote : Form
    {
        private AddNote addNote;
        private MySqlCommand cmd;
        public Form_addNote()
        {
            InitializeComponent();
        }

        private void button_addNote_Click(object sender, EventArgs e)
        {
            if (textBox_note.Text != string.Empty)
            {
                try
                {
                    DBConnector.Open();

                    addNote = new AddNote(DateTime.Now,textBox_note.Text,Person.IdUser);

                    cmd = new MySqlCommand(addNote.SqlString, DBConnector.connect);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Ваша запись ддобавлена!","Запись добавлена");
                    }

                    DBConnector.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                MessageBox.Show("Вы не ввели никакого текста!","Ошибка");
            }
        }
        private void button_reset_Click(object sender, EventArgs e)
        {
            textBox_note.Text = string.Empty;
        }

        private void button_backonMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_addNote_Load(object sender, EventArgs e)
        {
            label_dateNow.Text = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();
        }
    }
}
