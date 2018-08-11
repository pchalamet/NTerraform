using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "consul_agent_service")]
    public sealed class consul_agent_service : NTerraform.resource
    {
        public consul_agent_service(string @name,
                                    int? @port = null,
                                    string[] @tags = null)
        {
            @Name = @name;
            @Port = @port;
            @Tags = @tags;
        }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "address", @out: true, min: 0, max: 1)]
        public string @Address { get; }

        [TerraformProperty(name: "port", @out: false, min: 0, max: 1)]
        public int? @Port { get; }

        [TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public string[] @Tags { get; }
    }

}
