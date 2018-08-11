using System.Collections.Generic;

namespace NTerraform.Datas
{
    public sealed class azurerm_virtual_network : NTerraform.data
    {
        public azurerm_virtual_network(string @name,
                                       string @resourceGroupName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
        }

        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string[] @AddressSpaces { get; }
        public string[] @DnsServers { get; }
        public string[] @Subnets { get; }
        public Dictionary<string,string> @VnetPeerings { get; }
    }

}
