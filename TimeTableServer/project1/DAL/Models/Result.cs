﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Result
    {
        public int Id { get; set; }
        public int IdTeacher { get; set; }
        public int IdSubject  { get; set; }
        public int IdGrade { get; set; }
        public int IdLesson { get; set; }
    }
}
