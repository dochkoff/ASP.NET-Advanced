using HouseRentingSystem.Infrastructure.Constants;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace HouseRentingSystem.Infrastructure.Data.Models
{
    public class Category
    {
        [Key]
        [Comment("Primary key for the category")]
        public int Id { get; set; }

        [Required]
        [MaxLength(DataConstants.CategoryNameMaxLength)]
        [Comment("Name of the category")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(DataConstants.CategoryNameMaxLength)]
        [Comment("Collection of houses in the category")]
        public IEnumerable<House> Houses { get; set; } = new List<House>();
    }
}
