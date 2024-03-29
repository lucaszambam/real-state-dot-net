﻿using System.ComponentModel.DataAnnotations;

namespace RealStateDotNet.Models
{
    public class City
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "is required.")]
        public string Name { get; set; }

        public string StateAcronym { get; set; }

        public State State { get; set; }
    }
}
