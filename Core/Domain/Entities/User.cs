﻿using Domain.Enums;

namespace Domain.Entities
{
    public sealed class User : BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PictureUrl { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTimeOffset? DateOfBirth { get; set; }
        public ProfileType Profile { get; set; } = ProfileType.Admin;
    }
}
