using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITHSManagement.Models
{
    public class CompRep //Company Representitive, Tied to another company, not ITHS
    {
        [ForeignKey("User"), Key]
        public int UserId { get; set; }
        public User User { get; set; }
        [ForeignKey("Company")]
        public int CompanyId { get; set; }         //Representitive can only represent one company, as there is no many-to-many link.
        public Company Company { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthdate { get; set; }
    }
}
