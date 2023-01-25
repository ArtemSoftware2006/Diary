using Diary.Data.Directory;
using Diary.Data.Entity;
using Diary.Data.NoteDirectory.Directory;
using Diary.Data.NoteDirectory.Directory.Tools;
using Diary.Data.Notes;
using Diary.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Diary.Forms
{
    public partial class Form_showNotes : Form
    {
        private int recordNote_Height;
        private int alsoShown;
        private const int counterNotesGroup = 5;
        private NoteTextFile noteTextFile;
        private NotePropertyFile notePropertyFile;
        private NotePath pathProperty;
        private NotePath pathText;
        private FileFindNotesBetween betweenNote;
        private SelectNoteByID findNoteByID;
        private List<Note> ListNotes;
        private List<Button> ListRecords_Note;


        public Form_showNotes()
        {
            InitializeComponent();

            noteTextFile = new NoteTextFile();
            notePropertyFile = new NotePropertyFile();
            pathProperty = new NotePath();
            ListNotes = new List<Note>();
            ListRecords_Note = new List<Button>();
            pathText = new NotePath();
            alsoShown = 0;
        }

        private void Form_ShowNotes_Load(object sender, EventArgs e)
        {
            recordNote_Height = (panel_recordNotes.Height * (100 / counterNotesGroup)) / 100 + 10;

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
                for (int i = Settings.Default.CounterNotes - alsoShown - 1, countNote = alsoShown; (i >= Settings.Default.CounterNotes - alsoShown - counterNotesGroup) && (i >= 0); i--, countNote++)
                {
                    pathText.CreateNewDirectory(FileNoteNames.DirectoryName + i.ToString());
                    pathText.CreateNewPath(FileNoteNames.FileTextName + i.ToString() + ".txt");
                    pathProperty.CreateNewDirectory(FileNoteNames.DirectoryName + i.ToString());
                    pathProperty.CreateNewPath(FileNoteNames.FilePropertyName + i.ToString() + ".txt");


                    findNoteByID = new SelectNoteByID(pathProperty.PathFile, i);

                    betweenNote = new FileFindNotesBetween(Settings.Default.CounterNotes
                         - counterNotesGroup - alsoShown, Settings.Default.CounterNotes - alsoShown - 1, pathProperty.PathFile);

                    if (notePropertyFile.Find(betweenNote))
                    {
                        findNoteByID.Select().ForEach(x => ListNotes.Add(x));
                        ListRecords_Note.Add(CreateRecordNote(ListNotes[countNote].Date.Date, countNote));
                    }
                }
                alsoShown += counterNotesGroup;
                AddNotesInGroupBox();
            }
        }
        private Button CreateRecordNote(/*Point pt*/ string text, int countBtn)
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
            btn.Text = text;
            btn.Click += new EventHandler(this.BtnNote_click);

            return btn;
        }

        private void BtnNote_click(object sender, EventArgs e)
        {
            textBox_noteText.Text = noteTextFile.Read(ListNotes[Convert.ToInt32((sender as Button).Name)].PathNote);
        }

        private void AddNotesInGroupBox()
        {
            ListRecords_Note.Reverse();
            foreach (var item in ListRecords_Note)
            {
                panel_recordNotes.Controls.Add(item);
            }
            ListRecords_Note.Reverse();
        }

        private void button_onMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
