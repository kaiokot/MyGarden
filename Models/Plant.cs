using System.ComponentModel.DataAnnotations;

namespace MyGarden.Models
{
    public class Plant
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]


        public int PlantType { get; set; }


        [Required]
        public int SunlightAmount { get; set; }
    }
}