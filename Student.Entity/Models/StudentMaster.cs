using System;
using System.Collections.Generic;

namespace Student.Entity.Models;

public partial class StudentMaster
{
    public int StudentId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime JoinDate { get; set; }

    public int Standard { get; set; }
}
