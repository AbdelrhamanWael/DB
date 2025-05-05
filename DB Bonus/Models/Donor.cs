using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DB_Bonus.Models
{
    public class Donor
    {
        [Key]
        public int DonorId { get; set; }

        [Required]
        [StringLength(100)]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string? LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [StringLength(10)]
        public string? Gender { get; set; }


        [Required]
        
        public int? NationaiID { get; set; }

        [Required]
        [StringLength(20)]
        public string? BloodType { get; set; }

        [Required]
        [StringLength(15)]
        public string? PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        [StringLength(50)]
        public string? HealthStatus { get; set; }

        [Required]
        public int Height { get; set; }



        [Required]
        [StringLength(200)]
        public string? Address { get; set; }


        [StringLength(200)]
        public string? Notes { get; set; }

        public bool IsEligible { get; set; }

        public DateTime? LastDonationDate { get; set; }

        public virtual ICollection<BloodDonation> Donations { get; set; } = new List<BloodDonation>();
    }
}