using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesStageManagerSupinfo.Models;

namespace RazorPagesStageManagerSupinfo.Pages.Stages
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesStageManagerSupinfo.Models.RazorPagesStageContext _context;

        public DeleteModel(RazorPagesStageManagerSupinfo.Models.RazorPagesStageContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Stage Stage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Stage = await _context.Stage.FirstOrDefaultAsync(m => m.ID == id);

            if (Stage == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Stage = await _context.Stage.FindAsync(id);

            if (Stage != null)
            {
                _context.Stage.Remove(Stage);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
