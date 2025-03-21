using System;
using System.Collections.Generic;

namespace PR4_Patners.Models;

public partial class Partner
{
    public int Id { get; set; }

    public short IdTypeOfPerther { get; set; }

    public string Name { get; set; } = null!;

    public string LegalAdress { get; set; } = null!;

    public string Inn { get; set; } = null!;

    public string FiooftheDirector { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public short Rating { get; set; }

    public virtual ICollection<HistoryOfProduct> HistoryOfProducts { get; set; } = new List<HistoryOfProduct>();

    public virtual TypesOfPartner IdTypeOfPertherNavigation { get; set; } = null!;
}
