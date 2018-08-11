using System.Collections.Generic;

namespace NTerraform.Datas
{
    public class azurerm_subnet : NTerraform.data
    {
        public azurerm_subnet(string @name,
                              string @resourceGroupName,
                              string @virtualNetworkName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @VirtualNetworkName = @virtualNetworkName;
        }

        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @VirtualNetworkName { get; }
        public string @AddressPrefix { get; }
        public string[] @IpConfigurations { get; }
        public string @NetworkSecurityGroupId { get; }
        public string @RouteTableId { get; }
    }

}
