using System;
using System.Collections.Generic;

namespace PR4_Patners.Models;

public partial class TypesOfMaterial
{
    public short Id { get; set; }

    public string TypeOfMaterial { get; set; } = null!;

    public virtual ICollection<Material> Materials { get; set; } = new List<Material>();
}
