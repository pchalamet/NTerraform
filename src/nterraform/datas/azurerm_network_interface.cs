using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_network_interface")]
    public sealed class azurerm_network_interface : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "ip_configuration")]
        public sealed class ip_configuration : nterraform.Core.structure
        {
            public ip_configuration()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "application_gateway_backend_address_pools_ids", @out: true, min: 0, max: 1)]
            public FSharpOption<FSharpList<string>> @ApplicationGatewayBackendAddressPoolsIds { get; }

            [nterraform.Core.TerraformProperty(name: "load_balancer_backend_address_pools_ids", @out: true, min: 0, max: 1)]
            public FSharpOption<FSharpList<string>> @LoadBalancerBackendAddressPoolsIds { get; }

            [nterraform.Core.TerraformProperty(name: "load_balancer_inbound_nat_rules_ids", @out: true, min: 0, max: 1)]
            public FSharpOption<FSharpList<string>> @LoadBalancerInboundNatRulesIds { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Name { get; }

            [nterraform.Core.TerraformProperty(name: "primary", @out: true, min: 0, max: 1)]
            public FSharpOption<bool> @Primary { get; }

            [nterraform.Core.TerraformProperty(name: "private_ip_address", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @PrivateIpAddress { get; }

            [nterraform.Core.TerraformProperty(name: "private_ip_address_allocation", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @PrivateIpAddressAllocation { get; }

            [nterraform.Core.TerraformProperty(name: "public_ip_address_id", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @PublicIpAddressId { get; }

            [nterraform.Core.TerraformProperty(name: "subnet_id", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @SubnetId { get; }
        }

        public azurerm_network_interface(string @name,
                                         string @resourceGroupName,
                                         FSharpOption<FSharpList<ip_configuration>> @ipConfiguration = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @IpConfiguration = @ipConfiguration ?? FSharpList<ip_configuration>.Empty;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "applied_dns_servers", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpList<string>> @AppliedDnsServers { get; }

        [nterraform.Core.TerraformProperty(name: "dns_servers", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpList<string>> @DnsServers { get; }

        [nterraform.Core.TerraformProperty(name: "enable_accelerated_networking", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @EnableAcceleratedNetworking { get; }

        [nterraform.Core.TerraformProperty(name: "enable_ip_forwarding", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @EnableIpForwarding { get; }

        [nterraform.Core.TerraformProperty(name: "internal_dns_name_label", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @InternalDnsNameLabel { get; }

        [nterraform.Core.TerraformProperty(name: "internal_fqdn", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @InternalFqdn { get; }

        [nterraform.Core.TerraformProperty(name: "ip_configuration", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpList<ip_configuration>> @IpConfiguration { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Location { get; }

        [nterraform.Core.TerraformProperty(name: "mac_address", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @MacAddress { get; }

        [nterraform.Core.TerraformProperty(name: "network_security_group_id", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @NetworkSecurityGroupId { get; }

        [nterraform.Core.TerraformProperty(name: "private_ip_address", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @PrivateIpAddress { get; }

        [nterraform.Core.TerraformProperty(name: "private_ip_addresses", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpList<string>> @PrivateIpAddresses { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpMap<string,string>> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "virtual_machine_id", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @VirtualMachineId { get; }
    }

}
