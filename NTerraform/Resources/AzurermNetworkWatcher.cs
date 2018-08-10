using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_network_watcher : NTerraform.resource
    {
        public azurerm_network_watcher(string @location,
                                       string @name,
                                       string @resourceGroupName)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
        }

        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
