using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "azurerm_virtual_network")]
    public sealed class azurerm_virtual_network : nterraform.data
    {
        public azurerm_virtual_network(string @name,
                                       string @resourceGroupName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "address_spaces", @out: true, min: 0, max: 1)]
        public string[] @AddressSpaces { get; }

        [nterraform.TerraformProperty(name: "dns_servers", @out: true, min: 0, max: 1)]
        public string[] @DnsServers { get; }

        [nterraform.TerraformProperty(name: "subnets", @out: true, min: 0, max: 1)]
        public string[] @Subnets { get; }

        [nterraform.TerraformProperty(name: "vnet_peerings", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @VnetPeerings { get; }
    }

}
