using System;
using System.Collections.Generic;

namespace DB_Bonus.Models;

public partial class Staff
{
    public int StaffId { get; set; }

    public string Name { get; set; } = null!;

    public string Role { get; set; } = null!;

    public int PhoneNumber { get; set; }

    public int CenterId { get; set; }

    public string Email { get; set; } = null!;

    public virtual DonationCenter Center { get; set; } = null!;

    public virtual ICollection<Donor> Donors { get; set; } = new List<Donor>();
}
