using ITHSManagement.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace ITHSManagement.Data
{
    public class StudentRepository : Repository<Student>
    {

        public StudentRepository(EFContext context, UserRepository userRepository)
            : base(context)
        {
        }


        public override Task<int> Insert(Student student)
        {
            var transaction = context.Database.BeginTransaction();                   
            student.User = new User();
            student.User.UserType = UserTypeEnum.Administrator;
            var i = base.Insert(student);
            transaction.Commit();
            return i;
        }

        public void InsertContactInfo(ContactInfo ci)
        {
            context.Add(ci);
            context.SaveChanges();
        }
    }
}
