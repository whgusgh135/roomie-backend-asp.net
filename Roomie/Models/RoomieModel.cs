using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Roomie.Models
{
    public class RoomieModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        public string LastName { get; set; }

        [Required]
        public byte MinPrice { get; set; }

        [Required]
        public byte MaxPrice { get; set; }

        [Required]
        public int PhoneNumber { get; set; }

        [Required]
        [StringLength(255)]
        public string Gender { get; set; }

        [Required]
        public int Age { get; set; }
    }
}