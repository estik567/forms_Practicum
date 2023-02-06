using System;
using System.Collections.Generic;

namespace forms.Repositories.Entities;

public partial class User
{
    public int UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Tz { get; set; } = null!;

    public DateTime DateBorn { get; set; }

    public string MaleOrFemale { get; set; } = null!;

    public string Hmo { get; set; } = null!;
}
