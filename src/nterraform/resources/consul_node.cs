using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "consul_node")]
    public sealed class consul_node : nterraform.resource
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

        [nterraform.TerraformProperty(name: "address", @out: false, min: 1, max: 1)]
        public string @Address { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "datacenter", @out: true, min: 0, max: 1)]
        public string @Datacenter { get; }

        [nterraform.TerraformProperty(name: "token", @out: false, min: 0, max: 1)]
        public string @Token { get; }
    }

}
