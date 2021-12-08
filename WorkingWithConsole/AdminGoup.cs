using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithConsole
{
    public class AdminGroup : IUserGroup
    {

        List<User> _admins;

        public bool AddUser(User newUser)
        {
            _admins?.Add(newUser);
            return true;
        }

        public bool DeleteUser(User existingUser)
        {
            _admins?.Remove(existingUser);
            return true;
        }
    }
}
