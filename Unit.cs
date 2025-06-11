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
        private float _armor;
        public string Name { get; }
        public float Health => _health;

        public int Damage { get; }
        
        public float Armor { 
            get { return (float)_armor; } 
            set { if  ((value >= 0) && (value <= 1))
                    _armor = value;
            }
        }
        

        public Unit() : this(name: "Unknown Unit")
            { }
        public Unit(string name)
        {
            Name = name;
            Damage = 5;
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
