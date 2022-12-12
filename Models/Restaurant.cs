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
        public int id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;
        [Required]
        [MaxLength(100)]
        public string Location { get; set; } = null!;

        public virtual List<Rating> Ratings { get; set; } = new List<Rating>();
        public double averageRating
        {
            get
            {
                if (Ratings.Count == 0)
                {
                    return 0;
                }
                double total = 0.0;
                foreach (Rating rating in Ratings) {
                    total += rating.score;
                }
                return total / Ratings.Count;
            }
        }
    }
}