using System;

namespace Enemies
{
    /// <summary> Public class Zombie with Enemies. </summary>
    public class Zombie
    {
        /// <summary> Public field health </summary>
        public int health;

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
    }
}
