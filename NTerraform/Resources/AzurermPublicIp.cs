using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_public_ip")]
    public sealed class azurerm_public_ip : NTerraform.resource
    {
        public azurerm_public_ip(string @location,
                                 string @name,
                                 string @publicIpAddressAllocation,
                                 string @resourceGroupName,
                                 string @domainNameLabel = null,
                                 int? @idleTimeoutInMinutes = null,
                                 string @reverseFqdn = null,
                                 string @sku = null,
                                 string[] @zones = null)
        {
            @Location = @location;
            @Name = @name;
            @PublicIpAddressAllocation = @publicIpAddressAllocation;
            @ResourceGroupName = @resourceGroupName;
            @DomainNameLabel = @domainNameLabel;
            @IdleTimeoutInMinutes = @idleTimeoutInMinutes;
            @ReverseFqdn = @reverseFqdn;
            @Sku = @sku;
            @Zones = @zones;
        }

        [TerraformProperty(name: "location", @out: false, nested: true, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "public_ip_address_allocation", @out: false, nested: true, min: 1, max: 1)]
        public string @PublicIpAddressAllocation { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "domain_name_label", @out: false, nested: true, min: 0, max: 1)]
        public string @DomainNameLabel { get; }

        [TerraformProperty(name: "fqdn", @out: true, nested: true, min: 0, max: 1)]
        public string @Fqdn { get; }

        [TerraformProperty(name: "idle_timeout_in_minutes", @out: false, nested: true, min: 0, max: 1)]
        public int? @IdleTimeoutInMinutes { get; }

        [TerraformProperty(name: "ip_address", @out: true, nested: true, min: 0, max: 1)]
        public string @IpAddress { get; }

        [TerraformProperty(name: "reverse_fqdn", @out: false, nested: true, min: 0, max: 1)]
        public string @ReverseFqdn { get; }

        [TerraformProperty(name: "sku", @out: false, nested: true, min: 0, max: 1)]
        public string @Sku { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [TerraformProperty(name: "zones", @out: false, nested: true, min: 0, max: 1)]
        public string[] @Zones { get; }
    }

}
