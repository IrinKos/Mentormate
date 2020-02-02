using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Mentormate
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string json = File.ReadAllText(input); 
            int years = int.Parse(Console.ReadLine());
            double rating = double.Parse(Console.ReadLine());
            var output = Console.ReadLine();


            var players = JsonConvert.DeserializeObject<List<Player>>(json);

            var service = new PlayerService();
            var filteredPlayers = service.GetPlayer(players, years, rating);

            using (var file = File.CreateText(output))
            {
                file.WriteLine("Name, Rating");
                foreach (var filteredPlayer in filteredPlayers)
                {   
                    file.Write(filteredPlayer);
                }
            }
        }
    }
}
