using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ITI_Tarining_Razor_Page_Project_Hospital_System.Models.HospitalSystem;

[Index("PatId", Name = "IX_MedicalRecords_Pat_id")]
public partial class MedicalRecord
{
    [Key]
    public int Id { get; set; }

    public DateTime DateOfExamination { get; set; }

    public string Problem { get; set; } = null!;

    [Column("Pat_id")]
    public int PatId { get; set; }

    [ForeignKey("PatId")]
    [InverseProperty("MedicalRecords")]
    public virtual Patient Pat { get; set; } = null!;
}
