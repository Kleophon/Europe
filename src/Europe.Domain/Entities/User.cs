    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.AspNetCore.Identity;

    namespace Europe.Domain.Entities
    {
        public class User : IdentityUser<Guid>
        {
            public string? ProfilePictureUrl { get; set; }
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
            public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        }
    }
