using System;
using System.Collections.Generic;

namespace Question2.Models;

public partial class Lecturer
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public bool Male { get; set; }

    public DateOnly Dob { get; set; }

    public string Note { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
