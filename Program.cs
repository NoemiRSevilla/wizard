using System;

namespace wizard.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Human nibbles = new Human("Mr. Nibbles");
            Wizard benny = new Wizard("Benny Bob");
            benny.Attack(nibbles);
        }
    }
}
