using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantRaterAPI.Models
{
    public class RatingEdit
    {
        public int RestaurantId { get; set; }
        public double score {get; set;}
    }
}