using System;
using Newtonsoft.Json;

namespace Assets.Scripts.Data
{
    [Serializable]
    public class PlayerData
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("time")]
        public double Time { get; set; }
    }
}
