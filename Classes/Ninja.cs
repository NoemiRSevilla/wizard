using System;
using System.Collections.Generic;
namespace wizard.Classes
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Dexterity = 175;
        }
    }
}