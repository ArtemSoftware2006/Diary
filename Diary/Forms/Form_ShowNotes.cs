using Diary.Data.Directory;
using Diary.Data.Entity;
using Diary.Data.Interfaces;
using Diary.Data.Notes;
using Diary.Data.Services;
using Diary.Properties;
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
    public partial class Form_showNotes : Form
    {
        private int recordNote_Height;
        private int alsoShown;
        private const int counterNotesGroup = 5;
        private NotesRepozitory noteRep;
        private FileNoteSaving file;
        private NotePath path;
        private FileFindNotesBetween betweenNote;
        private List<Note> ListNotes;
        private Stack<Button> ListRecords_Note;

        public Form_showNotes()
        {
            InitializeComponent();
        }

        private void Form_ShowNotes_Load(object sender, EventArgs e)
        {
            recordNote_Height = (panel_recordNotes.Height * (100 / counterNotesGroup))/100 + 10;

            file = new FileNoteSaving();
            ListRecords_Note = new Stack<Button>();
            ListNotes = new List<Note>();
            path = new NotePath();
            alsoShown = 0;

            noteRep = file;

            ShowNotes();

            this.ActiveControl = groupBox_recordNote.Controls[groupBox_recordNote.Controls.Count - 1];
        }
        private void panel_recordNotes_Scroll(object sender, ScrollEventArgs e)
        {
            if (panel_recordNotes.VerticalScroll.Value >= panel_recordNotes.VerticalScroll.Maximum - panel_recordNotes.ClientRectangle.Height + 1)
            {
                ShowNotes();
            }
        }

        private void ShowNotes()
        {
            if (Settings.Default.CounterNotes - alsoShown >= 0)
            {
                betweenNote = new FileFindNotesBetween(Settings.Default.CounterNotes
                - counterNotesGroup - alsoShown - 1, Settings.Default.CounterNotes - alsoShown);

                alsoShown += counterNotesGroup;

                for (int i = alsoShown - counterNotesGroup + 1; i < alsoShown + 1; i++)
                {
                    if (Settings.Default.CounterNotes - i > 0)
                    {
                        path.CreateDirectory();
                        path.CurrentPath = path.CurrentDirectory + $"/Note{Settings.Default.CounterNotes - i}.txt";

                        if (file.Find(betweenNote, new Note() { PathNote = path }));
                        {
                            ListNotes.Add(noteRep.ReadNote(path));
                            ListRecords_Note.Push(CreateRecordNote(new Point(0, (i - 1) * recordNote_Height), ListNotes[i - 1].Text , i - 1));
                        }
                    }
                }
                AddNotesInGroupBox();
            }
        }
        private Button CreateRecordNote(Point pt, string text, int countBtn)
        {
            Button btn = new Button();

            btn.Name = countBtn.ToString();
            btn.FlatAppearance.BorderSize = 3;
            btn.FlatAppearance.BorderColor = Color.Black;
            btn.Height = recordNote_Height;
            btn.Margin = new Padding(4, 20, 4, 20);
            btn.Padding = new Padding(6);
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
            btn.Dock = DockStyle.Top;
            btn.TextAlign = ContentAlignment.TopLeft;
            btn.AutoSize = false;
            btn.Location = pt;
            btn.Text = text;
            btn.Click += new EventHandler(this.BtnNote_click);

            return btn;
        }

        private void BtnNote_click(object sender, EventArgs e)
        {
            textBox_noteText.Text = ListNotes[Convert.ToInt32((sender as Button).Name)].Text;
        }

        private void AddNotesInGroupBox()
        {
            Stack<Button> tmp = ListRecords_Note;
            foreach (var note in tmp)
            {
                panel_recordNotes.Controls.Add(note);
            }
        }

        private void button_onMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
