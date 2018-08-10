using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_resource_group : NTerraform.resource
    {
        public azurerm_resource_group(string @location,
                                      string @name)
        {
            @Location = @location;
            @Name = @name;
        }

        public string @Location { get; }
        public string @Name { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
