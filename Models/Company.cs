using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITHSManagement.Models
{
   public class Company
    {
        public int Id { get; set; }
        public string OrganisationNumber { get; set; }
        public string Name { get; set; }
        public ICollection<LIAWork> LIAWork { get; set; }
    }
}
