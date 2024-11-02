using System;
using System.Collections.Generic;

namespace Question2.Models;

public partial class Subject
{
    public int Id { get; set; }

    public string Subject1 { get; set; } = null!;

    public virtual ICollection<StudentSubject> StudentSubjects { get; set; } = new List<StudentSubject>();
}
