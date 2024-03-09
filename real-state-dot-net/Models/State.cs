using System.ComponentModel.DataAnnotations;

namespace RealStateDotNet.Models
{
    public class State
    {

        [Key]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "2 characters required to State Acronym.")]
        public string Acronym { get; set; }

        [Required(ErrorMessage = "is required.")]
        public string Name { get; set; }
    }
}
