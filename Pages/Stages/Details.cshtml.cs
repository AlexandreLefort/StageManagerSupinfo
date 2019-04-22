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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesStageManagerSupinfo.Models.RazorPagesStageContext _context;

        public DetailsModel(RazorPagesStageManagerSupinfo.Models.RazorPagesStageContext context)
        {
            _context = context;
        }

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
    }
}
