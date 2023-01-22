using Diary.Data.Directory;
using Diary.Data.Entity;
using Diary.Data.Interfaces;
using Diary.Data.Notes;
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
    public partial class Form_ShowNotes : Form
    {
        private NotesRepozitory noteRep;
        private FileNoteSaving file;
        private Note note;
        private NotePath path;
        private FileFindNotesBetween betweenNote;
        private List<Button> records_Note;
        private const int counterNotesGroup = 7;
        private int recordNote_Height;
        public Form_ShowNotes()
        {
            InitializeComponent();
        }

        private void Form_ShowNotes_Load(object sender, EventArgs e)
        {
            recordNote_Height = (panel_recordNotes.Height * (100 / counterNotesGroup))/100 + 10;

            betweenNote = new FileFindNotesBetween(Settings.Default.CounterNotes
                - counterNotesGroup - 1, Settings.Default.CounterNotes);
            file = new FileNoteSaving();
            records_Note = new List<Button>();
            note = new Note();
            path = new NotePath();

            noteRep = file;

            for (int i = 1; i < counterNotesGroup + 1; i++)
            {
                if (Settings.Default.CounterNotes - i > 0)
                {
                    path.CreateDirectory();
                    path.CurrentPath = path.CurrentDirectory + $"/Note{Settings.Default.CounterNotes - i}.txt";
                    note.PathNote = path;

                    note = noteRep.ReadNote(note.PathNote);
                    if (file.Find(betweenNote, note))
                    {
                        records_Note.Add(CreateRecordNote(new Point(0, (i - 1) * recordNote_Height), note.Text));
                    }
                }
            }
            records_Note.Reverse();
            records_Note.ForEach(x => panel_recordNotes.Controls.Add(x)) ;
        }
        private Button CreateRecordNote(Point pt, string text)
        {
            Button btn = new Button();

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

            return btn;
        }
    }
}
