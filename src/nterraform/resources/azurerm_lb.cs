using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_lb")]
    public sealed class azurerm_lb : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "frontend_ip_configuration")]
        public sealed class frontend_ip_configuration : nterraform.Core.structure
        {
            public frontend_ip_configuration(string @name,
                                             FSharpOption<FSharpList<string>> @zones = null)
            {
                @Name = @name;
                @Zones = @zones ?? FSharpList<string>.Empty;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "inbound_nat_rules", @out: true, min: 0, max: 1)]
            public FSharpOption<FSharpList<string>> @InboundNatRules { get; }

            [nterraform.Core.TerraformProperty(name: "load_balancer_rules", @out: true, min: 0, max: 1)]
            public FSharpOption<FSharpList<string>> @LoadBalancerRules { get; }

            [nterraform.Core.TerraformProperty(name: "private_ip_address", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @PrivateIpAddress { get; }

            [nterraform.Core.TerraformProperty(name: "private_ip_address_allocation", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @PrivateIpAddressAllocation { get; }

            [nterraform.Core.TerraformProperty(name: "public_ip_address_id", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @PublicIpAddressId { get; }

            [nterraform.Core.TerraformProperty(name: "subnet_id", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @SubnetId { get; }

            [nterraform.Core.TerraformProperty(name: "zones", @out: false, min: 0, max: 1)]
            public FSharpOption<FSharpList<string>> @Zones { get; }
        }

        public azurerm_lb(FSharpList<frontend_ip_configuration> @frontendIpConfiguration,
                          string @location,
                          string @name,
                          string @resourceGroupName,
                          FSharpOption<string> @sku = null)
        {
            @FrontendIpConfiguration = @frontendIpConfiguration;
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Sku = @sku;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "frontend_ip_configuration", @out: false, min: 1, max: 0)]
        public FSharpList<frontend_ip_configuration> @FrontendIpConfiguration { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "private_ip_address", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @PrivateIpAddress { get; }

        [nterraform.Core.TerraformProperty(name: "private_ip_addresses", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpList<string>> @PrivateIpAddresses { get; }

        [nterraform.Core.TerraformProperty(name: "sku", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @Sku { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpMap<string,string>> @Tags { get; }
    }

}
