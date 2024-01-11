using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas_absztract_osztalyok
{
    internal class Cat : Animal
    {
        public Cat(string tipus):base(tipus) 
        { 
        }
       
        public override string makeSound()
        {
            return $"Miau Miau";
        }
    }
}
