using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Blog.Data;
using Blog.Models;

namespace Blog.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly BlogDbContext _context;
        [BindProperty]
        public new User User { get; set; }

        public RegisterModel(BlogDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (! ModelState.IsValid)
            {
                return Page();
            }

            _context.User.Add(User);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Index");
        }
    }
}
