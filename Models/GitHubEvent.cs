using System.Text.Json.Serialization;

namespace gitHub_user_activity.Models
{
    public class GitHubEvent
    {
        [JsonPropertyName("id")]
        public string? id { get; set; }

        [JsonPropertyName("type")]
        public string? type { get; set; }
        [JsonPropertyName("actor")]
        public Actor? actor { get; set; }

        [JsonPropertyName("repo")]
        public Repository repo { get; set; }

        [JsonPropertyName("payload")]
        public Payload? payload { get; set; }

        [JsonPropertyName("public")]
        public bool Public { get; set; }

        [JsonPropertyName("created_at")]
        public string? created_at { get; set; }
    }
    public class Actor
    {
        [JsonPropertyName("id")]
        public int? id { get; set; }

        [JsonPropertyName("login")]
        public string? login { get; set; }

        [JsonPropertyName("display_login")]
        public string? display_login { get; set; }

        [JsonPropertyName("gravatar_id")]
        public string? gravatar_id { get; set; }

        [JsonPropertyName("url")]
        public string? url { get; set; }
    }
}
