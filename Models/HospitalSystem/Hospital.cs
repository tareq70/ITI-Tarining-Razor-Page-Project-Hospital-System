using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ITI_Tarining_Razor_Page_Project_Hospital_System.Models.HospitalSystem;

public partial class Hospital
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string City { get; set; } = null!;

    [InverseProperty("Hos")]
    public virtual ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();

    [InverseProperty("Hospital")]
    public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
}
