﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmazon.Shared.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set;}

        [Required][StringLength(50)]
        public string Title { get; set; }

        [Required]
        public string Land { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string HouseNumber { get; set; }

        [Required]
        public string PostalCode { get; set; }

        [Required][EmailAddress]
        public string Email { get; set; }

        [StringLength(400)]
        public string? Notes { get; set; }

        // (n:m) Relationship
        public virtual ICollection<Book>? Books { get; set; } 
        
        public virtual ICollection<SupplyOrder>? SupplyOrders { get; set; }
    }
}
