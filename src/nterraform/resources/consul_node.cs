using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "consul_node")]
    public sealed class consul_node : nterraform.Core.resource
    {
        public consul_node(string @address,
                           string @name,
                           FSharpOption<string> @token = null)
        {
            @Address = @address;
            @Name = @name;
            @Token = @token;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "address", @out: false, min: 1, max: 1)]
        public string @Address { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "datacenter", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Datacenter { get; }

        [nterraform.Core.TerraformProperty(name: "token", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @Token { get; }
    }

}
