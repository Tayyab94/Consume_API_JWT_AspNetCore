using System.Collections.Generic;

namespace DEMO.Models
{
    public class Hero
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public string Password { get; set; }
        public string  DOB  { get; set; }

        public List<HeroAcheivement> Acheivements { get; set; }
    }
}
