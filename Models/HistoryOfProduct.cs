using System;
using System.Collections.Generic;

namespace PR4_Patners.Models;

public partial class HistoryOfProduct
{
    public int Id { get; set; }

    public int IdPartner { get; set; }

    public int IdProduct { get; set; }

    public int Count { get; set; }

    public DateOnly DateOfSale { get; set; }

    public virtual Partner Partner { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
