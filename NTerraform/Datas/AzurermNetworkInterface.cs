using System.Collections.Generic;

namespace NTerraform.Datas
{
    public class azurerm_network_interface : NTerraform.data
    {
        public class ip_configuration
        {
            public ip_configuration()
            {
            }

            public string[] @ApplicationGatewayBackendAddressPoolsIds { get; }
            public string[] @LoadBalancerBackendAddressPoolsIds { get; }
            public string[] @LoadBalancerInboundNatRulesIds { get; }
            public string @Name { get; }
            public bool? @Primary { get; }
            public string @PrivateIpAddress { get; }
            public string @PrivateIpAddressAllocation { get; }
            public string @PublicIpAddressId { get; }
            public string @SubnetId { get; }
        }

        public azurerm_network_interface(string @name,
                                         string @resourceGroupName,
                                         ip_configuration[] @ipConfiguration = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @IpConfiguration = @ipConfiguration;
        }

        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string[] @AppliedDnsServers { get; }
        public string[] @DnsServers { get; }
        public bool? @EnableAcceleratedNetworking { get; }
        public bool? @EnableIpForwarding { get; }
        public string @InternalDnsNameLabel { get; }
        public string @InternalFqdn { get; }
        public ip_configuration[] @IpConfiguration { get; }
        public string @Location { get; }
        public string @MacAddress { get; }
        public string @NetworkSecurityGroupId { get; }
        public string @PrivateIpAddress { get; }
        public string[] @PrivateIpAddresses { get; }
        public Dictionary<string,string> @Tags { get; }
        public string @VirtualMachineId { get; }
    }

}
