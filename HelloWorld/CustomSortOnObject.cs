using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Player : IComparable
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int Runs { get; set; }
        public int CompareTo(object obj)
        {

            Player player = obj as Player;
            //if (this.Runs > player.Runs)
            //    return 1;
            //else if (this.Runs < player.Runs)
            //    return -1;
            //else
            //    return 0;
            return this.Runs.CompareTo(player.Runs);
        }
    }

    class CustomSortOnObject
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();
            players.Add(new Player() { PlayerId = 10, PlayerName = "Virat", Runs = 100 });
            players.Add(new Player() { PlayerId = 11, PlayerName = "Dhoni", Runs = 90 });
            players.Add(new Player() { PlayerId = 10, PlayerName = "Laxman", Runs = 70 });


            players.Sort();
            // For sort() method to work a given object/class/type must implement IComparabel interface
            foreach (var item in players)
            {
                Console.WriteLine(item.PlayerName + " " + item.Runs);

            }
        }
    }
}
