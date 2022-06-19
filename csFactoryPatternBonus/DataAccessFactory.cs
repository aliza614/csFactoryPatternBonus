using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csFactoryPatternBonus
{
    public static class DataAccessFactory
    {
        /*
         Once those 3 classes have the methods implemented, you will need to fill out your factory
This shall be a public static class
        DONE
There will be one method with the following signature: 				public static IDataAccess GetDataAccessType(string databaseType)
        */
        public static IDataAccess GetDataAccessType(string databaseType)
        {
            /*
    Switch on the databaseType variable
    If a user types in “list” this should return a new instance of the ListDataAccess
    If a user types in “sql” this should return a new instance of the SQLDataAccess
    If a user types in “mongo” this should return a new instance of the MongoDataAccess*/
            switch (databaseType.ToLower())
            {
                case "list":
                    return new ListDataAccess();
                case "sql":
                    return new SQLDataAccess();
                case "mongo":
                    return new MongoDataAccess();
                default: 
                    return null;
            }
        }
    }
}
