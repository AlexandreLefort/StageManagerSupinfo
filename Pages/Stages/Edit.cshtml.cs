using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesStageManagerSupinfo.Models;

namespace RazorPagesStageManagerSupinfo.Pages.Stages
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesStageManagerSupinfo.Models.RazorPagesStageContext _context;

        public EditModel(RazorPagesStageManagerSupinfo.Models.RazorPagesStageContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Stage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StageExists(Stage.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool StageExists(int id)
        {
            return _context.Stage.Any(e => e.ID == id);
        }
    }
}
