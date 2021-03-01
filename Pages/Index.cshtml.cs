using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Blog.Data;
using Blog.Models;

namespace Blog.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BlogDbContext _context;
        public IList<Post> Posts;

        public IndexModel(BlogDbContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Posts = await _context.Post.ToListAsync();
        }
    }
}
