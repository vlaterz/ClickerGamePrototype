using System;
using Newtonsoft.Json;

namespace Assets.Scripts.Data
{
    [Serializable]
    public class Level
    {
        [JsonProperty("stars")]
        public long Stars { get; set; }

        [JsonProperty("leaderboard")]
        public PlayerData[] Leaderboard { get; set; }
    }
}
