﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Data.Services
{
    abstract public class Path
    {
        public string CurrentDirectory { get; protected set; }
        public string CurrentPath { get; set; }
        public virtual void CreateNewPath() { }
        public virtual void CreateDirectory() { }
    }
}
