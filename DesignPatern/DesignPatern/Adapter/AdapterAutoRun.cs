using DesignPaternAutoRun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatern.Adapter
{
    public class AdapterAutoRun : IAutoRun
    {
        public void Run()
        {
            Ace ace = new Ace();
            ace.setName("Nguyễn Khánh");
            AceToAcmeAdapter aceToAcmeAdapter = new AceToAcmeAdapter(ace);
            Console.WriteLine("Firstname: "+aceToAcmeAdapter.getFirstName());
            Console.WriteLine("Lastname: " + aceToAcmeAdapter.getLastName());
            Console.ReadLine();
        }
    }
}
