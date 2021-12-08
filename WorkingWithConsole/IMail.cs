using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithConsole
{
    public interface IMail
    {
        public bool SendTo(User reciever);
    }
}
