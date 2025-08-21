using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ITI_Tarining_Razor_Page_Project_Hospital_System.Models.HospitalSystem;

namespace ITI_Tarining_Razor_Page_Project_Hospital_System.Pages.Doctors
{
    public class CreateModel : PageModel
    {
        private readonly ITI_Tarining_Razor_Page_Project_Hospital_System.Models.HospitalSystem.HospitalContext _context;

        public CreateModel(ITI_Tarining_Razor_Page_Project_Hospital_System.Models.HospitalSystem.HospitalContext context)
        {
            _context = context;
        }
        public SelectList HospitalsList { get; set; } = default!;

        [BindProperty]
        public Doctor doctor { get; set; } = default!;

        public IActionResult OnGet()
        {
            HospitalsList = new SelectList(_context.Hospitals, "Id", "Name");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                HospitalsList = new SelectList(_context.Hospitals, "Id", "Name");
                return Page();
            }

            _context.Doctors.Add(doctor);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}
