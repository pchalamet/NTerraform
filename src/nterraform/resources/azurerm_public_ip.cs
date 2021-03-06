using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_public_ip")]
    public sealed class azurerm_public_ip : nterraform.resource
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "public_ip_address_allocation", @out: false, min: 1, max: 1)]
        public string @PublicIpAddressAllocation { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "domain_name_label", @out: false, min: 0, max: 1)]
        public string @DomainNameLabel { get; }

        [nterraform.TerraformProperty(name: "fqdn", @out: true, min: 0, max: 1)]
        public string @Fqdn { get; }

        [nterraform.TerraformProperty(name: "idle_timeout_in_minutes", @out: false, min: 0, max: 1)]
        public int? @IdleTimeoutInMinutes { get; }

        [nterraform.TerraformProperty(name: "ip_address", @out: true, min: 0, max: 1)]
        public string @IpAddress { get; }

        [nterraform.TerraformProperty(name: "reverse_fqdn", @out: false, min: 0, max: 1)]
        public string @ReverseFqdn { get; }

        [nterraform.TerraformProperty(name: "sku", @out: false, min: 0, max: 1)]
        public string @Sku { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "zones", @out: false, min: 0, max: 1)]
        public string[] @Zones { get; }
    }

}
