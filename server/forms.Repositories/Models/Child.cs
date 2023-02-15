using System;
using System.Collections.Generic;

namespace forms.Repositories.Models;

public partial class Child
{
    public int ChildId { get; set; }

    public string ChildName { get; set; } = null!;

    public DateTime ChildDateBorn { get; set; }

    public string ChildTz { get; set; } = null!;

    public string ParentTz { get; set; } = null!;
}
