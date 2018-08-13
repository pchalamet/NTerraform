using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;

namespace nterraform
{
    public sealed class configuration
    {
        private static Hosts.IHost FindHost()
        {
            var entryPoint = Assembly.GetEntryAssembly().GetName().Name;
            switch (entryPoint)
            {
                case "dotnet-script":
                    return new Hosts.DotnetScript();

                case "fsi":
                    return new Hosts.Fsi();

                default:
                    throw new ApplicationException($"Unknown host ${entryPoint}");
            }
        }

        private static void ProcessVariable(string name, structure var)
        {
            foreach (var line in var.WriteObject(name))
                Console.WriteLine(line);
            Console.WriteLine();
        }

        private static void ProcessVariables(Dictionary<string, structure> context)
        {
            foreach (var kvp in context)
                ProcessVariable(kvp.Key, kvp.Value);
        }

        public static void build()
        {
            var host = FindHost();
            var context = host.GetVariables();
            ProcessVariables(context);
        }
    }
}