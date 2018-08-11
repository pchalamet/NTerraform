using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_route")]
    public sealed class azurerm_route : NTerraform.resource
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
            base._validate_();
        }

        [TerraformProperty(name: "address_prefix", @out: false, min: 1, max: 1)]
        public string @AddressPrefix { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "next_hop_type", @out: false, min: 1, max: 1)]
        public string @NextHopType { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "route_table_name", @out: false, min: 1, max: 1)]
        public string @RouteTableName { get; }

        [TerraformProperty(name: "next_hop_in_ip_address", @out: true, min: 0, max: 1)]
        public string @NextHopInIpAddress { get; }
    }

}
