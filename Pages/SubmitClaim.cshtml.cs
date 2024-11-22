using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using P3CMCS.Data;
using P3CMCS.Models;
using System.Threading.Tasks;

namespace P3CMCS.Pages
{
    public class SubmitClaimModel : PageModel
    {
        private readonly P3CMCSContext _context;

        // Constructor to inject DbContext
        public SubmitClaimModel(P3CMCSContext context)
        {
            _context = context;
        }

        // Property to bind form data
        [BindProperty]
        public Claim NewClaim { get; set; }

        // OnPostAsync method to handle the form submission
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page(); // Return to the page if model is invalid
            }

            // Add new claim to the DbContext
            _context.Claims.Add(NewClaim);
            await _context.SaveChangesAsync(); // Save changes asynchronously

            // Redirect to the Privacy page where claims are displayed
            return RedirectToPage("Privacy");
        }
    }
}