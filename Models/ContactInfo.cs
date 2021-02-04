using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITHSManagement.Models
{
    public class ContactInfo
    {
        //Klar 2020-02-02
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ContactTypeEnum ContactType{ get; set; }
        public string Contact { get; set; }
    }
    public enum ContactTypeEnum
    {
        Email,
        Street,
        Zipcode,
        City,
        PhoneNumber
    }
}
