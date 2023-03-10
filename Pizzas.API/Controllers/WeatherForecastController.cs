using Microsoft.AspNetCore.Mvc;
using Pizzas.API.Models;

namespace Pizzas.Api.Controllers;

[ApiController]
[Route("api/[controller]")]

public class PizzasController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll(){
        List<Pizza> listaPizzas= BD.GetAll();
        return Ok(listaPizzas);
    }
    [HttpGet("{id}")]
public IActionResult GetById(int id){
    Pizza pizza = BD.GetById(id);
    return Ok(pizza);
}
[HttpPost]

public IActionResult CreatePizza( string nombre, string descripcion, bool libregluten, float importe ){
    BD.CreatePizza(nombre,descripcion, libregluten,  importe);
    return Ok();
}
[HttpPut("{id}")]
public IActionResult Update(int id, string nombre, string descripcion, bool libregluten, float importe){
 BD.UpdatePizza(id, nombre,descripcion, libregluten,  importe);
    return Ok();
}
[HttpDelete("{id}")]
public IActionResult DeleteById(int id){
    BD.DeletePizza(id);
    return Ok();
}

}
