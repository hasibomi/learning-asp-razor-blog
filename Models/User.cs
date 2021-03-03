using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Blog.Models
{
    public class User : IdentityUser<Guid>
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public List<Post> Posts { get; }

        public User()
        {
            Created = DateTime.Now;
            Updated = Created;
        }
    }
}
