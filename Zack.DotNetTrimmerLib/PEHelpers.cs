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

    public static bool IsNetFrameworkApp(string startupFile)
    {
        if (!IsManagedAssembly(startupFile))
        {
            return false;
        }
        using (var module = ModuleDefMD.Load(startupFile))
        {
            return module.RuntimeVersion.StartsWith("v4.");
        }
    }

    public static bool IsSelfContainedApp(string startupFile)
    {
        string startupDir = Path.GetDirectoryName(startupFile);
        var dllFiles = Directory.GetFiles(startupDir, "*.dll").Select(f => Path.GetFileName(f));
        var clrFiles = new string[] { "netstandard.dll", "coreclr.dll", "clrjit.dll", "System.Private.CoreLib.dll", "System.Core.dll" };
        //check whether dllFiles contains at least one elements of clrFiles
        return dllFiles.Intersect(clrFiles).Any();
    }

    public static bool IsBuiltWithProduce_SingleFile(string startupFile)
    {
        string dir = Path.GetDirectoryName(startupFile);
        string dllFileName = Path.GetFileNameWithoutExtension(startupFile) + ".dll";
        string dllFileFullPath = Path.Combine(dir, dllFileName);
        return !File.Exists(dllFileFullPath);
    }

}