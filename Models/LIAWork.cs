using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITHSManagement.Models
{
    public class LIAWork
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
