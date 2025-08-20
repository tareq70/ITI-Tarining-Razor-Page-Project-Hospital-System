using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ITI_Tarining_Razor_Page_Project_Hospital_System.Models.HospitalSystem;

namespace ITI_Tarining_Razor_Page_Project_Hospital_System.Pages.Hospitals
{
    public class DeleteModel : PageModel
    {
        private readonly ITI_Tarining_Razor_Page_Project_Hospital_System.Models.HospitalSystem.HospitalContext _context;

        public DeleteModel(ITI_Tarining_Razor_Page_Project_Hospital_System.Models.HospitalSystem.HospitalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Hospital Hospital { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hospital = await _context.Hospitals.FirstOrDefaultAsync(m => m.Id == id);

            if (hospital == null)
            {
                return NotFound();
            }
            else
            {
                Hospital = hospital;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hospital = await _context.Hospitals.FindAsync(id);
            if (hospital != null)
            {
                Hospital = hospital;
                _context.Hospitals.Remove(Hospital);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
