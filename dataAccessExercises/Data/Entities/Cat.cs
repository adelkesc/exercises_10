using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.dataAccessExercises
{
    public class Cat
    {
        public int Id {get; set;}

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string Name {get; set;}

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string Color {get; set;}

        [Required]
        [DataType(DataType.Currency)]
        [Range(0, 100)]
        public decimal Price {get; set;}

        [DataType(DataType.Date)]
        public DateTime BirthDate {get; set;}
        public string FavoriteDish {get; set;}
    }
}