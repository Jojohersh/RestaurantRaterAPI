using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantRaterAPI.Models
{
    public class Rating
    {
        [Key]
        public int id {get; set;}
        [Required]
        [ForeignKey("Restaurant")]
        public int RestaurantId {get; set;}
        [Required]
        public double score {get; set;}
    }
}