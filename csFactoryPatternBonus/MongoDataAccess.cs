using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csFactoryPatternBonus
{
    public class MongoDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from the mongo database");
            return new List<Product>(); 
        }

        public void SaveData(string s)
        {
            Console.WriteLine("I am saving data to a mongo database");
        }
    }
}
