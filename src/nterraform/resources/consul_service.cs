using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "consul_service")]
    public sealed class consul_service : nterraform.Core.resource
    {
        public consul_service(string @name,
                              string @node,
                              FSharpOption<int> @port = null,
                              FSharpOption<FSharpList<string>> @tags = null)
        {
            @Name = @name;
            @Node = @node;
            @Port = @port;
            @Tags = @tags ?? FSharpList<string>.Empty;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "node", @out: false, min: 1, max: 1)]
        public string @Node { get; }

        [nterraform.Core.TerraformProperty(name: "address", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Address { get; }

        [nterraform.Core.TerraformProperty(name: "datacenter", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Datacenter { get; }

        [nterraform.Core.TerraformProperty(name: "port", @out: false, min: 0, max: 1)]
        public FSharpOption<int> @Port { get; }

        [nterraform.Core.TerraformProperty(name: "service_id", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @ServiceId { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpList<string>> @Tags { get; }
    }

}
