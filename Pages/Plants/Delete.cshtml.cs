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
    public class DeleteModel : PageModel
    {
        private readonly MyGarden.Data.MyGardenContext _context;

        public DeleteModel(MyGarden.Data.MyGardenContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Plant Plant { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Plant = await _context.Plants.FirstOrDefaultAsync(m => m.Id == id);

            if (Plant == null)
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

            Plant = await _context.Plants.FindAsync(id);

            if (Plant != null)
            {
                _context.Plants.Remove(Plant);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
