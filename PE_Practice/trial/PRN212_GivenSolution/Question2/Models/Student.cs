using System;
using System.Collections.Generic;

namespace Question2.Models;

public partial class Student
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public bool Male { get; set; }

    public DateOnly Dob { get; set; }

    public string Note { get; set; } = null!;

    public string? Nationality { get; set; }

    public int LectureId { get; set; }

    public virtual Lecturer Lecture { get; set; } = null!;

    public virtual ICollection<StudentSubject> StudentSubjects { get; set; } = new List<StudentSubject>();

    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();
}
