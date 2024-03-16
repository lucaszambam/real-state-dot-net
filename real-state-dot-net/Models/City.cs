using System.ComponentModel.DataAnnotations;

namespace RealStateDotNet.Models
{
    public class City
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "is required.")]
        public string Name { get; set; }

        [StringLength(2, MinimumLength = 2, ErrorMessage = "2 characters required to State Acronym.")]
        public string StateAcronym { get; set; }

        public State State {  get; set; }
    }
}
