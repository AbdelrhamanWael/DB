using System;
using System.Collections.Generic;

namespace DB_Bonus.Models;

public partial class HealthConcer
{
    public int CenterId { get; set; }

    public string Description { get; set; } = null!;

    public virtual DonationCenter Center { get; set; } = null!;
}
