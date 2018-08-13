using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_dns_zone")]
    public sealed class azurerm_dns_zone : nterraform.resource
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "max_number_of_record_sets", @out: true, min: 0, max: 1)]
        public string @MaxNumberOfRecordSets { get; }

        [nterraform.TerraformProperty(name: "name_servers", @out: true, min: 0, max: 1)]
        public string[] @NameServers { get; }

        [nterraform.TerraformProperty(name: "number_of_record_sets", @out: true, min: 0, max: 1)]
        public string @NumberOfRecordSets { get; }

        [nterraform.TerraformProperty(name: "registration_virtual_network_ids", @out: false, min: 0, max: 1)]
        public string[] @RegistrationVirtualNetworkIds { get; }

        [nterraform.TerraformProperty(name: "resolution_virtual_network_ids", @out: false, min: 0, max: 1)]
        public string[] @ResolutionVirtualNetworkIds { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "zone_type", @out: false, min: 0, max: 1)]
        public string @ZoneType { get; }
    }

}
