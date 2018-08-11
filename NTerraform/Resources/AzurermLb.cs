using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_lb : NTerraform.resource
    {
        public class frontend_ip_configuration
        {
            public frontend_ip_configuration(string @name,
                                             string[] @zones = null)
            {
                @Name = @name;
                @Zones = @zones;
            }

            public string @Name { get; }
            public string[] @InboundNatRules { get; }
            public string[] @LoadBalancerRules { get; }
            public string @PrivateIpAddress { get; }
            public string @PrivateIpAddressAllocation { get; }
            public string @PublicIpAddressId { get; }
            public string @SubnetId { get; }
            public string[] @Zones { get; }
        }

        public azurerm_lb(frontend_ip_configuration[] @frontendIpConfiguration,
                          string @location,
                          string @name,
                          string @resourceGroupName,
                          string @sku = null)
        {
            @FrontendIpConfiguration = @frontendIpConfiguration;
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Sku = @sku;
        }

        public frontend_ip_configuration[] @FrontendIpConfiguration { get; }
        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @PrivateIpAddress { get; }
        public string[] @PrivateIpAddresses { get; }
        public string @Sku { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
