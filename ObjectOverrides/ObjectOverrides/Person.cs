using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    //Remeber! Person extends object
    class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int  Age { get; set; }
        public string SSN { get; set; } = "";

        //Return a hash code based on a point of unique string data.
        public override int GetHashCode()
        {
            return SSN.GetHashCode();
        }

        public Person(string fName, string lName, int personAge)
        {
            FirstName = fName;
            LastName = lName;
            Age = personAge;
        }
        public Person()
        {

        }

        public override string ToString()
        {
            string myState;
            myState = string.Format("[First Name: {0}; Last Name: {1}; Age: {2}]", FirstName, LastName, Age);
            return myState;
        }

        public override bool Equals(object obj)
        {
            if (obj is Person && obj != null)
            {
                Person temp;
                temp = (Person)obj;
                if (temp.FirstName == this.FirstName && temp.LastName == this.LastName && temp.Age == this.Age)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
                
        }
    }
}
