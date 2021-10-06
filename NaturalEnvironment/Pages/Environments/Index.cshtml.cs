using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NaturalEnvironment.Models;

namespace NaturalEnvironment.Pages_Environments
{
    public class IndexModel : PageModel
    {
        private readonly NaturalEnvironmentContext _context;

        public IndexModel(NaturalEnvironmentContext context)
        {
            _context = context;
        }

        public IList<Environment> Environment { get;set; }

        public async Task OnGetAsync()
        {
            Environment = await _context.Environment.ToListAsync();
        }
    }
}
