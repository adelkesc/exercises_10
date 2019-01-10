using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.dataAccessExercises
{
    public class OrderItem
    {
        
        public int Id {get; set;}

        [Required]
        public Cat cat {get; set;}

        [Range(1, 2)]
        public int quantity {get; set;}

        public Order order {get; set;}
    }
}