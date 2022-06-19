using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csFactoryPatternBonus
{
    internal interface IDataAccess
    {
        //An interface called IDataAccess with 2 methods, LoadData() and SaveData()
        List <Product> LoadData();
        void SaveData( string s);
    }
}
