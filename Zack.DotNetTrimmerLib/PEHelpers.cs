using dnlib.DotNet;
using dnlib.DotNet.Emit;
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

    public static void ClearMethodBody(MethodDef method)
    {
        if (!method.IsManaged || method.IsConstructor || method.IsStaticConstructor || method.IsNative) return;
        if (method.CustomAttributes.Any(a => a.TypeFullName == "System.Runtime.CompilerServices.ModuleInitializerAttribute")) return;
        if (method.Body != null)
        {
            method.Body.ExceptionHandlers.Clear();
            method.Body.Instructions.Clear();
            method.Body.Variables.Clear();
            method.Body.Instructions.Add(new Instruction(OpCodes.Nop) { Offset = 0 });
            method.Body.Instructions.Add(new Instruction(OpCodes.Ldnull) { Offset = 1 });
            method.Body.Instructions.Add(new Instruction(OpCodes.Throw) { Offset = 2 });
        }
    }
}