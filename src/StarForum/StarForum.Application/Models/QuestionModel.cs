﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarForum.Application.Models
{
    public class QuestionModel
    {
        public int Id{ get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string[] Tags { get; set; }
        public DateTime CreatedDate { get; set; }
        public string AuthorName { get; set; }
    }
}
