using System;
using System.Collections.Generic;

namespace DB_Bonus.Models;

public partial class DonationCenter
{
    public int CenterId { get; set; }

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public int Contactnumber { get; set; }

    public string OpeningHours { get; set; } = null!;

    public string Address { get; set; } = null!;

    public virtual ICollection<Bloodventory> Bloodventories { get; set; } = new List<Bloodventory>();

    public virtual ICollection<DonationRequest> DonationRequests { get; set; } = new List<DonationRequest>();

    public virtual ICollection<Donationlog> Donationlogs { get; set; } = new List<Donationlog>();

    public virtual ICollection<DonorHeaithConCern> DonorHeaithConCerns { get; set; } = new List<DonorHeaithConCern>();

    public virtual ICollection<Donor> Donors { get; set; } = new List<Donor>();

    public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();
}
