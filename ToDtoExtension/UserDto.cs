namespace ToDtoExtension;
public class UserDto(int id, string username, string email)
{
    public int Id { get; } = id;
    public string Username { get; } = username;
    public string Email { get; } = email;

    public override string ToString()
    {
        return $"Type: {nameof(UserDto)} | " +
               $"{nameof(Id)}: {Id} | " +
               $"{nameof(Username)}: {Username} | " +
               $"{nameof(Email)}: {Email}";
    }
}
