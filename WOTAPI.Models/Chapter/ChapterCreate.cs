﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOTAPI.Models.Chapter
{
    public class ChapterCreate
    {
        public int ChapNum { get; set; }
        public string ChapTitle { get; set; }
        public int PageCount { get; set; }
        public int? BookId { get; set; }

    }
}