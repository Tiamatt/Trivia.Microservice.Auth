using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Auth.Contracts.Entities
{
    public class loginType
    {
        [Range(1, 999)]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; } // nvarchar(50) NOT NULL

        [Required]
        [StringLength(255)]
        public string description { get; set; } // nvarchar(255) NOT NULL,

        [Required]
        public bool isActive { get; set; }
    }
}