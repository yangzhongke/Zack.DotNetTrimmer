using dnlib.DotNet;

namespace Zack.DotNetTrimmerLib
{
    static class AssemblyTrimmer
    {
        /// <summary>
        /// clear the bodies of methods of unused classes in loadedAssemblies
        /// </summary>
        /// <param name="loadedAssemblies"></param>
        /// <param name="loadedTypes"></param>
        public static void TrimAssembly(string asmFile, HashSet<string> loadedTypes)
        {
            using var memStream = new MemoryStream();
            using (var module = ModuleDefMD.Load(asmFile))
            {
                //Assembly contains more than IL code cannot be trimmed as expected.
                //https://github.com/Washi1337/AsmResolver/issues/267
                if (!module.IsILOnly) return;

                List<TypeDef> typesToBeRemoved = new List<TypeDef>();
                foreach (var type in module.Types)
                {
                    if (type.IsGlobalModuleType) continue;//<Module>                    
                                                          //struct, nested classes are not included in the report by DiagnosticsClient
                    if (type.IsValueType) continue;//UriCreationOptions etc
                    if (type.IsNested) continue;
                    if (type.HasGenericParameters) continue;//generic classes may have different names as in the report by DiagnosticsClient, like A`1 and A<int>
                    if (!loadedTypes.Contains(type.FullName))
                    {
                        typesToBeRemoved.Add(type);
                    }
                }
                foreach (var type in typesToBeRemoved)
                {
                    //these methods may be referenced by others, so they cannot be removed; however, the body can be replace by 'throw null;'
                    foreach (var method in type.Methods)
                    {
                        PEHelpers.ClearMethodBody(method);
                    }
                }
                //if module.IsILOnly, NativeWrite should be used instead of Write
                module.Write(memStream);
            }
            memStream.Position = 0;
            File.WriteAllBytes(asmFile, memStream.ToArray());
        }
    }
}
