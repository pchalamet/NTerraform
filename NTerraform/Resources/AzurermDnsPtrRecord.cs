using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_dns_ptr_record")]
    public sealed class azurerm_dns_ptr_record : NTerraform.resource
    {
        public azurerm_dns_ptr_record(string @name,
                                      string[] @records,
                                      string @resourceGroupName,
                                      int @ttl,
                                      string @zoneName)
        {
            @Name = @name;
            @Records = @records;
            @ResourceGroupName = @resourceGroupName;
            @Ttl = @ttl;
            @ZoneName = @zoneName;
        }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "records", @out: false, nested: true, min: 1, max: 1)]
        public string[] @Records { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "ttl", @out: false, nested: true, min: 1, max: 1)]
        public int @Ttl { get; }

        [TerraformProperty(name: "zone_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ZoneName { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
