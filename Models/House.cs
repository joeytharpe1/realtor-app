using System.ComponentModel.DataAnnotations;

namespace houses.Models
{
    public class House
    {
        public int HouseId { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string HouseAddress { get; set; }

        [Required]
        [Display(Name = "City")]
        public string HouseCity { get; set; }

        [Required]
        [Display(Name = "State")]
        [MaxLength(2)]
        [MinLength(2)]
        public string HouseState { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        public string HouseZipCode { get; set; }

        [Required]
        [Display(Name = "Bathrooms")]
        [Range(0, 20)]
    
        public int HouseBath { get; set; }

        [Required]
        [Range(0, 20)]
        [Display(Name = "Bed Rooms")]
        public int HouseBed { get; set; }

        [Required]
        [Display(Name = "Acres ?")]
        public bool HouseIsAcres { get; set; }

        [Display(Name = "How Many Acres")]
        public int? HouseAcres { get; set; }

        [Required]
        [Display(Name = "Price Range in Thousands")]
        public string HousePriceRange { get; set; }

        [Required]
        [Display(Name = "On Market")]
        public HouseType ItemType { get; set; }
    }

    public enum HouseType
    {
        Sold,
        [Display(Name = "For Sale")]
        ForSale,
        Renting,
        [Display(Name = "For Closed")]
        ForClosures
    }


}