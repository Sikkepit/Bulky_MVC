using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Category name is a required field.")]
        [MaxLength(30, ErrorMessage = "The category name can not be longer than 30 characters.")]
        [DisplayName("Category Name")]
        public required string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display order must be between 1 and 100")]
        [Required]
        public int? DisplayOrder { get; set; }   
    }
}
