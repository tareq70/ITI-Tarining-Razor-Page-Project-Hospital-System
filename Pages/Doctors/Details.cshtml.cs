﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ITI_Tarining_Razor_Page_Project_Hospital_System.Models.HospitalSystem;

namespace ITI_Tarining_Razor_Page_Project_Hospital_System.Pages.Doctors
{
    public class DetailsModel : PageModel
    {
        private readonly ITI_Tarining_Razor_Page_Project_Hospital_System.Models.HospitalSystem.HospitalContext _context;

        public DetailsModel(ITI_Tarining_Razor_Page_Project_Hospital_System.Models.HospitalSystem.HospitalContext context)
        {
            _context = context;
        }

        public Doctor Doctor { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctor = await _context.Doctors.FirstOrDefaultAsync(m => m.Id == id);
            if (doctor == null)
            {
                return NotFound();
            }
            else
            {
                Doctor = doctor;
            }
            return Page();
        }
    }
}
