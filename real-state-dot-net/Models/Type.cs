using System.ComponentModel.DataAnnotations;

namespace RealStateDotNet.Models
{
    public class Type
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "is required.")]
        public string Description { get; set; }
    }
}
