using System;
using System.Collections.Generic;
using System.Reflection;

namespace nterraform.Hosts
{
    public class DotnetScript : IHost
    {
        public string Name => "dotnet-script";

        public Dictionary<string, structure> GetVariables()
        {
            var currentClass = MethodBase.GetCurrentMethod().DeclaringType;
            return new Dictionary<string, structure>();
        }
    }
}