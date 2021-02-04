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
        public ICollection<Student> Student { get; set; }

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
