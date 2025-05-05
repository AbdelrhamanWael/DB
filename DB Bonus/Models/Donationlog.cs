using System;
using System.Collections.Generic;

namespace DB_Bonus.Models;

public partial class Donationlog
{
    public int DonationlogId { get; set; }

    public DateOnly Donation { get; set; }

    public string TakenbBloodVolume { get; set; } = null!;

    public DateOnly NextEligible { get; set; }

    public int CenterId { get; set; }

    public int DonorId { get; set; }

    public virtual DonationCenter Center { get; set; } = null!;

    public virtual Donor Donor { get; set; } = null!;
}
