using System;
using System.Collections.Generic;

namespace Sample_Postgre.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateOnly? DateOfBirth { get; set; }

    public char? Gender { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Address { get; set; }

    public DateTime? AdmissionDate { get; set; }

    public decimal? Gpa { get; set; }

    public bool? IsActive { get; set; }

    public int? CourseId { get; set; }

    public virtual Course? Course { get; set; }
}
