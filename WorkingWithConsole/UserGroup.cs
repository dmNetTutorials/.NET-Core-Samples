using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithConsole
{
    public class UserGroup : IUserGroup
    {
        List<User> _users;

        public bool AddUser(User newUser)
        {
            _users?.Add(newUser);
            return true;
        }

        public bool DeleteUser(User existingUser)
        {
            _users?.Remove(existingUser);
            return true;
        }
    }
}
