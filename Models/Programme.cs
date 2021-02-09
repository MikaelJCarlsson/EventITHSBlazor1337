using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITHSManagement.Models
{
    public class Programme
    {

        public int Id { get; set; }
        public string ProgramName { get; set; }
        public string YhNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public string CourseAdmin { get; set; }
        public ICollection <User> Members { get; set; }
        public ICollection <Course> Courses { get; set; }
    }
}
