﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocuWPF.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
        public string Category { get; set; }
    }
}