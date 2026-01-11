using Microsoft.AspNetCore.Mvc;
using Resource_1.APIs.Common;
using Resource_1.Infrastructure.Models;

namespace Resource_1.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class UserFindManyArgs : FindManyInput<User, UserWhereInput> { }
