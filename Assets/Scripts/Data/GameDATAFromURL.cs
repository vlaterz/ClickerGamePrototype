using System;
using Newtonsoft.Json;

namespace Assets.Scripts.Data
{
    [Serializable]
    public class GameDATAFromURL
    {
        [JsonProperty("level_1")]
        public Level Level1 { get; set; }

        [JsonProperty("level_2")]
        public Level Level2 { get; set; }

        [JsonProperty("level_3")]
        public Level Level3 { get; set; }

        [JsonProperty("level_4")]
        public Level Level4 { get; set; }
    }
    
}