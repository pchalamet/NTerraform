using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_dns_ns_record")]
    public sealed class azurerm_dns_ns_record : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "record")]
        public sealed class record
        {
            public record(string @nsdname)
            {
                @Nsdname = @nsdname;
            }

            [TerraformProperty(name: "nsdname", @out: false, nested: false, min: 1, max: 1)]
            public string @Nsdname { get; }
        }

        public azurerm_dns_ns_record(string @name,
                                     string @resourceGroupName,
                                     int @ttl,
                                     string @zoneName,
                                     record[] @record = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Ttl = @ttl;
            @ZoneName = @zoneName;
            @Record = @record;
        }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "ttl", @out: false, nested: true, min: 1, max: 1)]
        public int @Ttl { get; }

        [TerraformProperty(name: "zone_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ZoneName { get; }

        [TerraformProperty(name: "record", @out: false, nested: true, min: 0, max: 0)]
        public record[] @Record { get; }

        [TerraformProperty(name: "records", @out: true, nested: true, min: 0, max: 1)]
        public string[] @Records { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
