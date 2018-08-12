using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_public_ip")]
    public sealed class azurerm_public_ip : nterraform.Core.resource
    {
        public azurerm_public_ip(string @location,
                                 string @name,
                                 string @publicIpAddressAllocation,
                                 string @resourceGroupName,
                                 FSharpOption<string> @domainNameLabel = null,
                                 FSharpOption<int> @idleTimeoutInMinutes = null,
                                 FSharpOption<string> @reverseFqdn = null,
                                 FSharpOption<string> @sku = null,
                                 FSharpOption<FSharpList<string>> @zones = null)
        {
            @Location = @location;
            @Name = @name;
            @PublicIpAddressAllocation = @publicIpAddressAllocation;
            @ResourceGroupName = @resourceGroupName;
            @DomainNameLabel = @domainNameLabel;
            @IdleTimeoutInMinutes = @idleTimeoutInMinutes;
            @ReverseFqdn = @reverseFqdn;
            @Sku = @sku;
            @Zones = @zones ?? FSharpList<string>.Empty;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "public_ip_address_allocation", @out: false, min: 1, max: 1)]
        public string @PublicIpAddressAllocation { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "domain_name_label", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @DomainNameLabel { get; }

        [nterraform.Core.TerraformProperty(name: "fqdn", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Fqdn { get; }

        [nterraform.Core.TerraformProperty(name: "idle_timeout_in_minutes", @out: false, min: 0, max: 1)]
        public FSharpOption<int> @IdleTimeoutInMinutes { get; }

        [nterraform.Core.TerraformProperty(name: "ip_address", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @IpAddress { get; }

        [nterraform.Core.TerraformProperty(name: "reverse_fqdn", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @ReverseFqdn { get; }

        [nterraform.Core.TerraformProperty(name: "sku", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @Sku { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpMap<string,string>> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "zones", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpList<string>> @Zones { get; }
    }

}
