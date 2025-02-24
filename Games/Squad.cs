namespace Games
{
    public class Squad
    {
        private string leaderName;
        private string teamName;
        public string LeaderName { get; set; }
        public string TeamName { get; set; }
        public List<string> Teammates = new List<string>();

        public Squad(string leader, string team)
        {
            this.LeaderName = leader;
            this.TeamName = team;
            AddPlayer(LeaderName);
        }

        public void AddPlayer(string name)
        {
            Teammates.Add(name);
        }
    }
}