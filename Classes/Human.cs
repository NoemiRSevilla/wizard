using System;
using System.Collections.Generic;
namespace wizard.Classes
{
    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        protected int Health
        {
            get { return Health; }
            set {}
        }
        public Human (string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }
        public Human (string name, int stre, int intel, int dex, int hp)
        {
            Name = name;
            Strength = stre;
            Intelligence = intel;
            Dexterity = dex;
            Health = hp;
        }
        public virtual int Attack(Human target)
        {
            int dmg = Strength * 3;
            target.Health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;
        }
        public int Attack(Human target, int dmg)
        {
            target.Health -= dmg;
            return target.Health;
        }
    }
}