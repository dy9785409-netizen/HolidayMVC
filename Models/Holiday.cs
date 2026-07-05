using System.ComponentModel.DataAnnotations;

namespace HolidayApp.Models
{
    public class Holiday
    {
        public int Id { get; set; }

        [Required]
        public string EnglishName { get; set; }

        [Required]
        public string ArabicName { get; set; }

        [Required]
        public DateTime? FromDate { get; set; }

        [Required]
        public DateTime? ToDate { get; set; }
    }
}