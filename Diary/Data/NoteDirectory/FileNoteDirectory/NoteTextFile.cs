using Diary.Data.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Data.NoteDirectory.Directory
{
    public class NoteTextFile : AbstractNoteText
    {
        public string Read(string path)
        {
            return File.ReadAllText(path);
        }
        public override void Create(MyPath path,string textNote)
        {
            File.WriteAllText(path.PathFile, textNote);
        }

        public override void Delete(MyPath pathNote)
        {
            File.Delete(pathNote.PathFile);
        }

        public override void Update(MyPath path,string textNote)
        {
            File.WriteAllText(path.PathFile, textNote);
        }
    }
}
