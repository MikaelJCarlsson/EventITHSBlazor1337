using ITHSManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITHSManagement.Data
{
    public class ProgramRepository : Repository<Program>
    {
        EFContext Context;

        public ProgramRepository(EFContext context) : base(context)
        {
            Context = context;
        }
        public Task<List<Programme>> GetAllProgrammes()
        {
            var query = Context.Programmes.ToList();

            return Task.FromResult(query);
        }
        public Task<Programme> GetProgramById(int programId)
        {
            var query = Context.Programmes
                .Find(programId);
            return Task.FromResult(query);
        }
        public void InsertProgram(Programme utbildning)
        {
            Context.Add(utbildning);
            Context.SaveChanges();
        }

        public Task<bool> AddUserToProgram(int userId, int programmeId)
        {

            var user = Context.User.Include(x => x.Programme).Where(x => x.Id == userId).First();
            var program = GetProgramById(programmeId).Result;
            user.Programme.Add(program);
            Context.SaveChanges();
            return Task.FromResult(true);
        }

        /*        public void UpdateStudent(Student student)
                {
                    var query = Context.Student
                        .Find(student.UserId);

                    student.FirstName = query.FirstName;
                    student.LastName = query.LastName;
                    student.Birthdate = query.Birthdate;

                    Context.Update(student);
                    Context.SaveChanges();
                }
                public void DeleteStudent(Student student)
                {
                    Console.WriteLine($"Deleting {student.UserId}");
                    var query = Context.User
                        .Find(student.UserId);

                    Context.Remove(query);
                    Context.SaveChanges();
                }*/
    }
}
