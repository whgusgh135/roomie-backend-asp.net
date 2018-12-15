using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Roomie.Models
{
    public class FlatModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        [Required]
        [Range(1, 10)]
        public byte NumberOfRooms { get; set; }

        [Required]
        public byte PricePerPerson { get; set; }

        [Required]
        [Range(1, 10)]
        public byte MaxNumberOfPeopleAllowed { get; set; }
    }
}