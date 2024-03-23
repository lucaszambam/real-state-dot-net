using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RealStateDotNet.Models
{
    public class Person
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "is required.")]
        [RegularExpression(@"\d{3}\.\d{3}\.\d{3}-\d{2}", ErrorMessage = "Please enter a valid CPF number in the format XXX.XXX.XXX-XX")]
        public string CPF { get; set; }

        public string Street { get; set; }

        public string Neighbourhood {  get; set; }

        [DisplayName("Address Number")]
        public string AddressNumber { get; set; }

        [DisplayName("Address Complement")]
        public string AddressComplement { get; set; }

        [RegularExpression(@"\d{2}\.\d{3}-\d{3}", ErrorMessage = "Please enter a valid CEP number in the format XX.XXX-XXX")]
        public string CEP { get; set; }

        public string Email { get; set; }

        [DisplayName("Phone Number")]
        [RegularExpression(@"\(\d{2}\)\s\d{5}-\d{4}", ErrorMessage = "Please enter a valid phone number in the format (XX) XXXXX-XXXX")]
        public string PhoneNumber { get; set; }

        public float Comission { get; set; }

        [DisplayName("Property Owner")]
        public bool IsOwner { get; set; }

        [DisplayName("Client")]
        public bool IsClient { get; set; }

        [DisplayName("Employee")]
        public bool IsEmployee { get; set; }

    }
}
