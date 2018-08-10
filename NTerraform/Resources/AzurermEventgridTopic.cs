using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_eventgrid_topic : NTerraform.resource
    {
        public azurerm_eventgrid_topic(string @location,
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
        public string @Endpoint { get; }
        public string @PrimaryAccessKey { get; }
        public string @SecondaryAccessKey { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
