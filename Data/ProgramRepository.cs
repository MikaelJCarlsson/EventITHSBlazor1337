﻿using ITHSManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITHSManagement.Data
{
    public class ProgramRepository
    {
        EFContext Context;

        public ProgramRepository(EFContext context)
        {
            this.Context = context;
        }
        public int GetProgramById(int programId)
        {
            return programId;
        }
        public void InsertProgram(StudentProgram utbildning)
        {
            Context.Add(utbildning);
            Context.SaveChanges();
        }

        public void UpdateStudent(Student student)
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
        }
    }
}
