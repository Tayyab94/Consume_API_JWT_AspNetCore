using System.ComponentModel.DataAnnotations.Schema;

namespace DEMO.Models
{
    public class HeroAcheivement
    {
        public int Id { get; set; }
        public string AcheivementDetail { get; set; }
        public string PhotoURL { get; set; }

        public int HeorId { get; set; }

        [ForeignKey("HeorId")]
        public Hero Hero { get; set; }
    }
}
