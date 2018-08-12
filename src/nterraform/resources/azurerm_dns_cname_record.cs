using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_dns_cname_record")]
    public sealed class azurerm_dns_cname_record : nterraform.Core.resource
    {
        public azurerm_dns_cname_record(string @name,
                                        string @record,
                                        string @resourceGroupName,
                                        int @ttl,
                                        string @zoneName,
                                        FSharpOption<string> @records = null)
        {
            @Name = @name;
            @Record = @record;
            @ResourceGroupName = @resourceGroupName;
            @Ttl = @ttl;
            @ZoneName = @zoneName;
            @Records = @records;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "record", @out: false, min: 1, max: 1)]
        public string @Record { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "ttl", @out: false, min: 1, max: 1)]
        public int @Ttl { get; }

        [nterraform.Core.TerraformProperty(name: "zone_name", @out: false, min: 1, max: 1)]
        public string @ZoneName { get; }

        [nterraform.Core.TerraformProperty(name: "records", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @Records { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpMap<string,string>> @Tags { get; }
    }

}
