using System;
using System.Collections.Generic;

namespace Project_6.Models;

public partial class Manager
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? ProfileImage { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<EmpTask> EmpTasks { get; set; } = new List<EmpTask>();

    public virtual Employee? Employee { get; set; }

    public virtual ICollection<Evaluation> Evaluations { get; set; } = new List<Evaluation>();
}
