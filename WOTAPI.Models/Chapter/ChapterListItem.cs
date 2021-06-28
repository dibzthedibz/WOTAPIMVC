using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOTAPI.Models.Chapter
{
    public class ChapterListItem
        
    {
        public int ChapterId { get; set; }
        [Required]
        public int ChapNum { get; set; }
        [Required]
        public string ChapTitle { get; set; }
        [Required]
        public int PageCount { get; set; }
        public int? BookId { get; set; }
    }
}
