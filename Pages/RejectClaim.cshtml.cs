using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using P3CMCS.Data;

namespace P3CMCS.Pages
{
    [Authorize(Roles = "Admin, Manager")]
    public class RejectClaimModel : PageModel
    {
        private readonly P3CMCSContext _context;

        public RejectClaimModel(P3CMCSContext context)
        {
            _context = context;
        }

        public IActionResult OnPost(int claimId)
        {
            var claim = _context.Claims.FirstOrDefault(c => c.Id == claimId);
            if (claim != null)
            {
                claim.Status = "Rejected";
                _context.SaveChanges();
            }
            return RedirectToPage("ViewClaims");
        }
    }
}