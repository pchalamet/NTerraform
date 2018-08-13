using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "consul_service")]
    public sealed class consul_service : nterraform.resource
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

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "node", @out: false, min: 1, max: 1)]
        public string @Node { get; }

        [nterraform.TerraformProperty(name: "address", @out: true, min: 0, max: 1)]
        public string @Address { get; }

        [nterraform.TerraformProperty(name: "datacenter", @out: true, min: 0, max: 1)]
        public string @Datacenter { get; }

        [nterraform.TerraformProperty(name: "port", @out: false, min: 0, max: 1)]
        public int? @Port { get; }

        [nterraform.TerraformProperty(name: "service_id", @out: true, min: 0, max: 1)]
        public string @ServiceId { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public string[] @Tags { get; }
    }

}
