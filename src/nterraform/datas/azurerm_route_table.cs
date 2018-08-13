using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "azurerm_route_table")]
    public sealed class azurerm_route_table : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "route")]
        public sealed class route : nterraform.structure
        {
            public route()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "address_prefix", @out: true, min: 0, max: 1)]
            public string @AddressPrefix { get; }

            [nterraform.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "next_hop_in_ip_address", @out: true, min: 0, max: 1)]
            public string @NextHopInIpAddress { get; }

            [nterraform.TerraformProperty(name: "next_hop_type", @out: true, min: 0, max: 1)]
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

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "route", @out: false, min: 0, max: 0)]
        public route[] @Route { get; }

        [nterraform.TerraformProperty(name: "subnets", @out: true, min: 0, max: 1)]
        public string[] @Subnets { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
