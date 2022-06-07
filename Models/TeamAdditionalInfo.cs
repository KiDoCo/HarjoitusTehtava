namespace AdafyBlazorApp.Models
{
    public class TeamAdditionalInfo
    {
        public int Ranking { get; set; }
        public int GamesPlayed { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Losses { get; set; }
        public int ScoredGoals { get; set; }
        public int PassedGoals { get; set; }

        public int GoalDifference { get; set; } 

        public int Score { get; set; }
    }
}
