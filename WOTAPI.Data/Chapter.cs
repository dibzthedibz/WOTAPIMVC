using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOTAPI.Data
{
    public class Chapter
    {
        [Key]
        public int ChapterId { get; set; }
        [Required]
        public int ChapNum { get; set; }
        [Required]
        public string ChapTitle { get; set; }
        [Required]
        public int PageCount { get; set; }
        [ForeignKey(nameof(Book))]
        public int? BookId { get; set; }
        public virtual Book Book { get; set; }
    }
}
