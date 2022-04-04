using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BobsBurgersProject.Models
{
    public class Episodes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AirDate { get; set; }
        public int Season { get; set; }
        public int Episode { get; set; }
        public string TotalViewers { get; set; }
    }
}
