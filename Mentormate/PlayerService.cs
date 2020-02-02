using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mentormate
{
    public class PlayerService
    {
        public List<Player> GetPlayer(List<Player> players, int years, double rating)
        {
            var currentYear = int.Parse(DateTime.Now.Year.ToString());
            var filteredPlayers = players.Where(p => (currentYear - p.PlayerSince) <= years && p.Rating >= rating).ToList();

            return filteredPlayers;
        }


    }
}
