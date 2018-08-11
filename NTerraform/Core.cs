using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace NTerraform
{
    public abstract class data
    {
    }

    public abstract class provider
    {
    }

    public abstract class resource
    {
    }

    public sealed class schema
    {
        private static IHost FindHost()
        {
            var entryPoint = Assembly.GetEntryAssembly().GetName().Name;
            switch (entryPoint)
            {
                case "dotnet-script":
                    return new DotnetScriptHost();

                default:
                    throw new ApplicationException($"Unknown host ${entryPoint}");
            }
        }


        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void Build()
        {
            Console.WriteLine("schema.Build()");
            var host = FindHost();
            Console.WriteLine($"Using host {host.Name}");

            var variables = host.GetVariables();
        }
    }
}