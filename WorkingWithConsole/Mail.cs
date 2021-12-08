using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithConsole
{
    public class Mail : IMail
    {
        public bool SendTo(User reciever)
        {
            return true;
        }
    }
}
