using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_route : NTerraform.resource
    {
        public azurerm_route(string @addressPrefix,
                             string @name,
                             string @nextHopType,
                             string @resourceGroupName,
                             string @routeTableName)
        {
            @AddressPrefix = @addressPrefix;
            @Name = @name;
            @NextHopType = @nextHopType;
            @ResourceGroupName = @resourceGroupName;
            @RouteTableName = @routeTableName;
        }

        public string @AddressPrefix { get; }
        public string @Name { get; }
        public string @NextHopType { get; }
        public string @ResourceGroupName { get; }
        public string @RouteTableName { get; }
        public string @NextHopInIpAddress { get; }
    }

}
