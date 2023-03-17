using Microsoft.AspNetCore.Mvc;
using Pizzas.API.Models;

namespace Pizzas.Api.Controllers;

[ApiController]
[Route("api/[controller]")]

public class PizzasController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        List<Pizza> listaPizzas = BD.GetAll();
        return Ok(listaPizzas);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        
        if (id<1)
        {
            return BadRequest();
        }
        Pizza pizza = BD.GetById(id);
        if (pizza == null)
        {
            return NotFound();
        }
        else
        {
            return Ok(pizza);
        }
        
    }

    [HttpPost]
    public IActionResult CreatePizza(Pizza  pizza)
    {

        
        
        BD.CreatePizza(pizza);
        return Ok();
    }
    [HttpPut("{id}")]
    public IActionResult Update(int id, Pizza pizza)
    {
        if (id != pizza.Id)
        {
            return BadRequest();
        }
        if(BD.GetById(id) == null)
        {
            return NotFound();
        }

        BD.UpdatePizza(id, pizza);
        return Ok();
    }
    [HttpDelete("{id}")]
    public IActionResult DeleteById(int id)
    {
        if (id < 1)
        {
            return BadRequest();
        }
        else if(BD.GetById(id)== null)
        {
            return NotFound();
        }
        BD.DeletePizza(id);
        return Ok();
    }

}
