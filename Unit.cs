using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Unit
    {
        private float _health;

        public string Name { get; }
        public float Health => _health;

        private Interval Damage { get; }
        
        public float Armor { get; }


        public Unit() : this(name: "Unknown Unit")
        { }
        public Unit(string name)
        {
            Name = name;
            Damage = new Interval(0, 10);
            Armor = 0.6f; 
        }
        public float GetRealHealth() {
            return Health * (1f + Armor);
                }
        public bool SetDamage(float value)
        {
            _health -= value * Armor;
            return _health <= 0f;
        }
    }
}
