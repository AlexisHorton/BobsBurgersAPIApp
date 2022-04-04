using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BobsBurgersProject.Models
{
    public class Characters
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Image { get; set; }
        public string HairColor { get; set; }
        public string Gender { get; set; }
        public string Occupation { get; set; }
        public List<string> Relatives { get; set; }
        public string FirstEpisode { get; set; }
        public string VoicedBy { get; set; }
    }
}
