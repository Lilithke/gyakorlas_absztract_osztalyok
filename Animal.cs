using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace gyakorlas_absztract_osztalyok
{
    abstract class Animal
    {
        public string tipus;
        abstract public string makeSound();

        protected Animal(string tipus)
        {
            this.tipus = tipus;
        }
    }
}
