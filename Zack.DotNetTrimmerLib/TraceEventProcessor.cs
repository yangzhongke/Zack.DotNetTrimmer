using Microsoft.Diagnostics.Tracing;
using Microsoft.Diagnostics.Tracing.Parsers.Clr;
using System.Diagnostics;
using System.Reflection;

namespace Zack.DotNetTrimmerLib
{
    static class TraceEventProcessor
    {
        public static void Process(RecordFileInfo recordFileInfo, TraceEvent obj)
        {
            if (obj is KnownPathProbedTraceData)
            {
                var data = (KnownPathProbedTraceData)obj;
                recordFileInfo.LoadedAssemblies.Add(Path.GetFileName(data.FilePath));
            }
            else if (obj is ResolutionAttemptedTraceData)
            {
                var data = (ResolutionAttemptedTraceData)obj;
                string asmFullPath = data.ResultAssemblyPath;
                if (!string.IsNullOrWhiteSpace(asmFullPath))
                {
                    recordFileInfo.LoadedAssemblies.Add(Path.GetFileName(asmFullPath));
                }
                if (!string.IsNullOrWhiteSpace(data.ResultAssemblyName))
                {
                    recordFileInfo.LoadedAssemblies.Add(new AssemblyName(data.ResultAssemblyName).Name + ".dll");
                }
            }
            else if (obj is ModuleLoadUnloadTraceData)
            {
                var data = (ModuleLoadUnloadTraceData)obj;
                string asmFullPath = data.ModuleILPath;
                if (!string.IsNullOrWhiteSpace(asmFullPath))
                {
                    recordFileInfo.LoadedAssemblies.Add(Path.GetFileName(asmFullPath));
                }
            }
            //for Linux
            else if (obj is DomainModuleLoadUnloadTraceData)
            {
                var data = (DomainModuleLoadUnloadTraceData)obj;
                string asmFullPath = data.ModuleILPath;
                recordFileInfo.LoadedAssemblies.Add(Path.GetFileName(asmFullPath));
            }
            else if (obj is TypeLoadStopTraceData)
            {
                var data = (TypeLoadStopTraceData)obj;
                string typeName = data.TypeName;
                recordFileInfo.LoadedTypes.Add(typeName);
            }
            else if (obj is GCBulkTypeTraceData)
            {
                var data = (GCBulkTypeTraceData)obj;
                for (int i = 0; i < data.Count; i++)
                {
                    string typeName = data.Values(i).TypeName;
                    recordFileInfo.LoadedTypes.Add(typeName);
                }
            }
            else if (obj is R2RGetEntryPointTraceData)
            {
                var data = (R2RGetEntryPointTraceData)obj;
                recordFileInfo.LoadedTypes.Add(data.MethodNamespace);
            }
            else if (obj is AssemblyLoadStartTraceData)
            {
                var data = (AssemblyLoadStartTraceData)obj;
                if (!string.IsNullOrWhiteSpace(data.AssemblyPath))
                {
                    recordFileInfo.LoadedAssemblies.Add(Path.GetFileName(data.AssemblyPath));
                }
                if (!string.IsNullOrWhiteSpace(data.AssemblyName))
                {
                    recordFileInfo.LoadedAssemblies.Add(new AssemblyName(data.AssemblyName).Name + ".dll");
                }
                if (!string.IsNullOrWhiteSpace(data.RequestingAssembly))
                {
                    recordFileInfo.LoadedAssemblies.Add(new AssemblyName(data.RequestingAssembly).Name + ".dll");
                }
            }
            else if (obj is AssemblyLoadStopTraceData)
            {
                var data = (AssemblyLoadStopTraceData)obj;
                if (!string.IsNullOrWhiteSpace(data.ResultAssemblyPath))
                {
                    recordFileInfo.LoadedAssemblies.Add(Path.GetFileName(data.ResultAssemblyPath));
                }
                if (!string.IsNullOrWhiteSpace(data.ResultAssemblyName))
                {
                    recordFileInfo.LoadedAssemblies.Add(new AssemblyName(data.ResultAssemblyName).Name + ".dll");
                }
                if (!string.IsNullOrWhiteSpace(data.AssemblyPath))
                {
                    recordFileInfo.LoadedAssemblies.Add(Path.GetFileName(data.AssemblyPath));
                }
                if (!string.IsNullOrWhiteSpace(data.AssemblyName))
                {
                    recordFileInfo.LoadedAssemblies.Add(new AssemblyName(data.AssemblyName).Name + ".dll");
                }
            }
            else if (obj is AssemblyLoadUnloadTraceData)
            {
                var data = (AssemblyLoadUnloadTraceData)obj;
                if (!string.IsNullOrWhiteSpace(data.FullyQualifiedAssemblyName))
                {
                    recordFileInfo.LoadedAssemblies.Add(new AssemblyName(data.FullyQualifiedAssemblyName).Name + ".dll");
                }
            }
            else if (obj is ILStubGeneratedTraceData)
            {
                var data = (ILStubGeneratedTraceData)obj;
                if (!string.IsNullOrWhiteSpace(data.ManagedInteropMethodNamespace))
                {
                    recordFileInfo.LoadedTypes.Add(data.ManagedInteropMethodNamespace);
                }
            }
            else if (obj is MethodLoadUnloadVerboseTraceData)
            {
                var data = (MethodLoadUnloadVerboseTraceData)obj;
                if (!string.IsNullOrWhiteSpace(data.MethodNamespace))
                {
                    recordFileInfo.LoadedTypes.Add(data.MethodNamespace);
                }
            }
            else if (obj is GCAllocationTickTraceData)
            {
                var data = (GCAllocationTickTraceData)obj;
                recordFileInfo.LoadedTypes.Add(data.TypeName);
            }
            else if (obj is FinalizeObjectTraceData)
            {
                var data = (FinalizeObjectTraceData)obj;
                recordFileInfo.LoadedTypes.Add(data.TypeName);
            }
            else if (obj is PinObjectAtGCTimeTraceData)
            {
                var data = (PinObjectAtGCTimeTraceData)obj;
                recordFileInfo.LoadedTypes.Add(data.TypeName);
            }
            else if (obj is AppDomainAssemblyResolveHandlerInvokedTraceData)
            {
                var data = (AppDomainAssemblyResolveHandlerInvokedTraceData)obj;
                if (!string.IsNullOrWhiteSpace(data.ResultAssemblyPath))
                {
                    recordFileInfo.LoadedAssemblies.Add(Path.GetFileName(data.ResultAssemblyPath));
                }
                if (!string.IsNullOrWhiteSpace(data.ResultAssemblyName))
                {
                    recordFileInfo.LoadedAssemblies.Add(new AssemblyName(data.ResultAssemblyName).Name + ".dll");
                }
                if (!string.IsNullOrWhiteSpace(data.AssemblyName))
                {
                    recordFileInfo.LoadedAssemblies.Add(new AssemblyName(data.AssemblyName).Name + ".dll");
                }
            }
            else if (obj is AssemblyLoadFromResolveHandlerInvokedTraceData)
            {
                var data = (AssemblyLoadFromResolveHandlerInvokedTraceData)obj;
                if (!string.IsNullOrWhiteSpace(data.AssemblyName))
                {
                    recordFileInfo.LoadedAssemblies.Add(new AssemblyName(data.AssemblyName).Name + ".dll");
                }
            }
            else if (obj is AssemblyLoadContextResolvingHandlerInvokedTraceData)
            {
                var data = (AssemblyLoadContextResolvingHandlerInvokedTraceData)obj;
                if (!string.IsNullOrWhiteSpace(data.ResultAssemblyPath))
                {
                    recordFileInfo.LoadedAssemblies.Add(Path.GetFileName(data.ResultAssemblyPath));
                }
                if (!string.IsNullOrWhiteSpace(data.ResultAssemblyName))
                {
                    recordFileInfo.LoadedAssemblies.Add(new AssemblyName(data.ResultAssemblyName).Name + ".dll");
                }
                if (!string.IsNullOrWhiteSpace(data.AssemblyName))
                {
                    recordFileInfo.LoadedAssemblies.Add(new AssemblyName(data.AssemblyName).Name + ".dll");
                }
            }
            else if (obj is StrongNameVerificationTraceData)
            {
                var data = (StrongNameVerificationTraceData)obj;
                recordFileInfo.LoadedAssemblies.Add(new AssemblyName(data.FullyQualifiedAssemblyName).Name + ".dll");
            }
            else if (obj is AuthenticodeVerificationTraceData)
            {
                var data = (AuthenticodeVerificationTraceData)obj;
                recordFileInfo.LoadedAssemblies.Add(Path.GetFileName(data.ModulePath));
            }
            else if (obj is RuntimeInformationTraceData)
            {
                var data = (RuntimeInformationTraceData)obj;
                recordFileInfo.LoadedAssemblies.Add(Path.GetFileName(data.RuntimeDllPath));
            }
        }
    }
}
