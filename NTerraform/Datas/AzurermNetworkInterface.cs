using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "azurerm_network_interface")]
    public sealed class azurerm_network_interface : NTerraform.data
    {
        [TerraformStructure(category: "", typeName: "ip_configuration")]
        public sealed class ip_configuration
        {
            public ip_configuration()
            {
            }

            [TerraformProperty(name: "application_gateway_backend_address_pools_ids", @out: true, nested: false, min: 0, max: 1)]
            public string[] @ApplicationGatewayBackendAddressPoolsIds { get; }

            [TerraformProperty(name: "load_balancer_backend_address_pools_ids", @out: true, nested: false, min: 0, max: 1)]
            public string[] @LoadBalancerBackendAddressPoolsIds { get; }

            [TerraformProperty(name: "load_balancer_inbound_nat_rules_ids", @out: true, nested: false, min: 0, max: 1)]
            public string[] @LoadBalancerInboundNatRulesIds { get; }

            [TerraformProperty(name: "name", @out: true, nested: false, min: 0, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "primary", @out: true, nested: false, min: 0, max: 1)]
            public bool? @Primary { get; }

            [TerraformProperty(name: "private_ip_address", @out: true, nested: false, min: 0, max: 1)]
            public string @PrivateIpAddress { get; }

            [TerraformProperty(name: "private_ip_address_allocation", @out: true, nested: false, min: 0, max: 1)]
            public string @PrivateIpAddressAllocation { get; }

            [TerraformProperty(name: "public_ip_address_id", @out: true, nested: false, min: 0, max: 1)]
            public string @PublicIpAddressId { get; }

            [TerraformProperty(name: "subnet_id", @out: true, nested: false, min: 0, max: 1)]
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

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "applied_dns_servers", @out: true, nested: true, min: 0, max: 1)]
        public string[] @AppliedDnsServers { get; }

        [TerraformProperty(name: "dns_servers", @out: true, nested: true, min: 0, max: 1)]
        public string[] @DnsServers { get; }

        [TerraformProperty(name: "enable_accelerated_networking", @out: true, nested: true, min: 0, max: 1)]
        public bool? @EnableAcceleratedNetworking { get; }

        [TerraformProperty(name: "enable_ip_forwarding", @out: true, nested: true, min: 0, max: 1)]
        public bool? @EnableIpForwarding { get; }

        [TerraformProperty(name: "internal_dns_name_label", @out: true, nested: true, min: 0, max: 1)]
        public string @InternalDnsNameLabel { get; }

        [TerraformProperty(name: "internal_fqdn", @out: true, nested: true, min: 0, max: 1)]
        public string @InternalFqdn { get; }

        [TerraformProperty(name: "ip_configuration", @out: false, nested: true, min: 0, max: 0)]
        public ip_configuration[] @IpConfiguration { get; }

        [TerraformProperty(name: "location", @out: true, nested: true, min: 0, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "mac_address", @out: true, nested: true, min: 0, max: 1)]
        public string @MacAddress { get; }

        [TerraformProperty(name: "network_security_group_id", @out: true, nested: true, min: 0, max: 1)]
        public string @NetworkSecurityGroupId { get; }

        [TerraformProperty(name: "private_ip_address", @out: true, nested: true, min: 0, max: 1)]
        public string @PrivateIpAddress { get; }

        [TerraformProperty(name: "private_ip_addresses", @out: true, nested: true, min: 0, max: 1)]
        public string[] @PrivateIpAddresses { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [TerraformProperty(name: "virtual_machine_id", @out: true, nested: true, min: 0, max: 1)]
        public string @VirtualMachineId { get; }
    }

}
