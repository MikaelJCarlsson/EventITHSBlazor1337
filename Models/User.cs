using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITHSManagement.Models
{
    public class User
    {
        //Klar 2020-02-02
        [Key]
        public int Id { get; set; }
        public UserTypeEnum UserType { get; set; }
        public ICollection <Programme> Programme { get; set; }
        public ICollection <Course> Course { get; set; }
        public ICollection <Group> Group { get; set; }

    }

    // Student, Admin, Teacher, CompanyEmployee

    public enum UserTypeEnum
    {
        Student,
        Teacher,
        Administrator,
        Company
    }
}
