using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_dns_caa_record")]
    public sealed class azurerm_dns_caa_record : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "record")]
        public sealed class record : nterraform.Core.structure
        {
            public record(int @flags,
                          string @tag,
                          string @value)
            {
                @Flags = @flags;
                @Tag = @tag;
                @Value = @value;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "flags", @out: false, min: 1, max: 1)]
            public int @Flags { get; }

            [nterraform.Core.TerraformProperty(name: "tag", @out: false, min: 1, max: 1)]
            public string @Tag { get; }

            [nterraform.Core.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
            public string @Value { get; }
        }

        public azurerm_dns_caa_record(string @name,
                                      FSharpList<record> @record,
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
        public FSharpList<record> @Record { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "ttl", @out: false, min: 1, max: 1)]
        public int @Ttl { get; }

        [nterraform.Core.TerraformProperty(name: "zone_name", @out: false, min: 1, max: 1)]
        public string @ZoneName { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpMap<string,string>> @Tags { get; }
    }

}
