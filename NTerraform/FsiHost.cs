using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace NTerraform
{
    public class FsiHost : IHost
    {
        public string Name => "FSI";

        public Dictionary<string, object> GetVariables()
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();
            var fsiType = types.First(x => x.Name.StartsWith("FSI_", StringComparison.InvariantCulture));
            var props = fsiType.GetProperties(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

            var dict = new Dictionary<string, object>();
            foreach (var prop in props)
            {
                var value = prop.GetValue(null);
                switch (value)
                {
                    case data data:
                        dict.Add(prop.Name, data);
                        break;

                    case provider provider:
                        dict.Add(prop.Name, provider);
                        break;

                    case resource resource:
                        dict.Add(prop.Name, resource);
                        break;
                }
            }

            return dict;
        }
    }
}
