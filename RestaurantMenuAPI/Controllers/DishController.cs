using Microsoft.AspNetCore.Mvc;
using RestaurantMenuAPI.Models;
using RestaurantMenuAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantMenuAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DishController : ControllerBase
    {
        private readonly IDishService dishService;

        public DishController(IDishService dishService)
        {
            this.dishService = dishService;
        }
        // GET: api/<DishController>
        [HttpGet]
        public ActionResult<List<Dish>> Get()
        {
            return dishService.Get();
        }

        // GET api/<DishController>/5
        [HttpGet("{id}")]
        public ActionResult<Dish> Get(string id)
        {
            var dish = dishService.Get(id);
            
            if(dish == null)
            {
                return NotFound($"Dish with Id = {id} not found");
            }

            return dish;
        }

        // POST api/<DishController>
        [HttpPost]
        public ActionResult<Dish> Post([FromBody] Dish dish)
        {
            dishService.Create(dish);

            return CreatedAtAction(nameof(Get), new { id = dish.Id }, dish);
        }

        // PUT api/<DishController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Dish dish)
        {
            var existingDish = dishService.Get(id);

            if(existingDish == null)
            {
                return NotFound($"Dish with Id = {id} not found");
            }
            dishService.Update(id, dish);

            return NoContent();
        }

        // DELETE api/<DishController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var dish = dishService.Get(id);

            if (dish == null)
            {
                return NotFound($"Dish with Id = {id} not found");
            }

            dishService.Remove(dish.Id);

            return Ok($"Dish with Id = {id} deleted");
        }
    }
}
