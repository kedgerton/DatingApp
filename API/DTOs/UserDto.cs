using System;

namespace API.DTOs;

public class UserDto
{
    
    public required string Id { get; set; }

    public required string Email { get; set; }

    public required string DisplayName { get; set; }

    //  ? here means that is information= is optional
    public string? ImageUrl { get; set; }

    public required string Token { get; set; }
}
