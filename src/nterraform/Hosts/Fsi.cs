using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace nterraform.Hosts
{
    public class Fsi : IHost
    {
        public string Name => "FSI";

        public Dictionary<string, structure> GetVariables()
        {
            var fsiType = AppDomain.CurrentDomain.GetAssemblies()
                                                 .Select(x => x.GetTypes())
                                                 .SelectMany(x => x)
                                                 .First(x => x.Name.StartsWith("FSI_", StringComparison.InvariantCulture));

            var props = fsiType.GetProperties(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

            var dict = new Dictionary<string, structure>();
            foreach (var prop in props)
            {
                var value = prop.GetValue(null) as structure;
                if (null != value)
                    dict.Add(prop.Name, value);
            }

            return dict;
        }
    }
}