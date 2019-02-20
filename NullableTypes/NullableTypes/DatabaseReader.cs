using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class DatabaseReader
    {
        //Nullable data field.
        public int? numericValue = null;
        public bool? boolValue = true;

        //Note the nullable return type.
        public int? GetIntFromDataBase()
        {
            return numericValue;
        }

        //Note the nullable return tyep.
        public bool? GetBoolFromDatatBase()
        {
            return boolValue;
        }
    }
}
