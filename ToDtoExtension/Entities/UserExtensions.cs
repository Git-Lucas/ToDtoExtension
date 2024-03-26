using ToDtoExtension.DTOs;

namespace ToDtoExtension.Entities;
public static class UserExtensions
{
    public static UserDto ToDto(this UserEntity userEntity)
    {
        return new UserDto(Id: userEntity.Id,
                           Username: userEntity.Username,
                           Email: userEntity.Email);
    }
}
