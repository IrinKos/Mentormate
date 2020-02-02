using System;
using System.Collections.Generic;
using System.Text;

namespace Mentormate
{
    public abstract class PlayerBase : IPlayer
    {
        public PlayerBase(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public abstract int PlayerSince { get; protected set; }

        public abstract string Position { get; protected set; }

        public abstract double Rating { get; protected set; }

        public string GetInfo()
        {
            return 
                $"{this.Name}, " + String.Format("{0:F1}", this.Rating);
        }
    }
}
