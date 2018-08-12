using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "consul_agent_service")]
    public sealed class consul_agent_service : nterraform.Core.resource
    {
        public consul_agent_service(string @name,
                                    int? @port = null,
                                    string[] @tags = null)
        {
            @Name = @name;
            @Port = @port;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "address", @out: true, min: 0, max: 1)]
        public string @Address { get; }

        [nterraform.Core.TerraformProperty(name: "port", @out: false, min: 0, max: 1)]
        public int? @Port { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public string[] @Tags { get; }
    }

}
