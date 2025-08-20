using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ITI_Tarining_Razor_Page_Project_Hospital_System.Models.HospitalSystem;
using Microsoft.EntityFrameworkCore;

namespace ITI_Tarining_Razor_Page_Project_Hospital_System.Pages.Patients
{
    public class CreateModel : PageModel
    {
        private readonly HospitalContext _context;

        public CreateModel(HospitalContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGet()
        {

            ViewData["HospitalId"] = new SelectList(_context.Hospitals, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Patient Patient { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            Console.WriteLine($"HospitalId: {Patient.HospitalId}");

            if (!ModelState.IsValid)
            {
                foreach (var entry in ModelState)
                {
                    foreach (var error in entry.Value.Errors)
                    {
                        Console.WriteLine($"{entry.Key}: {error.ErrorMessage}");
                    }
                }

                ViewData["HospitalId"] = new SelectList(_context.Hospitals, "Id", "Name");
                return Page();
            }
            _context.Patients.Add(Patient);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
