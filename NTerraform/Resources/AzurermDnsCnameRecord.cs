using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_dns_cname_record")]
    public sealed class azurerm_dns_cname_record : NTerraform.resource
    {
        public azurerm_dns_cname_record(string @name,
                                        string @record,
                                        string @resourceGroupName,
                                        int @ttl,
                                        string @zoneName,
                                        string @records = null)
        {
            @Name = @name;
            @Record = @record;
            @ResourceGroupName = @resourceGroupName;
            @Ttl = @ttl;
            @ZoneName = @zoneName;
            @Records = @records;
        }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "record", @out: false, min: 1, max: 1)]
        public string @Record { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "ttl", @out: false, min: 1, max: 1)]
        public int @Ttl { get; }

        [TerraformProperty(name: "zone_name", @out: false, min: 1, max: 1)]
        public string @ZoneName { get; }

        [TerraformProperty(name: "records", @out: false, min: 0, max: 1)]
        public string @Records { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
