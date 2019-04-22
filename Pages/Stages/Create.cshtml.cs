using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesStageManagerSupinfo.Models;

namespace RazorPagesStageManagerSupinfo.Pages.Stages
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesStageManagerSupinfo.Models.RazorPagesStageContext _context;

        public CreateModel(RazorPagesStageManagerSupinfo.Models.RazorPagesStageContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Stage Stage { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Stage.Add(Stage);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}