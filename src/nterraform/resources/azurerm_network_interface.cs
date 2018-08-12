using System.Collections.Generic;

namespace nterraform.resources.azurerm
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_network_interface")]
    public sealed class azurerm_network_interface : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "ip_configuration")]
        public sealed class ip_configuration : nterraform.Core.structure
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
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "private_ip_address_allocation", @out: false, min: 1, max: 1)]
            public string @PrivateIpAddressAllocation { get; }

            [nterraform.Core.TerraformProperty(name: "subnet_id", @out: false, min: 1, max: 1)]
            public string @SubnetId { get; }

            [nterraform.Core.TerraformProperty(name: "application_gateway_backend_address_pools_ids", @out: true, min: 0, max: 1)]
            public string[] @ApplicationGatewayBackendAddressPoolsIds { get; }

            [nterraform.Core.TerraformProperty(name: "application_security_group_ids", @out: true, min: 0, max: 1)]
            public string[] @ApplicationSecurityGroupIds { get; }

            [nterraform.Core.TerraformProperty(name: "load_balancer_backend_address_pools_ids", @out: true, min: 0, max: 1)]
            public string[] @LoadBalancerBackendAddressPoolsIds { get; }

            [nterraform.Core.TerraformProperty(name: "load_balancer_inbound_nat_rules_ids", @out: true, min: 0, max: 1)]
            public string[] @LoadBalancerInboundNatRulesIds { get; }

            [nterraform.Core.TerraformProperty(name: "primary", @out: true, min: 0, max: 1)]
            public bool? @Primary { get; }

            [nterraform.Core.TerraformProperty(name: "private_ip_address", @out: false, min: 0, max: 1)]
            public string @PrivateIpAddress { get; }

            [nterraform.Core.TerraformProperty(name: "public_ip_address_id", @out: false, min: 0, max: 1)]
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
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "ip_configuration", @out: false, min: 1, max: 0)]
        public ip_configuration[] @IpConfiguration { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "applied_dns_servers", @out: true, min: 0, max: 1)]
        public string[] @AppliedDnsServers { get; }

        [nterraform.Core.TerraformProperty(name: "dns_servers", @out: true, min: 0, max: 1)]
        public string[] @DnsServers { get; }

        [nterraform.Core.TerraformProperty(name: "enable_accelerated_networking", @out: false, min: 0, max: 1)]
        public bool? @EnableAcceleratedNetworking { get; }

        [nterraform.Core.TerraformProperty(name: "enable_ip_forwarding", @out: false, min: 0, max: 1)]
        public bool? @EnableIpForwarding { get; }

        [nterraform.Core.TerraformProperty(name: "internal_dns_name_label", @out: true, min: 0, max: 1)]
        public string @InternalDnsNameLabel { get; }

        [nterraform.Core.TerraformProperty(name: "internal_fqdn", @out: true, min: 0, max: 1)]
        public string @InternalFqdn { get; }

        [nterraform.Core.TerraformProperty(name: "mac_address", @out: true, min: 0, max: 1)]
        public string @MacAddress { get; }

        [nterraform.Core.TerraformProperty(name: "network_security_group_id", @out: false, min: 0, max: 1)]
        public string @NetworkSecurityGroupId { get; }

        [nterraform.Core.TerraformProperty(name: "private_ip_address", @out: true, min: 0, max: 1)]
        public string @PrivateIpAddress { get; }

        [nterraform.Core.TerraformProperty(name: "private_ip_addresses", @out: true, min: 0, max: 1)]
        public string[] @PrivateIpAddresses { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "virtual_machine_id", @out: true, min: 0, max: 1)]
        public string @VirtualMachineId { get; }
    }

}
