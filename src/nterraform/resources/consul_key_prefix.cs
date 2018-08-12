using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "consul_key_prefix")]
    public sealed class consul_key_prefix : nterraform.Core.resource
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

        [nterraform.Core.TerraformProperty(name: "path_prefix", @out: false, min: 1, max: 1)]
        public string @PathPrefix { get; }

        [nterraform.Core.TerraformProperty(name: "subkeys", @out: false, min: 1, max: 1)]
        public Dictionary<string,string> @Subkeys { get; }

        [nterraform.Core.TerraformProperty(name: "datacenter", @out: true, min: 0, max: 1)]
        public string @Datacenter { get; }

        [nterraform.Core.TerraformProperty(name: "token", @out: false, min: 0, max: 1)]
        public string @Token { get; }
    }

}
