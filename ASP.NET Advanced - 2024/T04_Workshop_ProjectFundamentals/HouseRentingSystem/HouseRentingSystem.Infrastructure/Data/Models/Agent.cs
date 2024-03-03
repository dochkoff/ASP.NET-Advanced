﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;

namespace HouseRentingSystem.Infrastructure.Data.Models
{
    public class Agent
    {
        [Key]
        [Comment("Primary key for the agent")]
        public int Id { get; set; }

        [Required]
        [MaxLength(AgentPhoneNumberMaxLength)]
        [Comment("Phone number of the agent")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        [Comment("User ID of the agent")]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        public IEnumerable<House> Houses { get; set; } = new List<House>();
    }
}
