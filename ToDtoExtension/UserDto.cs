namespace ToDtoExtension;
public record UserDto(int Id, string Username, string Email)
{
    public int Id { get; } = Id;
    public string Username { get; } = Username;
    public string Email { get; } = Email;

    public override string ToString()
    {
        return $"Type: {nameof(UserDto)} | " +
               $"{nameof(Id)}: {Id} | " +
               $"{nameof(Username)}: {Username} | " +
               $"{nameof(Email)}: {Email}";
    }
}
