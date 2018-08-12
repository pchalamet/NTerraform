using System.Collections.Generic;

namespace nterraform.datas.azurerm
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_route_table")]
    public sealed class azurerm_route_table : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "route")]
        public sealed class route : nterraform.Core.structure
        {
            public route()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "address_prefix", @out: true, min: 0, max: 1)]
            public string @AddressPrefix { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "next_hop_in_ip_address", @out: true, min: 0, max: 1)]
            public string @NextHopInIpAddress { get; }

            [nterraform.Core.TerraformProperty(name: "next_hop_type", @out: true, min: 0, max: 1)]
            public string @NextHopType { get; }
        }

        public azurerm_route_table(string @name,
                                   string @resourceGroupName,
                                   route[] @route = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Route = @route;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "route", @out: false, min: 0, max: 0)]
        public route[] @Route { get; }

        [nterraform.Core.TerraformProperty(name: "subnets", @out: true, min: 0, max: 1)]
        public string[] @Subnets { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
