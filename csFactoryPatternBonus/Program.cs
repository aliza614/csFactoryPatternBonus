using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csFactoryPatternBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             In one solution, you will need to create some new types.
A class called Product with 2 properties, Name and Price
DONE
An interface called IDataAccess with 2 methods, LoadData() and SaveData()
DONE
3 classes that implement the interface and its members (the methods), ListDataAccess, SQLDataAccess, and MongoDataAccess
DONE

Last you will need to create a class called DataAccessFactory
DONE


The 3 classes that implement your IDataAccess interface should provide implementations for the 2 methods 
LoadData(): Just print to the console “I am reading data from {whatever type class this is, i.e: list, SQL database, mongo database}” and then return a new list of Product.
DONE
SaveData(): Print “I am saving data to a {whatever type} database” to the console
DONE

Once those 3 classes have the methods implemented, you will need to fill out your factory
This shall be a public static class
There will be one method with the following signature: 				public static IDataAccess GetDataAccessType(string databaseType)
Switch on the databaseType variable
If a user types in “list” this should return a new instance of the ListDataAccess
If a user types in “sql” this should return a new instance of the SQLDataAccess
If a user types in “mongo” this should return a new instance of the MongoDataAccess
            DONE*/

            //Lastly in the Main()
            //Ask the user what database they want to use: a List, SQL, or Mongo
            Console.WriteLine("Which database do you want to use: a List, SQL, or Mongo");
            //Store their response in a variable
            List<IDataAccess> l = new List<IDataAccess>();
            do
            {
                var string1 = Console.ReadLine();
                //Call your factory method and pass in what the user types and store what your factory method returns in an IDataAccess variable
                var data = DataAccessFactory.GetDataAccessType(string1);
                //Call the LoadData and SaveData methods of the IDataAccess variable
                data.LoadData();
                data.SaveData(string1);
                l.Add(data);
            } while(l.Count < 5);
//Run the program a few times using the different types.
            

        }
    }
}
