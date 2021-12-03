using Microsoft.AspNetCore.Http;

namespace DEMO.Models.ViewModels
{
    public class HeroAcheivementVM
    {
        public int HeroId { get; set; }

        public string Description { get; set; }

        public IFormFile file { get; set; }

        public string photoUrl {get;set;}
    }
}
