using Diary.Data.Directory;
using Diary.Data.Entity;
using Diary.Data.Interfaces;
using Diary.Data.NoteDirectory.Directory;
using Diary.Data.NoteDirectory.Directory.Tools;
using Diary.Data.Notes;
using Diary.Data.Services;
using Diary.Properties;
using Diary.SQL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary.Forms
{
    public partial class Form_addNote : Form
    {
        IDateTime dt = new MySqlDateTime();
        private NotePath pathNotes = new NotePath();
        private FileNoteSaving fileNoteSaving = new FileNoteSaving();
        private Note currentNote = new Note();
        private NoteTextFile fileText = new NoteTextFile();
        private NotePropertyFile fileProperty = new NotePropertyFile();
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
                    if (!Directory.Exists(Application.StartupPath + "\\Notes"))
                    {
                        Directory.CreateDirectory(Application.StartupPath + "\\Notes");
                    }

                    pathNotes.CreateNewDirectory();
                    pathNotes.CreateNewPath();

                    dt.ConvertDate(DateTime.Now);

                    currentNote.Text = textBox_note.Text;
                    currentNote.PathNote = pathNotes;
                    currentNote.Date = dt;
                    currentNote.UserId = Person.IdUser; // Тонкое место Не реализовал класс Person по всем интерфейсам

                    fileNoteSaving.CreateNote(currentNote);

                    Settings.Default.CounterNotes++;
                    Settings.Default.Save();

                    MessageBox.Show("Запись сохранена!","Успешно");

                }
                catch (Exception)
                {
                    MessageBox.Show("Ваша запись не сохранена!","Ошибка");
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
