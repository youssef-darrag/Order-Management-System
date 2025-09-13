﻿using System.ComponentModel.DataAnnotations;

namespace OrderManagementSystem.Core.DTOs.Auth
{
    public class RegisterDto
    {
        [MaxLength(50)]
        public string FirstName { get; set; } = default!;

        [MaxLength(50)]
        public string LastName { get; set; } = default!;

        [MaxLength(50)]
        public string UserName { get; set; } = default!;

        [MaxLength(128)]
        public string Email { get; set; } = default!;

        [MaxLength(256)]
        public string Password { get; set; } = default!;
    }
}
