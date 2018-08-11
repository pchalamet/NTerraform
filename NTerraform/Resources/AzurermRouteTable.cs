using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_route_table : NTerraform.resource
    {
        public class route
        {
            public route(string @addressPrefix,
                         string @name,
                         string @nextHopType)
            {
                @AddressPrefix = @addressPrefix;
                @Name = @name;
                @NextHopType = @nextHopType;
            }

            public string @AddressPrefix { get; }
            public string @Name { get; }
            public string @NextHopType { get; }
            public string @NextHopInIpAddress { get; }
        }

        public azurerm_route_table(string @location,
                                   string @name,
                                   string @resourceGroupName,
                                   bool? @disableBgpRoutePropagation = null,
                                   route[] @route = null)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @DisableBgpRoutePropagation = @disableBgpRoutePropagation;
            @Route = @route;
        }

        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public bool? @DisableBgpRoutePropagation { get; }
        public route[] @Route { get; }
        public string[] @Subnets { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
