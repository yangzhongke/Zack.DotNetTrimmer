using System.Reflection.PortableExecutable;

namespace Zack.DotNetTrimmer;
static class PEHelpers
{
    public static bool IsManagedAssembly(string file)
    {
        //https://www.cnblogs.com/mumuliang/p/4059610.html
        //we can use PEFile in ICSharpCode.Decompiler instead.
        using var fs = File.OpenRead(file);
        using PEReader peReader = new PEReader(fs);
        var peHeaders = peReader.PEHeaders;
        return peHeaders.CorHeader != null;
    }
}