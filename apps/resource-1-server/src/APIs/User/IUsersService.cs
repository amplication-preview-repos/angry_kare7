using Resource_1.APIs.Common;
using Resource_1.APIs.Dtos;

namespace Resource_1.APIs;

public interface IUsersService
{
    /// <summary>
    /// Create one Users
    /// </summary>
    public Task<User> CreateUser(UserCreateInput user);

    /// <summary>
    /// Delete one Users
    /// </summary>
    public Task DeleteUser(UserWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Users
    /// </summary>
    public Task<List<User>> Users(UserFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Users records
    /// </summary>
    public Task<MetadataDto> UsersMeta(UserFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Users
    /// </summary>
    public Task<User> User(UserWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Users
    /// </summary>
    public Task UpdateUser(UserWhereUniqueInput uniqueId, UserUpdateInput updateDto);
}
