using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WOTAPI.Models.Chapter;

namespace WOTAPI.Models.Character
{
    public class CharacterListItem
    {
        public int CharacterId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
            
        }
        public string Ability { get; set; }
        public List<ChapterListItem> Chapters { get; set; }
    }
}
