﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class Group
    {
        public List<Student> Students=new List<Student>();

        public int Id { get; set; }
        public string Name { get; set; }
        public int TeacherId { get; set; }

    }
}
