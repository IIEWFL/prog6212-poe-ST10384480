using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using P3CMCS.Models; // Add this reference
using P3CMCS.Data;
using System.Collections.Generic;
using System.Linq;

namespace P3CMCS.Pages
{
    public class GenerateReportModel : PageModel
    {
        private readonly P3CMCSContext _context;

        public GenerateReportModel(P3CMCSContext context)
        {
            _context = context;
        }

        public IList<Claim> Claims { get; set; }

        public void OnGet()
        {
            // Get all claims for the report
            Claims = _context.Claims.ToList();
        }
    }
}