using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_dns_zone")]
    public sealed class azurerm_dns_zone : nterraform.Core.resource
    {
        public azurerm_dns_zone(string @name,
                                string @resourceGroupName,
                                FSharpList<string> @registrationVirtualNetworkIds = null,
                                FSharpList<string> @resolutionVirtualNetworkIds = null,
                                string @zoneType = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @RegistrationVirtualNetworkIds = @registrationVirtualNetworkIds ?? FSharpList<string>.Empty;
            @ResolutionVirtualNetworkIds = @resolutionVirtualNetworkIds ?? FSharpList<string>.Empty;
            @ZoneType = @zoneType;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "max_number_of_record_sets", @out: true, min: 0, max: 1)]
        public string @MaxNumberOfRecordSets { get; }

        [nterraform.Core.TerraformProperty(name: "name_servers", @out: true, min: 0, max: 1)]
        public FSharpList<string> @NameServers { get; }

        [nterraform.Core.TerraformProperty(name: "number_of_record_sets", @out: true, min: 0, max: 1)]
        public string @NumberOfRecordSets { get; }

        [nterraform.Core.TerraformProperty(name: "registration_virtual_network_ids", @out: false, min: 0, max: 1)]
        public FSharpList<string> @RegistrationVirtualNetworkIds { get; }

        [nterraform.Core.TerraformProperty(name: "resolution_virtual_network_ids", @out: false, min: 0, max: 1)]
        public FSharpList<string> @ResolutionVirtualNetworkIds { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpMap<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "zone_type", @out: false, min: 0, max: 1)]
        public string @ZoneType { get; }
    }

}
