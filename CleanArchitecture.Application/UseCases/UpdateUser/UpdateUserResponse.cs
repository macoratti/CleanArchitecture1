namespace CleanArchitecture.Application.UseCases.UpdateUser;

public sealed record UpdateUserResponse
{
    public Guid Id { get; set; }
    public string? Email { get; set; }
    public string? Name { get; set; }
}
