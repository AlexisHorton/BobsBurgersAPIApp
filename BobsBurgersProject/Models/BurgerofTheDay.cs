using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BobsBurgersProject.Models
{
    public class BurgerofTheDay
    {

        public int Id { get; set; }
        public string[] Burgers { get; set; }
        public string Price { get; set; }
        public int Season { get; set; }
        public string episodeUrl { get; set; }
    }
}
