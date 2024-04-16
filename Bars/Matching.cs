using System;
using System.Collections.Generic;

namespace Bars;

public partial class Matching
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<Bar> Bars { get; set; } = new List<Bar>();
}
