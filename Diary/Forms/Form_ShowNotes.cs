using Diary.Data.Directory;
using Diary.Data.Entity;
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
        private FileNoteSaving file;
        private Note note;
        private NotePath path;
        private FileFindNotesBetween betweenNote;
        private Button recordNote;
        public Form_ShowNotes()
        {
            InitializeComponent();
        }

        private void Form_ShowNotes_Load(object sender, EventArgs e)
        {
            betweenNote = new FileFindNotesBetween(1, 5);
            file = new FileNoteSaving();
            recordNote = new Button();
            note = new Note();
            path = new NotePath();

            CreateRecordNote();

            for (int i = Settings.Default.CounterNotes; i > 1; i--)
            {
                path.CreateDirectory();
                path.CurrentPath = path.CurrentDirectory + $"/Note{i - 1}.txt";
                note.PathNote = path;

                note = file.ReadNote(note);
                if (file.Find(betweenNote, note))
                {
                    recordNote.Location = new Point(0, (Settings.Default.CounterNotes - i) * recordNote.Height);
                    recordNote.Text = note.Date.Date.ToString();
                    Controls.Add(recordNote);
                }
            }

        }
        private void CreateRecordNote()
        {
            recordNote.Margin = new Padding(4, 10, 4, 10);
            recordNote.BackColor = Color.White;
            recordNote.ForeColor = Color.Black;
            recordNote.Dock = DockStyle.Top;
            recordNote.TextAlign = ContentAlignment.TopLeft;
            recordNote.AutoSize = true;
        }
    }
}
