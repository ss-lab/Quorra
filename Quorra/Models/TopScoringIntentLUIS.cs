﻿using Newtonsoft.Json;

namespace Quorra.Models
{
    public class TopScoringIntentLuis
    {
        [JsonProperty(PropertyName = "intent")]
        public string Intent { get; set; }

        [JsonProperty(PropertyName = "score")]
        public double Score { get; set; }
    }
}
