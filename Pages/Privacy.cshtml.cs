using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using P3CMCS.Data;
using P3CMCS.Models;
using System.Collections.Generic;

namespace P3CMCS.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly P3CMCSContext _context;

        public PrivacyModel(P3CMCSContext context)
        {
            _context = context;
        }

        public IList<Claim> Claims { get; set; }

        public async Task OnGetAsync()
        {
            Claims = await _context.Claims.ToListAsync(); // Fetch all claims from the database
        }
    }
}