using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Data.Services
{
    abstract public class Path
    {
        public string CurrentPath { get; protected set; }
        public virtual void CreatePath() { }
    }
}
