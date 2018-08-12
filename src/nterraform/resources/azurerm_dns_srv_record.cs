using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_dns_srv_record")]
    public sealed class azurerm_dns_srv_record : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "record")]
        public sealed class record : nterraform.Core.structure
        {
            public record(int @port,
                          int @priority,
                          string @target,
                          int @weight)
            {
                @Port = @port;
                @Priority = @priority;
                @Target = @target;
                @Weight = @weight;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "port", @out: false, min: 1, max: 1)]
            public int @Port { get; }

            [nterraform.Core.TerraformProperty(name: "priority", @out: false, min: 1, max: 1)]
            public int @Priority { get; }

            [nterraform.Core.TerraformProperty(name: "target", @out: false, min: 1, max: 1)]
            public string @Target { get; }

            [nterraform.Core.TerraformProperty(name: "weight", @out: false, min: 1, max: 1)]
            public int @Weight { get; }
        }

        public azurerm_dns_srv_record(string @name,
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
