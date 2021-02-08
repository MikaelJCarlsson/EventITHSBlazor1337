using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITHSManagement.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<User> Members { get; set; }
    }
}
