﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOTAPI.Data
{
    public class Character
    {
        [Key]
        public int CharacterId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string FullName { get; set; }
            
        public string Ability { get; set; }
        public virtual List<Chapter> Chapters { get; set; } = new List<Chapter>();
        public int? NationId { get; set; }

        [ForeignKey(nameof(NationId))]
        public virtual Character Nation { get; set; }
    }
}
