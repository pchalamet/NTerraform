using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_subnet : NTerraform.resource
    {
        public azurerm_subnet(string @addressPrefix,
                              string @name,
                              string @resourceGroupName,
                              string @virtualNetworkName,
                              string @networkSecurityGroupId = null,
                              string @routeTableId = null,
                              string[] @serviceEndpoints = null)
        {
            @AddressPrefix = @addressPrefix;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @VirtualNetworkName = @virtualNetworkName;
            @NetworkSecurityGroupId = @networkSecurityGroupId;
            @RouteTableId = @routeTableId;
            @ServiceEndpoints = @serviceEndpoints;
        }

        public string @AddressPrefix { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @VirtualNetworkName { get; }
        public string[] @IpConfigurations { get; }
        public string @NetworkSecurityGroupId { get; }
        public string @RouteTableId { get; }
        public string[] @ServiceEndpoints { get; }
    }

}
