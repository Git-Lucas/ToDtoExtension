namespace ToDtoExtension;
public class UserEntity(int id, string username, string email, string password)
{
    public int Id { get; } = id;
    public string Username { get; private set; } = username;
    public string Email { get; private set; } = email;
    public string Password { get; private set; } = password;
}
