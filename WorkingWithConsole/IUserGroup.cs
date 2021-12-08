using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithConsole
{
    public interface IUserGroup
    {
        public bool AddUser(User newUser);
        public bool DeleteUser(User existingUser);
    }
}
