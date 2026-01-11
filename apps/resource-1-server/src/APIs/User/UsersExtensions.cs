using Resource_1.APIs.Dtos;
using Resource_1.Infrastructure.Models;

namespace Resource_1.APIs.Extensions;

public static class UsersExtensions
{
    public static User ToDto(this UserDbModel model)
    {
        return new User
        {
            CreatedAt = model.CreatedAt,
            Email = model.Email,
            EmailVerified = model.EmailVerified,
            FullName = model.FullName,
            Id = model.Id,
            PhoneNumber = model.PhoneNumber,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static UserDbModel ToModel(this UserUpdateInput updateDto, UserWhereUniqueInput uniqueId)
    {
        var user = new UserDbModel
        {
            Id = uniqueId.Id,
            Email = updateDto.Email,
            EmailVerified = updateDto.EmailVerified,
            FullName = updateDto.FullName,
            PhoneNumber = updateDto.PhoneNumber
        };

        if (updateDto.CreatedAt != null)
        {
            user.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            user.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return user;
    }
}
