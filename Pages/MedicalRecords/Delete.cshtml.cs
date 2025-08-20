using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ITI_Tarining_Razor_Page_Project_Hospital_System.Models.HospitalSystem;

namespace ITI_Tarining_Razor_Page_Project_Hospital_System.Pages.MedicalRecords
{
    public class DeleteModel : PageModel
    {
        private readonly ITI_Tarining_Razor_Page_Project_Hospital_System.Models.HospitalSystem.HospitalContext _context;

        public DeleteModel(ITI_Tarining_Razor_Page_Project_Hospital_System.Models.HospitalSystem.HospitalContext context)
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

            var medicalrecord = await _context.MedicalRecords.FirstOrDefaultAsync(m => m.Id == id);

            if (medicalrecord == null)
            {
                return NotFound();
            }
            else
            {
                MedicalRecord = medicalrecord;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicalrecord = await _context.MedicalRecords.FindAsync(id);
            if (medicalrecord != null)
            {
                MedicalRecord = medicalrecord;
                _context.MedicalRecords.Remove(MedicalRecord);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
