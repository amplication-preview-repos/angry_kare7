using Microsoft.AspNetCore.Mvc;

namespace Resource_1.APIs;

[ApiController()]
public class UsersController : UsersControllerBase
{
    public UsersController(IUsersService service)
        : base(service) { }
}
