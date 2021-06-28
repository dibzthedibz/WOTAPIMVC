using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOTAPI.Data
{
    public class Nation
    {
        public int NationId { get; set; }
        public string NationName { get; set; }
        public string Terrain { get; set; }
        public List<Nation> Allies { get; set; }
        public List<Nation> Enemies { get; set; }
        public List<string> Trades { get; set; }
        public virtual List<Character> Characters { get; set; }
        public virtual List<Chapter> Chapters { get; set; }
    }
}
