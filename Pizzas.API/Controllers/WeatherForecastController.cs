using Microsoft.AspNetCore.Mvc;
using Tp_01_Chediex_Koifman.Models;

namespace Tp_01_Chediex_Koifman.Controllers;

[ApiController]
[Route("api/[controller]")]

public class PizzasController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll(){
        
    }
    [HttpGet("{id}")]
public IActionResult GetById(int id){

}
[HttpPost]
public IActionResult Create(Pizza pizza){

}
[HttpPut("{id}")]
public IActionResult Update(int id, Pizza pizza){

}
[HttpDelete("{id}")]
public IActionResult DeleteById(int id){

}

}
