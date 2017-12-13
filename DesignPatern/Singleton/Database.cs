using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Mẫu duy nhất
/// </summary>
namespace Singleton
{
    public class Database
    {
        private static Database objectDatabase;
        private int record;
        private string name;
        public Database(string name)
        {
            this.name = name;
            this.record = 0;
        }
        public static Database GetInstance(string name)
        {
            if (objectDatabase==null)
            {
                objectDatabase = new Database(name);
            }
            return objectDatabase;
        }
        public string GetName()
        {
            return this.name;
        }
    }


    /// <summary>
    /// apply to multi thread
    /// </summary>
    public class DatabaseThreaded
    {
        private static DatabaseThreaded objectDatabase = new DatabaseThreaded("products");
        private int record;
        private string name;
        public DatabaseThreaded(string name)
        {
            this.name = name;
            this.record = 0;
        }
        public static DatabaseThreaded GetInstance(string name)
        {
            return objectDatabase;
        }
        public string GetName()
        {
            return "Multi Thread: "+this.name;
        }
    }
}
