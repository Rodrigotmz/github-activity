using System.Net.Http;
using System.Text.Json;
using gitHub_user_activity.CLI;
using gitHub_user_activity.Models;
using Newtonsoft.Json;

var manager = new GitMannager();

await manager.GetCountPushedCommits("Rodrigotmz");
await manager.GetIssues("Rodrigotmz");