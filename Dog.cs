using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas_absztract_osztalyok
{
    internal class Dog : Animal
    {
        //public int leg;
        public Dog(string tipus/*,int leg*/) :base(tipus)
        {
            
            //this.leg = leg;
        }
        public override string makeSound()
        {
            return $"Vau Vau";
        }
    }
}
