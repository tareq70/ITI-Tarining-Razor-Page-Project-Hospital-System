using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ITI_Tarining_Razor_Page_Project_Hospital_System.Models.HospitalSystem;

[Index("HospitalId", Name = "IX_Patients_Hospital_id")]
public partial class Patient
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Diagnosis { get; set; } = null!;

    public string Address { get; set; } = null!;

    [Column("Hospital_id")]
    public int HospitalId { get; set; }

    [ForeignKey("HospitalId")]
    [InverseProperty("Patients")]
    public virtual Hospital? Hospital { get; set; } = null!;

    [InverseProperty("Pat")]
    public virtual ICollection<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();
}
