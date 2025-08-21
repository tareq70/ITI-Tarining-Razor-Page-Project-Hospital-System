using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ITI_Tarining_Razor_Page_Project_Hospital_System.Models.HospitalSystem;

[Index("HosId", Name = "IX_Doctors_Hos_id")]
public partial class Doctor
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Qualification { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Salary { get; set; }

    [Column("Hos_id")]
    public int HosId { get; set; }

    [ForeignKey("HosId")]
    [InverseProperty("Doctors")]
    public virtual Hospital? Hos { get; set; } = null!;
}
