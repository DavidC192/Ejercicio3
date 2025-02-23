using Microsoft.AspNetCore.Mvc;

namespace Aztrowebaplication.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllusers()
    {
        return Ok("Get all users");
    }

    [HttpGet("{id}")]
    public IActionResult GetUserById(int id)
    {
        return Ok("Get user by id"+ id);
    }
    
    [HttpPost]
    public IActionResult createUser()
    {
        return Ok("User created");
    }

    [HttpPut("{id}")]
    public IActionResult UpdateUser(int id)
    {
        return Ok("Update user by id"+ id);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteUser(int id)
    {
        return Ok("Delete user by id"+ id);
    }
}
