using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantRaterAPI.Models
{
    public class RestaurantEdit
    {
        public string Name { get; set; } = null!;
        public string Location { get; set; } = null!;
    }
}