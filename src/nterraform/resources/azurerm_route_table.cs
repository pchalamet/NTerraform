using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_route_table")]
    public sealed class azurerm_route_table : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "route")]
        public sealed class route : nterraform.structure
        {
            public route(string @addressPrefix,
                         string @name,
                         string @nextHopType)
            {
                @AddressPrefix = @addressPrefix;
                @Name = @name;
                @NextHopType = @nextHopType;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "address_prefix", @out: false, min: 1, max: 1)]
            public string @AddressPrefix { get; }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "next_hop_type", @out: false, min: 1, max: 1)]
            public string @NextHopType { get; }

            [nterraform.TerraformProperty(name: "next_hop_in_ip_address", @out: true, min: 0, max: 1)]
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "disable_bgp_route_propagation", @out: false, min: 0, max: 1)]
        public bool? @DisableBgpRoutePropagation { get; }

        [nterraform.TerraformProperty(name: "route", @out: false, min: 0, max: 0)]
        public route[] @Route { get; }

        [nterraform.TerraformProperty(name: "subnets", @out: true, min: 0, max: 1)]
        public string[] @Subnets { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
