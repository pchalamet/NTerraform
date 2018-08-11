using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_route_table")]
    public sealed class azurerm_route_table : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "route")]
        public sealed class route
        {
            public route(string @addressPrefix,
                         string @name,
                         string @nextHopType)
            {
                @AddressPrefix = @addressPrefix;
                @Name = @name;
                @NextHopType = @nextHopType;
            }

            [TerraformProperty(name: "address_prefix", @out: false, nested: false, min: 1, max: 1)]
            public string @AddressPrefix { get; }

            [TerraformProperty(name: "name", @out: false, nested: false, min: 1, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "next_hop_type", @out: false, nested: false, min: 1, max: 1)]
            public string @NextHopType { get; }

            [TerraformProperty(name: "next_hop_in_ip_address", @out: true, nested: false, min: 0, max: 1)]
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

        [TerraformProperty(name: "location", @out: false, nested: true, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "disable_bgp_route_propagation", @out: false, nested: true, min: 0, max: 1)]
        public bool? @DisableBgpRoutePropagation { get; }

        [TerraformProperty(name: "route", @out: false, nested: true, min: 0, max: 0)]
        public route[] @Route { get; }

        [TerraformProperty(name: "subnets", @out: true, nested: true, min: 0, max: 1)]
        public string[] @Subnets { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
