using Diary.Data.Interfaces;
using Diary.Data.Notes;
using Diary.Data.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Data.Entity
{
    public class Note
    {
        public int Id { get; set; }
        public NotesPath PathNote { get;  set; }
        public IDateTime Date { get; set; }
        public int UserId { get; set; }
    }
}
