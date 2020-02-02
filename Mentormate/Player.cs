using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Mentormate
{
    public class Player : IPlayer
    {
        public Player(string name, int playerSince, string position, double rating)
        {
            this.Name = name;
            this.PlayerSince = playerSince;
            this.Position = position;
            this.Rating = rating;
        }
        public string Name { get; set; }
        public int PlayerSince { get; protected set; }
        public string Position { get; protected set; }
        public double Rating { get; protected set; }

        public override string ToString()
        {
            return
                $"{this.Name}, " + String.Format("{0:F1}", this.Rating) + $"{Environment.NewLine}";
        }
    }
}
