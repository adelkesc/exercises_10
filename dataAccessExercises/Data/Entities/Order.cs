using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.dataAccessExercises
{
    public class Order
    {
        public int Id {get; set;}

        [DataType(DataType.Date)]
        public DateTime OrderDate {get; set;}

        [Required]
        public string OrderNumber {get; set;}
        
        public ICollection<OrderItem> Items {get; set;}
    }
}