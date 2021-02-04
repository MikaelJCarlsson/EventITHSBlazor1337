using ITHSManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITHSManagement.Data
{
    public class StudentQuerys
    {
        EFContext Context;

        public StudentQuerys(EFContext context)
        {
            this.Context = context;
        }

        public void AddStudent(Student student)
        {
            User user = new User();
            user.UserType = UserTypeEnum.Student;
            student.User = user;

            Context.Add(student);
            Context.SaveChanges();
        }

        public void EditUser(Student student)
        {
            var query = Context.Student
                .Find(student.UserId);
            query = student;

            Context.Update(student);
            Context.SaveChanges();
        }


        public void DeleteUser(Student student)
        {
            Console.WriteLine($"Deleting {student.UserId}");
            var query = Context.User
                .Find(student.UserId);

            Context.Remove(query);
            Context.SaveChanges();
            //OnInitializedAsync();
        }
    }
}
