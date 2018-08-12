using System.Collections.Generic;

namespace nterraform.resources.azurerm
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_dns_mx_record")]
    public sealed class azurerm_dns_mx_record : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "record")]
        public sealed class record : nterraform.Core.structure
        {
            public record(string @exchange,
                          string @preference)
            {
                @Exchange = @exchange;
                @Preference = @preference;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "exchange", @out: false, min: 1, max: 1)]
            public string @Exchange { get; }

            [nterraform.Core.TerraformProperty(name: "preference", @out: false, min: 1, max: 1)]
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
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "record", @out: false, min: 1, max: 0)]
        public record[] @Record { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "ttl", @out: false, min: 1, max: 1)]
        public int @Ttl { get; }

        [nterraform.Core.TerraformProperty(name: "zone_name", @out: false, min: 1, max: 1)]
        public string @ZoneName { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
