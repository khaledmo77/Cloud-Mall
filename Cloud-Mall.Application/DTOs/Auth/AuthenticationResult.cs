﻿namespace Cloud_Mall.Application.DTOs.Auth
{
    public class AuthenticationResult
    {
        public string Token { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public IList<string> Roles { get; set; } = null!;
    }
}
