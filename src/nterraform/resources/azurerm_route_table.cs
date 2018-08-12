using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_route_table")]
    public sealed class azurerm_route_table : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "route")]
        public sealed class route : nterraform.Core.structure
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

            [nterraform.Core.TerraformProperty(name: "address_prefix", @out: false, min: 1, max: 1)]
            public string @AddressPrefix { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "next_hop_type", @out: false, min: 1, max: 1)]
            public string @NextHopType { get; }

            [nterraform.Core.TerraformProperty(name: "next_hop_in_ip_address", @out: true, min: 0, max: 1)]
            public string @NextHopInIpAddress { get; }
        }

        public azurerm_route_table(string @location,
                                   string @name,
                                   string @resourceGroupName,
                                   bool? @disableBgpRoutePropagation = null,
                                   FSharpList<route> @route = null)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @DisableBgpRoutePropagation = @disableBgpRoutePropagation;
            @Route = @route ?? FSharpList<route>.Empty;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "disable_bgp_route_propagation", @out: false, min: 0, max: 1)]
        public bool? @DisableBgpRoutePropagation { get; }

        [nterraform.Core.TerraformProperty(name: "route", @out: false, min: 0, max: 0)]
        public FSharpList<route> @Route { get; }

        [nterraform.Core.TerraformProperty(name: "subnets", @out: true, min: 0, max: 1)]
        public FSharpList<string> @Subnets { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpMap<string,string> @Tags { get; }
    }

}
