using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_dns_zone : NTerraform.resource
    {
        public azurerm_dns_zone(string @name,
                                string @resourceGroupName,
                                List<string> @registrationVirtualNetworkIds = null,
                                List<string> @resolutionVirtualNetworkIds = null,
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
        public HashSet<string> @NameServers { get; }
        public string @NumberOfRecordSets { get; }
        public List<string> @RegistrationVirtualNetworkIds { get; }
        public List<string> @ResolutionVirtualNetworkIds { get; }
        public Dictionary<string,string> @Tags { get; }
        public string @ZoneType { get; }
    }

}
