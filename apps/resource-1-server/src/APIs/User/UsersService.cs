using Resource_1.Infrastructure;

namespace Resource_1.APIs;

public class UsersService : UsersServiceBase
{
    public UsersService(Resource_1DbContext context)
        : base(context) { }
}
