using System.Net;
using Microsoft.AspNetCore.Mvc;
using RxJS.Demo.Data;

namespace RxJS.Demo.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly ILogger<UsersController> logger;

    public UsersController(ILogger<UsersController> logger)
    {
        this.logger = logger;
    }

    [HttpGet(Name = "GetUsers")]
    public ActionResult<IEnumerable<User>> Get()
    {
        return Ok(UserData.Users);
    }

    [HttpGet("{username}", Name = "GetUser")]
    public ActionResult<User> GetUsers(string username)
    {
        var user = UserData.Users.FirstOrDefault(user =>
            user.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
        return user == null ? Problem($"User with the Username {username} could not be found", statusCode: (int)HttpStatusCode.NotFound ) : Ok(user);
    }
}