using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_lb")]
    public sealed class azurerm_lb : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "frontend_ip_configuration")]
        public sealed class frontend_ip_configuration
        {
            public frontend_ip_configuration(string @name,
                                             string[] @zones = null)
            {
                @Name = @name;
                @Zones = @zones;
            }

            [TerraformProperty(name: "name", @out: false, nested: false, min: 1, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "inbound_nat_rules", @out: true, nested: false, min: 0, max: 1)]
            public string[] @InboundNatRules { get; }

            [TerraformProperty(name: "load_balancer_rules", @out: true, nested: false, min: 0, max: 1)]
            public string[] @LoadBalancerRules { get; }

            [TerraformProperty(name: "private_ip_address", @out: true, nested: false, min: 0, max: 1)]
            public string @PrivateIpAddress { get; }

            [TerraformProperty(name: "private_ip_address_allocation", @out: true, nested: false, min: 0, max: 1)]
            public string @PrivateIpAddressAllocation { get; }

            [TerraformProperty(name: "public_ip_address_id", @out: true, nested: false, min: 0, max: 1)]
            public string @PublicIpAddressId { get; }

            [TerraformProperty(name: "subnet_id", @out: true, nested: false, min: 0, max: 1)]
            public string @SubnetId { get; }

            [TerraformProperty(name: "zones", @out: false, nested: false, min: 0, max: 1)]
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

        [TerraformProperty(name: "frontend_ip_configuration", @out: false, nested: true, min: 1, max: 0)]
        public frontend_ip_configuration[] @FrontendIpConfiguration { get; }

        [TerraformProperty(name: "location", @out: false, nested: true, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "private_ip_address", @out: true, nested: true, min: 0, max: 1)]
        public string @PrivateIpAddress { get; }

        [TerraformProperty(name: "private_ip_addresses", @out: true, nested: true, min: 0, max: 1)]
        public string[] @PrivateIpAddresses { get; }

        [TerraformProperty(name: "sku", @out: false, nested: true, min: 0, max: 1)]
        public string @Sku { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
