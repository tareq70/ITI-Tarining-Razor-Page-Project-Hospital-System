using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ITI_Tarining_Razor_Page_Project_Hospital_System.Models.HospitalSystem;

namespace ITI_Tarining_Razor_Page_Project_Hospital_System.Pages.MedicalRecords
{
    public class EditModel : PageModel
    {
        private readonly ITI_Tarining_Razor_Page_Project_Hospital_System.Models.HospitalSystem.HospitalContext _context;

        public EditModel(ITI_Tarining_Razor_Page_Project_Hospital_System.Models.HospitalSystem.HospitalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MedicalRecord MedicalRecord { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicalrecord =  await _context.MedicalRecords.FirstOrDefaultAsync(m => m.Id == id);
            if (medicalrecord == null)
            {
                return NotFound();
            }
            MedicalRecord = medicalrecord;
           ViewData["PatId"] = new SelectList(_context.Patients, "Id", "Name");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ViewData["PatId"] = new SelectList(_context.Patients, "Id", "Name");
                return Page();
            }

            _context.Attach(MedicalRecord).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedicalRecordExists(MedicalRecord.Id))
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

        private bool MedicalRecordExists(int id)
        {
            return _context.MedicalRecords.Any(e => e.Id == id);
        }
    }
}
