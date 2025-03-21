using System;
using System.Collections.Generic;

namespace PR4_Patners.Models;

public partial class Supplier
{
    public int Id { get; set; }

    public short IdTypeOfSuppliers { get; set; }

    public string Name { get; set; } = null!;

    public string Inn { get; set; } = null!;

    public bool Active { get; set; }

    public short AvgQualityOfSuppliers { get; set; }

    public virtual ICollection<HistoriOfSupplier> HistoriOfSuppliers { get; set; } = new List<HistoriOfSupplier>();

    public virtual TypesOfSupplier IdTypeOfSuppliersNavigation { get; set; } = null!;
}
