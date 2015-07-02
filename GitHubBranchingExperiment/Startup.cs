using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHubBranchingExperiment.Startup))]
namespace GitHubBranchingExperiment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
