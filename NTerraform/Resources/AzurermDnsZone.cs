using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_dns_zone : NTerraform.resource
    {
        public azurerm_dns_zone(string @name,
                                string @resourceGroupName,
                                string[] @registrationVirtualNetworkIds = null,
                                string[] @resolutionVirtualNetworkIds = null,
                                string @zoneType = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @RegistrationVirtualNetworkIds = @registrationVirtualNetworkIds;
            @ResolutionVirtualNetworkIds = @resolutionVirtualNetworkIds;
            @ZoneType = @zoneType;
        }

        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @MaxNumberOfRecordSets { get; }
        public string[] @NameServers { get; }
        public string @NumberOfRecordSets { get; }
        public string[] @RegistrationVirtualNetworkIds { get; }
        public string[] @ResolutionVirtualNetworkIds { get; }
        public Dictionary<string,string> @Tags { get; }
        public string @ZoneType { get; }
    }

}
