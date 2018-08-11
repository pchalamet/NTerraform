using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "consul_node")]
    public sealed class consul_node : NTerraform.resource
    {
        public consul_node(string @address,
                           string @name,
                           string @token = null)
        {
            @Address = @address;
            @Name = @name;
            @Token = @token;
            base._validate_();
        }

        [TerraformProperty(name: "address", @out: false, min: 1, max: 1)]
        public string @Address { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "datacenter", @out: true, min: 0, max: 1)]
        public string @Datacenter { get; }

        [TerraformProperty(name: "token", @out: false, min: 0, max: 1)]
        public string @Token { get; }
    }

}
