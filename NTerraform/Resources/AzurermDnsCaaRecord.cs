using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_dns_caa_record")]
    public sealed class azurerm_dns_caa_record : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "record")]
        public sealed class record
        {
            public record(int @flags,
                          string @tag,
                          string @value)
            {
                @Flags = @flags;
                @Tag = @tag;
                @Value = @value;
            }

            [TerraformProperty(name: "flags", @out: false, min: 1, max: 1)]
            public int @Flags { get; }

            [TerraformProperty(name: "tag", @out: false, min: 1, max: 1)]
            public string @Tag { get; }

            [TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
            public string @Value { get; }
        }

        public azurerm_dns_caa_record(string @name,
                                      record[] @record,
                                      string @resourceGroupName,
                                      int @ttl,
                                      string @zoneName)
        {
            @Name = @name;
            @Record = @record;
            @ResourceGroupName = @resourceGroupName;
            @Ttl = @ttl;
            @ZoneName = @zoneName;
        }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "record", @out: false, min: 1, max: 0)]
        public record[] @Record { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "ttl", @out: false, min: 1, max: 1)]
        public int @Ttl { get; }

        [TerraformProperty(name: "zone_name", @out: false, min: 1, max: 1)]
        public string @ZoneName { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
