using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatern.Adapter
{
    public class Acme : IAcme
    {
        private string firstName;
        private string lastName;
        public string getFirstName()
        {
            return this.firstName;
        }

        public string getLastName()
        {
            return this.lastName;
        }

        public void setFirstName(string firstname)
        {
            this.firstName = firstname;
        }

        public void setLastName(string lastname)
        {
            this.lastName = lastname;
        }
    }
}
