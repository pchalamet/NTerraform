using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_dns_srv_record")]
    public sealed class azurerm_dns_srv_record : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "record")]
        public sealed class record : nterraform.structure
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

            [nterraform.TerraformProperty(name: "port", @out: false, min: 1, max: 1)]
            public int @Port { get; }

            [nterraform.TerraformProperty(name: "priority", @out: false, min: 1, max: 1)]
            public int @Priority { get; }

            [nterraform.TerraformProperty(name: "target", @out: false, min: 1, max: 1)]
            public string @Target { get; }

            [nterraform.TerraformProperty(name: "weight", @out: false, min: 1, max: 1)]
            public int @Weight { get; }
        }

        public azurerm_dns_srv_record(string @name,
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

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "record", @out: false, min: 1, max: 0)]
        public record[] @Record { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "ttl", @out: false, min: 1, max: 1)]
        public int @Ttl { get; }

        [nterraform.TerraformProperty(name: "zone_name", @out: false, min: 1, max: 1)]
        public string @ZoneName { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
