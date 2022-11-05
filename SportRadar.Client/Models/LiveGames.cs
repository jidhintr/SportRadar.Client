using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportRadar.Client.Models
{
    public class LiveGames
    {
        public List<Game> Games { get; set; }
        public class Game
        {
            public string HomeTeam { get; set; }
            public string AwayTeam { get; set; }
            public string HomeTeamScore { get; set; }
            public string AwayTeamScore { get; set; }
            public int TimeRemaining { get; set; }
            public int GameId { get; set; }
        }
    }


}
