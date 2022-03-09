using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;

namespace Zack.DotNetTrimmerLib;
public static class PEHelpers
{
    public static bool IsManagedAssembly(string file)
    {
        using var fs = File.OpenRead(file);
        using PEReader peReader = new PEReader(fs);
        try
        {
            return peReader.HasMetadata && peReader.GetMetadataReader().IsAssembly;
        }
        catch (BadImageFormatException)
        {
            return false;
        }
    }
}