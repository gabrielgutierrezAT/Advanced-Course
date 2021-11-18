using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Course
{
    
    class Person
    {
        private string name;
        private int age;
        private bool canWalk;

        public Person(string name) {
            this.name = name;
        }

        
        public int Age{
            set {
                
                if (value is 0) {
                    throw new ArgumentException("Age Cannot be zero");
                }
                if (value < 2 || value > 89)
                    canWalk = false;
                else
                    canWalk = true;
            }
            get => age;
            
        }

        public Boolean Equal(Person param)
        {
            try
            {
                if (param.GetType() == typeof(Person))
                {
                    if (param.Age.ToString() == param.name)
                    {
                        return (true);
                    }
                }

            }
            catch (Exception e)
            {
                return (false);
            }
            return (false);
        }

    }
}
