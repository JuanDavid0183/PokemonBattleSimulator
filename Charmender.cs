//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PokemonBattleSimulator
//{
//    internal class Charmender
//    {
//    }
//}


//public class Charmender
using System;

namespace HelloWorld
{
    public class Charmander
    {
        public string NickName { get; set; }
        public string Strength = "fire";
        public string Weakness = "water";

        public Charmander(string NickName, string strength, string weakness)
        {
            this.NickName = NickName;
            this.Strength = strength;
            this.Weakness = weakness;
        }

    }

}

