using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_network_interface : NTerraform.resource
    {
        public sealed class ip_configuration
        {
            public ip_configuration(string @name,
                                    string @privateIpAddressAllocation,
                                    string @subnetId,
                                    string @privateIpAddress = null,
                                    string @publicIpAddressId = null)
            {
                @Name = @name;
                @PrivateIpAddressAllocation = @privateIpAddressAllocation;
                @SubnetId = @subnetId;
                @PrivateIpAddress = @privateIpAddress;
                @PublicIpAddressId = @publicIpAddressId;
            }

            public string @Name { get; }
            public string @PrivateIpAddressAllocation { get; }
            public string @SubnetId { get; }
            public string[] @ApplicationGatewayBackendAddressPoolsIds { get; }
            public string[] @ApplicationSecurityGroupIds { get; }
            public string[] @LoadBalancerBackendAddressPoolsIds { get; }
            public string[] @LoadBalancerInboundNatRulesIds { get; }
            public bool? @Primary { get; }
            public string @PrivateIpAddress { get; }
            public string @PublicIpAddressId { get; }
        }

        public azurerm_network_interface(ip_configuration[] @ipConfiguration,
                                         string @location,
                                         string @name,
                                         string @resourceGroupName,
                                         bool? @enableAcceleratedNetworking = null,
                                         bool? @enableIpForwarding = null,
                                         string @networkSecurityGroupId = null)
        {
            @IpConfiguration = @ipConfiguration;
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @EnableAcceleratedNetworking = @enableAcceleratedNetworking;
            @EnableIpForwarding = @enableIpForwarding;
            @NetworkSecurityGroupId = @networkSecurityGroupId;
        }

        public ip_configuration[] @IpConfiguration { get; }
        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string[] @AppliedDnsServers { get; }
        public string[] @DnsServers { get; }
        public bool? @EnableAcceleratedNetworking { get; }
        public bool? @EnableIpForwarding { get; }
        public string @InternalDnsNameLabel { get; }
        public string @InternalFqdn { get; }
        public string @MacAddress { get; }
        public string @NetworkSecurityGroupId { get; }
        public string @PrivateIpAddress { get; }
        public string[] @PrivateIpAddresses { get; }
        public Dictionary<string,string> @Tags { get; }
        public string @VirtualMachineId { get; }
    }

}
