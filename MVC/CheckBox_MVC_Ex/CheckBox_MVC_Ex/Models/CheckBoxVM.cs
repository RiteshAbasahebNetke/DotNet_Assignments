﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckBox_MVC_Ex.Models
{
    public class CheckBoxVM
    {
        public Int64? Value { get; set; }
        public string Text { get; set; }
        public bool ISelected { get; set; }
    }
}