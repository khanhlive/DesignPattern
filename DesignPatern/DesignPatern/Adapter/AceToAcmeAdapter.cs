using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatern.Adapter
{
    public class AceToAcmeAdapter : IAcme
    {
        private Ace ace;
        private string firstname;
        private string lastname;
        public AceToAcmeAdapter(Ace ace)
        {
            this.ace = ace;
            this.firstname = this.ace.getName().Split(' ')[0];
            this.lastname = this.ace.getName().Split(' ')[1];
        }
        public string getFirstName()
        {
            return this.firstname;
        }

        public string getLastName()
        {
            return this.lastname;
        }

        public void setFirstName(string firstname)
        {
            this.firstname = firstname;
        }

        public void setLastName(string lastname)
        {
            this.lastname = lastname;
        }
    }
}
