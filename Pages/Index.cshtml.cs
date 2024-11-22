using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using P3CMCS.Data;
using P3CMCS.Models;

namespace P3CMCS.Pages
{
    public class IndexModel : PageModel
    {
        private readonly P3CMCSContext _context;

        public IndexModel(P3CMCSContext context)
        {
            _context = context;
        }

        public IList<Claim> Claims { get; set; }

        public async Task OnGetAsync()
        {
            // Replace 'Claims1' with 'Claims'
            Claims = await _context.Claims.ToListAsync();
        }
    }
}