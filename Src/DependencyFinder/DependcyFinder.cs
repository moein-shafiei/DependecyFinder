using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DependencyFinder
{
    public class DependcyFinder
    {
        public List<string> GetDependecyList(string FolderPath)
        {
            string[] array1 = Directory.GetFiles(FolderPath, "*.dll", SearchOption.AllDirectories);
            return Search(array1);
        }

        private static string[] GetDependentFiles(Assembly assembly)
        {
            AssemblyName[] asm = assembly.GetReferencedAssemblies();
            List<string> paths = new List<string>(asm.Length);
            for (int t = asm.Length - 1; t >= 0; t--)
            {

                string path = assembly.GetName() + " - depends on - " + asm[t].Name + " " + asm[t].Version;
                paths.Add(path);

            }

            return paths.ToArray();
        }

        private List<string> Search(string[] FileList)
        {
            List<string> dependencyList = new List<string>();

            foreach (var item in FileList)
            {
                Assembly assembly;
                string[] dependencies;
                try
                {
                    assembly = Assembly.LoadFrom(item);
                    dependencies = GetDependentFiles(assembly);
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("exception in:" + item);
                    continue;
                }

                foreach (var item2 in dependencies)
                {
                    if (dependencyList.IndexOf(item2) > -1)
                    {

                    }
                    else
                    {
                        try
                        {
                            dependencyList.Add(item2);
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("exception in:" + assembly.FullName);
                            continue;
                        }
                    }
                }
            }

            return dependencyList;
        }
    }
}
