using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "consul_service")]
    public sealed class consul_service : NTerraform.resource
    {
        public consul_service(string @name,
                              string @node,
                              int? @port = null,
                              string[] @tags = null)
        {
            @Name = @name;
            @Node = @node;
            @Port = @port;
            @Tags = @tags;
            base._validate_();
        }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "node", @out: false, min: 1, max: 1)]
        public string @Node { get; }

        [TerraformProperty(name: "address", @out: true, min: 0, max: 1)]
        public string @Address { get; }

        [TerraformProperty(name: "datacenter", @out: true, min: 0, max: 1)]
        public string @Datacenter { get; }

        [TerraformProperty(name: "port", @out: false, min: 0, max: 1)]
        public int? @Port { get; }

        [TerraformProperty(name: "service_id", @out: true, min: 0, max: 1)]
        public string @ServiceId { get; }

        [TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public string[] @Tags { get; }
    }

}
