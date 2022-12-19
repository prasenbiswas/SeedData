using System.ComponentModel.DataAnnotations;

namespace SeedDataPrac1.Models
{
    public class SeedData
    {
        [Key]
        public int SeedId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }    
    }
}
