using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatern.Adapter
{
    public interface IAcme
    {
        void setFirstName(string firstname);
        void setLastName(string lastname);
        string getLastName();
        string getFirstName();
    }
}
