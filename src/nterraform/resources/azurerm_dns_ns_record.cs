using System.Collections.Generic;

namespace nterraform.resources.azurerm
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_dns_ns_record")]
    public sealed class azurerm_dns_ns_record : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "record")]
        public sealed class record : nterraform.Core.structure
        {
            public record(string @nsdname)
            {
                @Nsdname = @nsdname;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "nsdname", @out: false, min: 1, max: 1)]
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
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "ttl", @out: false, min: 1, max: 1)]
        public int @Ttl { get; }

        [nterraform.Core.TerraformProperty(name: "zone_name", @out: false, min: 1, max: 1)]
        public string @ZoneName { get; }

        [nterraform.Core.TerraformProperty(name: "record", @out: false, min: 0, max: 0)]
        public record[] @Record { get; }

        [nterraform.Core.TerraformProperty(name: "records", @out: true, min: 0, max: 1)]
        public string[] @Records { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}