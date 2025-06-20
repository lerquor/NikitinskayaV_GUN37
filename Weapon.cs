using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Weapon
    {
        public string Name { get; }
        private Interval Damage { get; }
        public float Durability { get; }


        public Weapon (string name)
        {
            Name = name;
        }
        public Weapon(string name, int minDamage, int maxDamage) : this(name: name) {
            SetDamageParams(minDamage, maxDamage);
                }
        public void SetDamageParams(int minDamage, int maxDamage)
        {
            if (minDamage > maxDamage)
            {
                (minDamage, maxDamage) = (maxDamage, minDamage);
                Console.WriteLine("incorrect input data: " + Name);
            }
            if (minDamage < 1)

                if (maxDamage <= 1)
                    maxDamage = 10;


        }
        public int GetDamage()
        {
            return (Damage.Min + Damage.Max) / 2;
        }
    }
}
