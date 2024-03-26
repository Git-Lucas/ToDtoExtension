namespace ToDtoExtension.Entities;
public class UserEntity
{
    public int Id { get; private set; }
    public string Username { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;
    public string Password { get; private set; } = string.Empty;

    public UserEntity(int id, string username, string email, string password)
    {
        Id = id;
        Username = username;
        Email = email;
        Password = password;
    }

    public UserEntity() { }
}
