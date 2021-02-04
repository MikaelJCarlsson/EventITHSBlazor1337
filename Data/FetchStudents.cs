using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITHSManagement.Models;

namespace ITHSManagement.Data
{
    public class FetchStudents
    {
        EFContext Context;
        public FetchStudents(EFContext context)
        {
            this.Context = context;
        }

        public Task<List<Student>> FetchS()
        {
                List<Student> results = new List<Student>();
                var query = Context.Student.ToList();

                return Task.FromResult(query);
        }
    }
}
