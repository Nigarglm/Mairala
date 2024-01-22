using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Mairala.Areas.Admin.ViewModels.Employee
{
    public class UpdateEmployeeVM
    {
        [Required(ErrorMessage = "Bu xana bos ola bilmez")]
        [MaxLength(25, ErrorMessage = "Maksimum 25 element istifade oluna biler")]
        [MinLength(4, ErrorMessage = "Minimum 4 element istifde oluna biler")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bu xana bos ola bilmez")]
        [MaxLength(25, ErrorMessage = "Maksimum 25 element istifade oluna biler")]
        [MinLength(4, ErrorMessage = "Minimum 4 element istifde oluna biler")]
        public string Surname { get; set; }
        [Required]
        public int PositionId { get; set; }
        [Required]
        [NotMapped]
        public IFormFile? Photo { get; set; }
    }
}
