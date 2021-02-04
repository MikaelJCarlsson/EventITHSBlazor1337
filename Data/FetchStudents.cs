using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITHSManagement.Models;

namespace ITHSManagement.Data
{
    public class FetchStudents
    {

        public Task<List<Student>> FetchS()
        {
            using(var context = new EFContext())
            {
                List<Student> results = new List<Student>();
                var query = context.Student.ToList();

                return Task.FromResult(query);
            }
            
        }
    }
}
