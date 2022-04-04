using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BobsBurgersProject.Models
{
    public class BobBAPI
    {
        private static HttpClient _realClient = null;
        public static HttpClient MyHttp
        {
            get
            {
                if (_realClient == null)
                {
                    _realClient = new HttpClient();
                    _realClient.BaseAddress = new Uri("https://bobsburgers-api.herokuapp.com/"); 
                }
                return _realClient;
            }
        }

        public static async Task<Characters> GetCharacters()
        {
            var connection = await MyHttp.GetAsync("characters");
            Characters all = await connection.Content.ReadAsAsync<Characters>();
            BBDatabase.AddtoCharacterDb(all);
            return null;
        }
    }
    public class BobsBContext : DbContext
    {
        public DbSet<Characters> Characters { get; set; }
        public DbSet<Episodes> Episodes { get; set; }
        public DbSet<BurgerofTheDay> BurgerofTheDays { get; set; }
        public DbSet<StoreNextDoor> StoreNextDoors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=BobsBurgers;Integrated Security=SSPI;");
            // Or For username/password, use the following:
            // optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=efconsole1;User Id=sa;Password=abc123;");
        }
    }

    public class BBDatabase
    {
        public static bool AddtoCharacterDb( Characters character)
        {
            using(BobsBContext bctx = new BobsBContext())
            {
                List<Characters> allcharacters = bctx.Characters.Where(c => c.Id == character.Id).ToList();
                if (allcharacters.Count > 0)
                {
                    return false;
                }
                Characters newchar = new Characters();
                newchar.Id = character.Id;
                newchar.Image = character.Image;
                newchar.Name = character.Name;
                newchar.Age = character.Age;
                newchar.HairColor = character.HairColor;
                newchar.Gender = character.Gender;
                newchar.Occupation = character.Occupation;
                newchar.Relatives = character.Relatives;
                newchar.FirstEpisode = character.FirstEpisode;
                newchar.VoicedBy = character.VoicedBy;

                bctx.Characters.Add(newchar);
                bctx.SaveChanges();
            }
            return true;
        }
    }
}
