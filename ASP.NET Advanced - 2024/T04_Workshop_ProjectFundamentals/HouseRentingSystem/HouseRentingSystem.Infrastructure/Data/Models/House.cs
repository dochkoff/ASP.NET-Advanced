using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;

namespace HouseRentingSystem.Infrastructure.Data.Models
{
    public class House
    {
        [Key]
        [Comment("Primary key for the house")]
        public int Id { get; set; }

        [Required]
        [MaxLength(HouseTitleMaxLength)]
        [Comment("Title of the house")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(HouseAddressMaxLength)]
        [Comment("Address of the house")]
        public string Address { get; set; } = string.Empty;

        [Required]
        [MaxLength(HouseDescriptionMaxLength)]
        [Comment("Description of the house")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Comment("House image URL")]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        //[Range(typeof(decimal), HouseRentingPariceMinValue, HouseRentingPariceMaxValue, ConvertValueInInvariantCulture = true)]
        [Comment("Price per month for the house")]
        public decimal PricePerMonth { get; set; }

        [Required]
        [Comment("Category ID of the house")]
        public int CategoryId { get; set; }

        [Required]
        [Comment("Agent ID of the house")]
        public int AgentId { get; set; }

        [Comment("User ID of the renter")]
        public string? RenterId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [ForeignKey(nameof(AgentId))]
        public Agent Agent { get; set; } = null!;

    }
}
