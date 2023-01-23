﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Data.Services
{
    abstract public class MyPath
    {
        public string PathDirectory { get; protected set; }
        public string PathFile { get; set; }
        public virtual void CreateNewPath() { }
        public virtual void CreateNewDirectory() { }
    }
}
