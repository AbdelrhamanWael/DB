using System;
using System.ComponentModel.DataAnnotations;

namespace DB_Bonus.Models
{
    public class BloodDonation
    {
        [Key]
        public int DonationId { get; set; }

        [Required]
        public int DonorId { get; set; }

        [Required]
        public DateTime DonationDate { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public string BloodType { get; set; }

        public virtual Donor Donor { get; set; }
    }
} 