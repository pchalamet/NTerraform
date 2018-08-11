using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "azurerm_virtual_network")]
    public sealed class azurerm_virtual_network : NTerraform.data
    {
        public azurerm_virtual_network(string @name,
                                       string @resourceGroupName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            base._validate_();
        }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "address_spaces", @out: true, min: 0, max: 1)]
        public string[] @AddressSpaces { get; }

        [TerraformProperty(name: "dns_servers", @out: true, min: 0, max: 1)]
        public string[] @DnsServers { get; }

        [TerraformProperty(name: "subnets", @out: true, min: 0, max: 1)]
        public string[] @Subnets { get; }

        [TerraformProperty(name: "vnet_peerings", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @VnetPeerings { get; }
    }

}
