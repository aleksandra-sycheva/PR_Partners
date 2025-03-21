using System;
using System.Collections.Generic;

namespace PR4_Patners.Models;

public partial class HistoriOfSupplier
{
    public int Id { get; set; }

    public int IdMaterials { get; set; }

    public int IdSuppliers { get; set; }

    public short CountInPackage { get; set; }

    public short CountPackage { get; set; }

    public DateOnly DateDelivery { get; set; }

    public double CostPerPackage { get; set; }

    public short QualityDelivery { get; set; }

    public virtual Material IdMaterialsNavigation { get; set; } = null!;

    public virtual Supplier IdSuppliersNavigation { get; set; } = null!;
}
