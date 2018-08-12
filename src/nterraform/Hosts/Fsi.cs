using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace nterraform.Hosts
{
    public class Fsi : IHost
    {
        public string Name => "FSI";

        public Dictionary<string, object> GetVariables()
        {
            var fsiType = AppDomain.CurrentDomain.GetAssemblies()
                                                 .Select(x => x.GetTypes())
                                                 .SelectMany(x => x)
                                                 .First(x => x.Name.StartsWith("FSI_", StringComparison.InvariantCulture));

            var props = fsiType.GetProperties(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

            var dict = new Dictionary<string, object>();
            foreach (var prop in props)
            {
                var value = prop.GetValue(null);
                switch (value)
                {
                    case nterraform.Core.data data:
                        dict.Add(prop.Name, data);
                        break;

                    case nterraform.Core.provider provider:
                        dict.Add(prop.Name, provider);
                        break;

                    case nterraform.Core.resource resource:
                        dict.Add(prop.Name, resource);
                        break;
                }
            }

            return dict;
        }
    }
}
