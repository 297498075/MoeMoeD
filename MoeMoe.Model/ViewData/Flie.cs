﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoeMoeD.Model.ViewData
{
    public class Flie : BaseData
    {
        public String Name { get; set; }
        public String Type { get; set; }
        public int FolderId { get; set; }
        public int UserId { get; set; }
    }
}