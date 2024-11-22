using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using P3CMCS.Data;
using P3CMCS.Models;

namespace P3CMCS.Pages
{
    [Authorize(Roles = "Admin, Manager")]
    public class ReportsModel : PageModel
    {
        private readonly P3CMCSContext _context;

        public List<Claim> AcceptedClaims { get; set; }

        public ReportsModel(P3CMCSContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            AcceptedClaims = _context.Claims.Where(c => c.Status == "Accepted").ToList();
        }
    }
}