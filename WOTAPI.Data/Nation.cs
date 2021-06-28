using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOTAPI.Data
{
    public class Nation
    {
        [Key]
        public int NationId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string NationName { get; set; }

        [Required]
        public string Terrain { get; set; }
        public List<Nation> Allies { get; set; }
        public List<Nation> Enemies { get; set; }
        public string Trades { get; set; }
        public virtual List<Character> Characters { get; set; }
        public virtual List<Chapter> Chapters { get; set; }
    }
}
