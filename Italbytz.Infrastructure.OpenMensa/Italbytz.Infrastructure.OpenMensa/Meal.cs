﻿using System.Text.Json.Serialization;

namespace Italbytz.Infrastructure.OpenMensa
{
    public partial class Meal
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("prices")]
        public Prices Prices { get; set; }

        [JsonPropertyName("notes")]
        public string[] Notes { get; set; }
    }

    public partial class Prices
    {
        [JsonPropertyName("students")]
        public double Students { get; set; }

        [JsonPropertyName("employees")]
        public double Employees { get; set; }

        [JsonPropertyName("pupils")]
        public object Pupils { get; set; }

        [JsonPropertyName("others")]
        public double Others { get; set; }
    }
}