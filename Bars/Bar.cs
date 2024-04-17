using System;
using System.Collections.Generic;

namespace Bars;

public partial class Bar
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? Mark { get; set; }

    public byte[]? Photo { get; set; }

    public int? Matching { get; set; }

    public string? Characters { get; set; }

    public string? Location { get; set; }

    public string? Cuisine { get; set; }
    public string? Type { get; set; }

    public virtual Matching? MatchingNavigation { get; set; }
}
