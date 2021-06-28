using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WOTAPI.Models.Chapter;
using WOTAPI.Models.Character;

namespace WOTAPI.Models.Nation
{
    public class NationCreate
    {
        public string NationName { get; set; }
        public string Terrain { get; set; }
        public List<NationListItem> Allies { get; set; }
        public List<NationListItem> Enemies { get; set; }
        public string Trades { get; set; }
        public virtual List<CharacterListItem> Characters { get; set; }
        public virtual List<ChapterListItem> Chapters { get; set; }

    }
}
