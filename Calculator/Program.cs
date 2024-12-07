using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First program how to do variables
                string characterName = "";
                int characterDicks;
                characterDicks = 35;

                characterName = "John";
                Console.WriteLine("There was a dick named " + characterName);
                Console.WriteLine("He had " + characterDicks + " dicks in his mounth");
                characterName = "Nick";
                Console.WriteLine("He really Liked the name " + characterName);
                Console.WriteLine("But he didnt like having " + characterDicks + " dicks in his mounth");

                Console.ReadLine();

        }
    }
}
