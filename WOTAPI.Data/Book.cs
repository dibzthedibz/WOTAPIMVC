using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOTAPI.Data
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int PageCount { get; set; }
        public List<Chapter> Chapters { get; set; } = new List<Chapter>();
        public List<Character> Characters { get; set; } = new List<Character>();
    }
}
