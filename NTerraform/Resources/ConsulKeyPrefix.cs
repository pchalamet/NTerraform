using System.Collections.Generic;

namespace NTerraform.Resources
{
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

        public string @PathPrefix { get; }
        public Dictionary<string,string> @Subkeys { get; }
        public string @Datacenter { get; }
        public string @Token { get; }
    }

}
