using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Blog.Models
{
    public class User
    {
        public int ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
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
