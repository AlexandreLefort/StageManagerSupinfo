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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesStageManagerSupinfo.Models.RazorPagesStageContext _context;

        public IndexModel(RazorPagesStageManagerSupinfo.Models.RazorPagesStageContext context)
        {
            _context = context;
        }

        public IList<Stage> Stage { get;set; }

        public async Task OnGetAsync()
        {
            Stage = await _context.Stage.ToListAsync();
        }
    }
}
