using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_dns_mx_record")]
    public sealed class azurerm_dns_mx_record : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "record")]
        public sealed class record
        {
            public record(string @exchange,
                          string @preference)
            {
                @Exchange = @exchange;
                @Preference = @preference;
            }

            [TerraformProperty(name: "exchange", @out: false, nested: false, min: 1, max: 1)]
            public string @Exchange { get; }

            [TerraformProperty(name: "preference", @out: false, nested: false, min: 1, max: 1)]
            public string @Preference { get; }
        }

        public azurerm_dns_mx_record(string @name,
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

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "record", @out: false, nested: true, min: 1, max: 0)]
        public record[] @Record { get; }

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
