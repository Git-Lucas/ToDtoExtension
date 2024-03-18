namespace ToDtoExtension;
public static class UserExtensions
{
    public static UserDto ToDto(this UserEntity userEntity)
    {
        return new UserDto(id: userEntity.Id,
                           username: userEntity.Username,
                           email: userEntity.Email);
    }
}
