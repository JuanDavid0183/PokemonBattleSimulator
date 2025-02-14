namespace PokemonBattleSimulator;
using System;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using global::HelloWorld;




    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter charmender name:");
        string NickName = Console.ReadLine();
        Charmander charmander = new Charmander(NickName, "fire", "water");
        Console.WriteLine("the Pokemon his name is " + charmander.NickName + " his Strength is " + charmander.Strength + " and his weaknes is " + charmander.Weakness + "!");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(charmander.NickName);
        }
    }
}

