using System;
using System.Collections.Generic;

namespace PR4_Patners.Models;

public partial class Material
{
    public int Id { get; set; }

    public short IdTypeOfMaterials { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? Image { get; set; }

    public virtual ICollection<HistoriOfSupplier> HistoriOfSuppliers { get; set; } = new List<HistoriOfSupplier>();

    public virtual TypesOfMaterial IdTypeOfMaterialsNavigation { get; set; } = null!;
}
