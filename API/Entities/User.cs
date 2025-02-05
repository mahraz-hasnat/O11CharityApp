namespace API.Entities;

public class User
{
    public int Id { get; set; }
    public required string Username { get; set; }
    public required string MobileNo { get; set; }
    public string? Email { get; set; }
    public required byte[] PasswordHash { get; set; }
    public required byte[] PasswordSalt { get; set; }
}
