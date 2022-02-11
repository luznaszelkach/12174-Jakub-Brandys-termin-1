using System.ComponentModel.DataAnnotations;

namespace _12174_Jakub_Brandys_termin_1.Models
{
    public class Oceny
    {
        [Required]
        [RegularExpression("^[0 - 9]{6, 6}$")]
        public int Album { get; set; }
        [Required]
        [Range (0, 100)]
        public int Punkty { get; set; }
        public string Ocena { get; set; }

        public string Data { get; set; }
    }
}
