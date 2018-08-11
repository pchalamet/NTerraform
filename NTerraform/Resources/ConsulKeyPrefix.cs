using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "consul_key_prefix")]
    public sealed class consul_key_prefix : NTerraform.resource
    {
        public consul_key_prefix(string @pathPrefix,
                                 Dictionary<string,string> @subkeys,
                                 string @token = null)
        {
            @PathPrefix = @pathPrefix;
            @Subkeys = @subkeys;
            @Token = @token;
        }

        [TerraformProperty(name: "path_prefix", @out: false, min: 1, max: 1)]
        public string @PathPrefix { get; }

        [TerraformProperty(name: "subkeys", @out: false, min: 1, max: 1)]
        public Dictionary<string,string> @Subkeys { get; }

        [TerraformProperty(name: "datacenter", @out: true, min: 0, max: 1)]
        public string @Datacenter { get; }

        [TerraformProperty(name: "token", @out: false, min: 0, max: 1)]
        public string @Token { get; }
    }

}
