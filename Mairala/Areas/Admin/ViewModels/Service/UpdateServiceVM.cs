using System.ComponentModel.DataAnnotations;

namespace Mairala.Areas.Admin.ViewModels.Service
{
    public class UpdateServiceVM
    {
        [Required(ErrorMessage = "Bu xana bos ola bilmez")]
        public string IconUrl { get; set; }

        [Required(ErrorMessage = "Bu xana bos ola bilmez")]
        [MaxLength(25, ErrorMessage = "Maksimum 25 element istifade oluna biler")]
        [MinLength(4, ErrorMessage = "Minimum 4 element istifde oluna biler")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bu xana bos ola bilmez")]
        [MaxLength(100, ErrorMessage = "Maksimum 100 element istifade oluna biler")]
        public string Description { get; set; }
    }
}
}
