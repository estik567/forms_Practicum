using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace forms.Repositories.Entities;

public partial class Child
{
    public int ChildId { get; set; }

    public string ChildName { get; set; } = null!;

    public DateTime ChildDateBorn { get; set; }

    public string ChildTz { get; set; } = null!;
    [ForeignKey("UserId")]

    public int ParentId { get; set; }
}
