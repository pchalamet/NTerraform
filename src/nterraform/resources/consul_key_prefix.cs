using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "consul_key_prefix")]
    public sealed class consul_key_prefix : nterraform.resource
    {
        public consul_key_prefix(string @pathPrefix,
                                 Dictionary<string,string> @subkeys,
                                 string @token = null)
        {
            @PathPrefix = @pathPrefix;
            @Subkeys = @subkeys;
            @Token = @token;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "path_prefix", @out: false, min: 1, max: 1)]
        public string @PathPrefix { get; }

        [nterraform.TerraformProperty(name: "subkeys", @out: false, min: 1, max: 1)]
        public Dictionary<string,string> @Subkeys { get; }

        [nterraform.TerraformProperty(name: "datacenter", @out: true, min: 0, max: 1)]
        public string @Datacenter { get; }

        [nterraform.TerraformProperty(name: "token", @out: false, min: 0, max: 1)]
        public string @Token { get; }
    }

}
