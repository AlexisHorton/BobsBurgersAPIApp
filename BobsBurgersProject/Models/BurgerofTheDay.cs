using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BobsBurgersProject.Models
{
    public class BurgerofTheDay
    {
 
            public int id { get; set; }
            public string[] burgers { get; set; }
            public string price { get; set; }
            public int season { get; set; }
            public int episode { get; set; }
            public string episodeUrl { get; set; }
            public string url { get; set; }
    }
}
