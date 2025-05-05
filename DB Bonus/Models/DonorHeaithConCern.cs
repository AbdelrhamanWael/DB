using System;
using System.Collections.Generic;

namespace DB_Bonus.Models;

public partial class DonorHeaithConCern
{
    public string Dhcid { get; set; } = null!;

    public int CenterId { get; set; }

    public int DonorId { get; set; }

    public virtual DonationCenter Center { get; set; } = null!;

    public virtual Donor Donor { get; set; } = null!;
}
