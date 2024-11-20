using System;
using System.ComponentModel.DataAnnotations;

namespace FestivalCarthage.Models
{
    public class Concert
    {
        public int Id { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
        public string Artiste { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateConcert { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public TimeSpan HeureConcert { get; set; }

        [Required]
        public string Lieu { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Prix { get; set; }
    }
}