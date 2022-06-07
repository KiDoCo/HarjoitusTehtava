using AdafyBlazorApp.Models;

namespace AdafyBlazorApp
{
    public static class Utils
    {
        public static string ReplaceUrlProtocolToSecure(this string url)
        {
            return url.Replace("http", "https");
        }

        public static Task CalculateMatchResults(Match match,List<Team> teamList)
        {
            var awayTeamIndex = teamList.FindIndex(x => x.Id == match.AwayTeam.Id);
            var awayTeam = teamList[awayTeamIndex];
            var HomeTeamIndex = teamList.FindIndex(x => x.Id == match.HomeTeam.Id);
            var HomeTeam = teamList[HomeTeamIndex];

            CalculateGoalInfoes(HomeTeam.ADinfo,awayTeam.ADinfo,match.HomeGoals,match.AwayGoals);

            teamList[awayTeamIndex] = awayTeam;
            teamList[HomeTeamIndex] = HomeTeam;

            return Task.CompletedTask;
        }

        private static void CalculateGoalInfoes(
            TeamAdditionalInfo homeTeamInfo,
            TeamAdditionalInfo awayTeamInfo,
            int matchHomeGoals,
            int matchAwayGoals)
        {
            awayTeamInfo.GamesPlayed++;
            homeTeamInfo.GamesPlayed++;
            awayTeamInfo.ScoredGoals += matchAwayGoals;
            homeTeamInfo.ScoredGoals += matchHomeGoals;
            if (matchHomeGoals > matchAwayGoals)
            {
                homeTeamInfo.Score += 3;
                homeTeamInfo.Wins++;
                awayTeamInfo.Losses++;
            }
            else if(matchHomeGoals < matchAwayGoals)
            {
                awayTeamInfo.Score += 3;
                awayTeamInfo.Wins++;
                homeTeamInfo.Losses++;
            }
            else
            {
                homeTeamInfo.Score += 1;
                homeTeamInfo.Draws++;
                awayTeamInfo.Score += 1;
                awayTeamInfo.Draws++;
            }

            homeTeamInfo.PassedGoals += matchAwayGoals;
            awayTeamInfo.PassedGoals += matchHomeGoals;

        }
    }
}
