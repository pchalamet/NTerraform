using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_dns_zone")]
    public sealed class azurerm_dns_zone : nterraform.Core.data
    {
        public azurerm_dns_zone(string @name)
        {
            @Name = @name;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "max_number_of_record_sets", @out: true, min: 0, max: 1)]
        public string @MaxNumberOfRecordSets { get; }

        [nterraform.Core.TerraformProperty(name: "name_servers", @out: true, min: 0, max: 1)]
        public string[] @NameServers { get; }

        [nterraform.Core.TerraformProperty(name: "number_of_record_sets", @out: true, min: 0, max: 1)]
        public string @NumberOfRecordSets { get; }

        [nterraform.Core.TerraformProperty(name: "registration_virtual_network_ids", @out: true, min: 0, max: 1)]
        public string[] @RegistrationVirtualNetworkIds { get; }

        [nterraform.Core.TerraformProperty(name: "resolution_virtual_network_ids", @out: true, min: 0, max: 1)]
        public string[] @ResolutionVirtualNetworkIds { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: true, min: 0, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "zone_type", @out: true, min: 0, max: 1)]
        public string @ZoneType { get; }
    }

}
