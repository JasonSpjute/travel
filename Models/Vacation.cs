using System.ComponentModel.DataAnnotations;

namespace travel.Models
{
    public abstract class Vacation
    {
        public int Id { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Name { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Description { get; set; }
    }
}