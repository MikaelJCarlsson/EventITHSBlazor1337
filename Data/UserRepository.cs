using ITHSManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITHSManagement.Data
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(EFContext context): base(context)
        { }
    }
}
