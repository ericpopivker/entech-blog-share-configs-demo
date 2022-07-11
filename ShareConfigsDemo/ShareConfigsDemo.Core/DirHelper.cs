using System.Reflection;


namespace ShareConfigsDemo.Core
{
public static class DirHelper
{
    public static string GetBinRunDir()
    {
        //https://stackoverflow.com/questions/60236727/how-find-bin-directory-in-asp-net-core-3-1
        var runDir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        return runDir;
    }
}
}
