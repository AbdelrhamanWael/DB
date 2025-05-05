using System;
using System.Collections.Generic;

namespace DB_Bonus.Models;

public partial class Bloodventory
{
    public int InventoryId { get; set; }

    public string Expiration { get; set; } = null!;

    public string Bloodtype { get; set; } = null!;

    public string VolumeAvailabile { get; set; } = null!;

    public int CenterId { get; set; }

    public virtual DonationCenter Center { get; set; } = null!;
}
