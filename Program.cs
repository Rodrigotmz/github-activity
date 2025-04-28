using gitHub_user_activity.CLI;
using System.CommandLine;
using System.CommandLine.Invocation;

var manager = new GitMannager();

var addCommandGit = new Argument<string>("username", "The username to fetch GitHub Activity");

addCommandGit.AddValidator((result) =>
{
    if (string.IsNullOrWhiteSpace(result.GetValueForArgument(addCommandGit)))
    {
        result.ErrorMessage = "Please provide a valid username.";
    }
});


var rootCommand = new RootCommand
{
    addCommandGit
};

rootCommand.SetHandler(async (username) =>
{
    await manager.GetCountPushedCommits(username);
    await manager.GetIssues(username);
}, addCommandGit);

//await manager.GetCountPushedCommits("Rodrigotmz");
//await manager.GetIssues("Rodrigotmz");
string[] arg = ["Rodrigotmz"];
await rootCommand.InvokeAsync(arg);