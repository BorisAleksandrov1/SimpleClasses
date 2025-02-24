using System.ComponentModel.Design;

namespace Games
{
    class StartUp
    {
        public static void Main()
        {
            int numOfTeams = int.Parse(Console.ReadLine());
            int counter = 0;

            string cmd = string.Empty;
            List<Squad> squads = new List<Squad>();

            while(cmd != "end" && counter != numOfTeams)
            {
                //creating a squad
                if(cmd.Contains("-"))
                {
                    string[] cmdArgs = cmd.Split('-');
                    string leader = cmdArgs[0];
                    string teamName = cmdArgs[1];

                    if(squads.Where(x => x.TeamName) == teamName)
                    {
                        Console.WriteLine("The squad name is already taken.");
                        continue;
                    }

                    squads.Add(new Squad(leader, teamName));
                }

                if(cmd.Contains('/'))
                {
                    // check if player is in team

                    string[] cmdArgs = cmd.Split('/');
                    string playerToJoin = cmdArgs[0];
                    string teamName = cmdArgs[1];

                    //find the team

                    //Add the player to the team
                }
            }
        }
    }
}