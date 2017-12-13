using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingletonAutoRun : DesignPaternAutoRun.IAutoRun
    {
        public void Run()
        {
            Database database;
            database = Database.GetInstance("Products");
            System.Console.WriteLine("This is the: " + database.GetName() + " database.");
            //System.Console.ReadLine();
            DatabaseThreaded databaseThreaded;
            databaseThreaded = DatabaseThreaded.GetInstance("Employees");
            System.Console.WriteLine("This is the: " + databaseThreaded.GetName() + " database.");
            System.Console.ReadLine();
        }
    }
}
