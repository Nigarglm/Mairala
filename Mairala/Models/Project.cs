using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mairala.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }    
        public Category? Category { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        [NotMapped]
        public IFormFile? Photo { get; set; }
    }
}
