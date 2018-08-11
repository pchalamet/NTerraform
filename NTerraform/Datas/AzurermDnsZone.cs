using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "azurerm_dns_zone")]
    public sealed class azurerm_dns_zone : NTerraform.data
    {
        public azurerm_dns_zone(string @name)
        {
            @Name = @name;
        }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "max_number_of_record_sets", @out: true, nested: true, min: 0, max: 1)]
        public string @MaxNumberOfRecordSets { get; }

        [TerraformProperty(name: "name_servers", @out: true, nested: true, min: 0, max: 1)]
        public string[] @NameServers { get; }

        [TerraformProperty(name: "number_of_record_sets", @out: true, nested: true, min: 0, max: 1)]
        public string @NumberOfRecordSets { get; }

        [TerraformProperty(name: "registration_virtual_network_ids", @out: true, nested: true, min: 0, max: 1)]
        public string[] @RegistrationVirtualNetworkIds { get; }

        [TerraformProperty(name: "resolution_virtual_network_ids", @out: true, nested: true, min: 0, max: 1)]
        public string[] @ResolutionVirtualNetworkIds { get; }

        [TerraformProperty(name: "resource_group_name", @out: true, nested: true, min: 0, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [TerraformProperty(name: "zone_type", @out: true, nested: true, min: 0, max: 1)]
        public string @ZoneType { get; }
    }

}
