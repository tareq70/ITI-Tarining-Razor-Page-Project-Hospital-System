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
    public class IndexModel : PageModel
    {
        private readonly ITI_Tarining_Razor_Page_Project_Hospital_System.Models.HospitalSystem.HospitalContext _context;

        public IndexModel(ITI_Tarining_Razor_Page_Project_Hospital_System.Models.HospitalSystem.HospitalContext context)
        {
            _context = context;
        }

        public IList<MedicalRecord> MedicalRecord { get;set; } = default!;

        public async Task OnGetAsync()
        {
            MedicalRecord = await _context.MedicalRecords
                .Include(m => m.Pat).ToListAsync();
        }
    }
}
