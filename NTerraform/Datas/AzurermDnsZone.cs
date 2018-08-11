using System.Collections.Generic;

namespace NTerraform.Datas
{
    public class azurerm_dns_zone : NTerraform.data
    {
        public azurerm_dns_zone(string @name)
        {
            @Name = @name;
        }

        public string @Name { get; }
        public string @MaxNumberOfRecordSets { get; }
        public string[] @NameServers { get; }
        public string @NumberOfRecordSets { get; }
        public string[] @RegistrationVirtualNetworkIds { get; }
        public string[] @ResolutionVirtualNetworkIds { get; }
        public string @ResourceGroupName { get; }
        public Dictionary<string,string> @Tags { get; }
        public string @ZoneType { get; }
    }

}
