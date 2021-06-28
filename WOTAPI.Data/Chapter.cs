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
        public Guid OwnerId { get; set; }

        [Required]
        public int ChapNum { get; set; }

        [Required]
        public string ChapTitle { get; set; }

        [Required]
        public int PageCount { get; set; }
        
        [Required]
        public int? BookId { get; set; }
        [ForeignKey(nameof(BookId))]
        public virtual Book Book { get; set; }
        public int? CharacterId { get; set; }
        [ForeignKey(nameof(CharacterId))]
        public virtual Character Character { get; set; }
        public int? NationId { get; set; }
        [ForeignKey(nameof(NationId))]
        public virtual Character Nation { get; set; }
    }
}
