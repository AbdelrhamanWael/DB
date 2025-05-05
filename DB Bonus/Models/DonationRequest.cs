using System;
using System.Collections.Generic;

namespace DB_Bonus.Models;

public partial class DonationRequest
{
    public int RequestingCenterId { get; set; }

    public string Bloodtybe { get; set; } = null!;

    public string Urgencylevel { get; set; } = null!;

    public DateOnly Requsted { get; set; }

    public int CenterId { get; set; }

    public virtual DonationCenter Center { get; set; } = null!;
}
