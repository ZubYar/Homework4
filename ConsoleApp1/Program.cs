using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string myName = "Yaroslav";
            byte myAge = 27;
            bool myPet = true;
            float myShoesSize = 42;
            Console.WriteLine("Меня зовут " + myName);
            Console.WriteLine("Мне " + myAge + " лет");
            Console.WriteLine("Есть ли у меня питомец? " + myPet);
            Console.WriteLine("Мой размер ноги " + myShoesSize);
            Console.ReadKey();
        }
    }
}
