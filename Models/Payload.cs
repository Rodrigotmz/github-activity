using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gitHub_user_activity.Models
{
    public class Payload
    {
        [JsonPropertyName("repository_id")]
        public long repository_id { get; set; }

        [JsonPropertyName("commits")]
        public List<Commits>? commits { get; set; }

        [JsonPropertyName("action")]
        public string action { get; set; }

        [JsonPropertyName("issue")]
        public Issue issue { get; set; }
    }
    public class Commits
    {
        [JsonPropertyName("sha")]
        public string? sha { get; set; }

        [JsonPropertyName("author")]
        public Author? author { get; set; }

        [JsonPropertyName("message")]
        public string? message { get; set; }

        [JsonPropertyName("distinct")]
        public bool distinct { get; set; }

        [JsonPropertyName("url")]
        public string? url { get; set; }

    }
    public class Author
    {
        [JsonPropertyName("name")]
        public string? name { get; set; }
        [JsonPropertyName("email")]
        public string? email { get; set; }
    }
    public class Issue
    {
        [JsonPropertyName("url")]
        public string url { get; set; }
        [JsonPropertyName("number")]
        public int number { get; set; }
        [JsonPropertyName("title")]
        public string title { get; set; }
    }

}
