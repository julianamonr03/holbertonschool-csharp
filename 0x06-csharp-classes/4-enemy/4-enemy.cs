using System;

namespace Enemies
{
    /// <summary> Public class Zombie with Enemies. </summary>
    public class Zombie
    {
        /// <summary> Private field health </summary>
        private int health;

        /// <summary> Public constructor </summary>
        public Zombie()
        {
            health = 0;
        }
        /// <summary> Public constructor </summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }
        /// <summary> Private field name </summary>
        private string name = "(No name)";

        /// <summary> Public Constructor name </summary>
        public string Name
        {
            get {return name;}
            set {name = value;}
        }

        /// <summary> Public constructor Health </summary>
        public int GetHealth()
        {
            return (health);
        }
    }
}
