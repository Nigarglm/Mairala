using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Mairala.Areas.Admin.ViewModels.Project
{
    public class UpdateProjectVM
    {
        [Required(ErrorMessage = "Bu xana bos ola bilmez")]
        [MaxLength(25, ErrorMessage = "Maksimum 25 element istifade oluna biler")]
        [MinLength(4, ErrorMessage = "Minimum 4 element istifde oluna biler")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Bu xana bos ola bilmez")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Bu xana bos ola bilmez")]
        [MaxLength(100, ErrorMessage = "Maksimum 100 element istifade oluna biler")]
        public string Description { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Bu xana bos ola bilmez")]
        public IFormFile? Photo { get; set; }
    }
}
