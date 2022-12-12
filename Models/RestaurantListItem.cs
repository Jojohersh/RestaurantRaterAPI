using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantRaterAPI.Models
{
    public class RestaurantListItem
    {
        public int Id {get;set;}
        public string Name { get; set; } = null!;
        public string Location {get; set;} = null!;
        public double averageRating {get; set;}

    }
}