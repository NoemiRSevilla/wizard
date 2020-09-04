using System;
using System.Collections.Generic;

namespace wizard.Classes
{
    public class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            Health = 200;
        }
    }
}