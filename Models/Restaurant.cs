using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantRaterAPI.Models
{
    public class Restaurant
    {
        [Key]
        public int id {get; set;}
        [Required]
        [MaxLength(100)]
        public string Name {get; set;} = null!;
        [Required]
        [MaxLength(100)]
        public string Location {get; set;} = null!;
    }
}