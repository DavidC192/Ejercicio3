using Microsoft.AspNetCore.Mvc;
using Aztrowebaplication.Services;
using Aztrowebaplication.Models;
using Aztrowebaplication.Repositories;

namespace Aztrowebaplication.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly UserServices userServices;

    public UserController(ApplicationDbContext context)
    {
        userServices = new UserServices(context);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllusers()
    {
        var users = await userServices.GetAllUsers();
        return Ok(users);
    }

    [HttpGet("{id}")]
    public IActionResult GetUserById(int id)
    {
        var user = userServices.GetUserById(id);
        
        if(user == null)
        {
            return NotFound(new ErrorResponse {Message = "User not found", StatusCode = 404, Title = "Not Found"});
        }
        return Ok(user);
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
