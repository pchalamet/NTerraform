using System.Collections.Generic;

namespace NTerraform.Resources
{
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

        public string @Location { get; }
        public string @Name { get; }
        public string @PublicIpAddressAllocation { get; }
        public string @ResourceGroupName { get; }
        public string @DomainNameLabel { get; }
        public string @Fqdn { get; }
        public int? @IdleTimeoutInMinutes { get; }
        public string @IpAddress { get; }
        public string @ReverseFqdn { get; }
        public string @Sku { get; }
        public Dictionary<string,string> @Tags { get; }
        public string[] @Zones { get; }
    }

}
