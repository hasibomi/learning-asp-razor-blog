using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Blog.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Banner { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public List<Post> Posts { get; }

        public User User { get; }

        public Post()
        {
            Created = DateTime.Now;
            Updated = Created;
        }
    }
}
