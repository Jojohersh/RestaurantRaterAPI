using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantRaterAPI.Models;

namespace RestaurantRaterAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantController : ControllerBase
    {
        private RestaurantDbContext _context;
        public RestaurantController(RestaurantDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> PostRestaurant([FromForm] RestaurantEdit model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _context.Restaurants.Add(new Restaurant()
            {
                Name = model.Name,
                Location = model.Location
            });

            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetRestaurants()
        {
            var restaurants = await _context.Restaurants.ToListAsync();
            return Ok(restaurants);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetRestaurantById(int id)
        {
            var restaurant = await _context.Restaurants.FindAsync(id);
            if (restaurant is null) {
                return NotFound();
            }
            return Ok(restaurant);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateRestaurant(int id, RestaurantEdit model) {
            var oldrestaurant = await _context.Restaurants.FindAsync(id);
            if (oldrestaurant is null) {
                return NotFound();
            }
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }
            if (!string.IsNullOrEmpty(model.Name))
            {
                oldrestaurant.Name = model.Name;
            }
            if (!string.IsNullOrEmpty(model.Location))
            {
                oldrestaurant.Location = model.Location;
            }

            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteRestaurant(int id)
        {
            var restaurant = await _context.Restaurants.FindAsync(id);
            if (restaurant is null) {
                return NotFound();
            }

            _context.Restaurants.Remove(restaurant);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}