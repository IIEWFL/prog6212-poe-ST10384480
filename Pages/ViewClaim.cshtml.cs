using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using P3CMCS.Data;
using P3CMCS.Models;

namespace P3CMCS.Pages
{
    [Authorize]
    public class ViewClaimsModel : PageModel
    {
        private readonly P3CMCSContext _context;

        public List<Claim> Claims { get; set; }

        public ViewClaimsModel(P3CMCSContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Claims = _context.Claims.ToList();
        }
    }
}