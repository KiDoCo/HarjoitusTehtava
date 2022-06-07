namespace AdafyBlazorApp.Models
{
    public class Match
    {
        public int Id { get; set; }

        /// <summary>
        /// Match start date
        /// </summary>
        public DateTime MatchDate { get; set; }

        public Team HomeTeam { get; set; }

        public Team AwayTeam { get; set; }

        public int HomeGoals { get; set; }

        public int AwayGoals { get; set; }

        /// <summary>
        /// Events of the match (can be empty)
        /// </summary>
        public MatchEvents[] MatchEvents { get; set; }
    }
}
