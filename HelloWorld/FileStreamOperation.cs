using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HelloWorld
{
    class FileStreamOperation
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"D:/DotNetProjects/textExample.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            List<PlayerClass> listPlayer = new List<PlayerClass>();

            while (!sr.EndOfStream)
            {
                string[] element = sr.ReadLine().Split(",");
                PlayerClass pc = new PlayerClass();
                pc.PlayerID = int.Parse(element[0]);
                pc.PlayerName = element[1];
                pc.PlayerRun = int.Parse(element[2]);
                listPlayer.Add(pc);
            }

            foreach (var item in listPlayer)
            {
                Console.WriteLine(item.PlayerID + " " + item.PlayerName + " " + item.PlayerRun);
            }

            fs.Close();
            sr.Close();
        }
    }

    class PlayerClass
    {
        public int PlayerID { get; set; }
        public string PlayerName  { get; set; }
        public int PlayerRun { get; set; }
    }
}
