using System.ComponentModel.DataAnnotations;
using Samaneyar.Core.Application;

namespace Samaneyar.Core.ViewModels.Shop.ProductCategory
{
    public class CreateCategoryViewModel
    {
        [Required(ErrorMessage = Validate.IsRequired)]
        [MaxLength(250,ErrorMessage = Validate.MaxLength)]
        public string Name { get; set; }

        [Required(ErrorMessage = Validate.IsRequired)]
        public string Description { get; set; }

        [Required(ErrorMessage = Validate.IsRequired)]
        [MaxLength(500, ErrorMessage = Validate.MaxLength)]
        public string Picture { get; set; }

        [Required(ErrorMessage = Validate.IsRequired)]
        [MaxLength(500, ErrorMessage = Validate.MaxLength)]
        public string PictureTitle { get; set; }

        [Required(ErrorMessage = Validate.IsRequired)]
        [MaxLength(200, ErrorMessage = Validate.MaxLength)]
        public string PictureAlt { get; set; }

        [Required(ErrorMessage = Validate.IsRequired)]
        [MaxLength(200, ErrorMessage = Validate.MaxLength)]
        public string Keywords { get; set; }

        [Required(ErrorMessage = Validate.IsRequired)]
        [MaxLength(250, ErrorMessage = Validate.MaxLength)]
        public string MetaDescription { get; set; }

        [Required(ErrorMessage = Validate.IsRequired)]
        [MaxLength(250, ErrorMessage = Validate.MaxLength)]
        public string Slug { get; set; }
    }
}