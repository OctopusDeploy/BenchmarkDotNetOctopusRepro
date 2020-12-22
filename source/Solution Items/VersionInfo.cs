// Versioned by GitVersion

using System.Reflection;

[assembly: AssemblyVersion("0.0.0.0")]
[assembly: AssemblyInformationalVersion("0.0.0-local")]
[assembly: AssemblyFileVersion("0.0.0.0")]

namespace Octopus
{
    internal static class GitVersionInformation
    {
        // Keep this value inline with the literal NuGetVersion above
        public const string DefaultDevelopmentBuildVersion = "0.0.0-local";
        public static string BranchName = "UNKNOWNBRANCH";

        // This needs to be a literal value so it can be overwritten during the build process
        public static string NuGetVersion = "0.0.0-local";
    }
}