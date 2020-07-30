using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyGarden.Data;
using MyGarden.Models;

namespace MyGarden.Pages.Plants
{
    public class IndexModel : PageModel
    {
        private readonly MyGarden.Data.MyGardenContext _context;

        public IndexModel(MyGarden.Data.MyGardenContext context)
        {
            _context = context;
        }

        public IList<Plant> Plant { get;set; }

        public async Task OnGetAsync()
        {
            Plant = await _context.Plants.ToListAsync();
        }
    }
}
