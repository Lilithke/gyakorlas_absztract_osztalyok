using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas_absztract_osztalyok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("dog");
            Cat cat = new Cat("cat");
            Console.WriteLine($"Kutya hangja: {dog.makeSound()}, Macska hangja: {cat.makeSound()}");
            Console.ReadLine();
        }
    }
}
