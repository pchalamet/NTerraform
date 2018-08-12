using System.Collections.Generic;

namespace nterraform.resources.consul
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "consul_service")]
    public sealed class consul_service : nterraform.Core.resource
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

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "node", @out: false, min: 1, max: 1)]
        public string @Node { get; }

        [nterraform.Core.TerraformProperty(name: "address", @out: true, min: 0, max: 1)]
        public string @Address { get; }

        [nterraform.Core.TerraformProperty(name: "datacenter", @out: true, min: 0, max: 1)]
        public string @Datacenter { get; }

        [nterraform.Core.TerraformProperty(name: "port", @out: false, min: 0, max: 1)]
        public int? @Port { get; }

        [nterraform.Core.TerraformProperty(name: "service_id", @out: true, min: 0, max: 1)]
        public string @ServiceId { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public string[] @Tags { get; }
    }

}
