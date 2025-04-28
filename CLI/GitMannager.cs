using gitHub_user_activity.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace gitHub_user_activity.CLI
{
    public class GitMannager
    {
        HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://api.github.com/users/"),
            DefaultRequestHeaders =
                                    {
                                        { "User-Agent", "HttpClientFactory-Sample" },
                                        { "Accept", "application/vnd.github.v3+json" }
                                    }
        };
        //Obtener todos los datos del usuario en github
        public async Task<List<GitHubEvent>> GetAsJsonAsyncGit(string name,HttpClient httpClient)
        {
            using HttpResponseMessage response = await httpClient.GetAsync($"{name}/events/public");

            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true // Ignora si las propiedades vienen en mayúscula o minúscula
            };
            var events = JsonConvert.DeserializeObject<List<GitHubEvent>>(jsonResponse);
            return events;
        }

        public async Task GetCountPushedCommits(string events)
        {
            Dictionary<string, int> pushedCommits = new Dictionary<string, int>();
            var data = await GetAsJsonAsyncGit(events, client);
            foreach (var git in data)
            {
                if (git.type == "PushEvent")
                {
                    int count = git.payload?.commits?.Count ?? 0;
                    string name = git.repo.name;
                    if (pushedCommits.ContainsKey(name))
                    {
                        pushedCommits[name] += count;
                    }
                    else
                    {
                        pushedCommits.Add(name, count);
                    }
                }

                if (git.type == "IssuesEvent" && git.payload.action == "opened")
                {
                    string repoName = git.repo.name;
                    string issueTitle = git.payload.issue.title;
                    string issueUrl = git.payload.issue.url;
                    
                }

            }
            foreach (var push in pushedCommits)
            {
                Console.WriteLine($"Pushed {push.Value} commits to {push.Key} ");
            }
        }
        public async Task GetIssues(string events)
        {
            Dictionary<string, int> issuesOpened = new Dictionary<string, int>();
            var data = await GetAsJsonAsyncGit(events, client);
            foreach (var git in data)
            {
                if (git.type == "IssuesEvent" && git.payload.action == "opened")
                {
                    string repoName = git.repo.name;
                    if (issuesOpened.ContainsKey(repoName))
                    {
                        issuesOpened[repoName] += 1;
                    }
                    else
                    {
                        issuesOpened.Add(repoName, 1);
                    }
                }

            }
            foreach (var push in issuesOpened)
            {
                Console.WriteLine($"Opened {(push.Value > 1 ? $"a {push.Value} new" : "a new")} issue in {push.Key} ");
            }
        }
    }
}
