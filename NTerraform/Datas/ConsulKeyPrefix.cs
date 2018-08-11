using System.Collections.Generic;

namespace NTerraform.Datas
{
    public sealed class consul_key_prefix : NTerraform.data
    {
        public sealed class subkey
        {
            public subkey(string @name,
                          string @path,
                          string @default = null)
            {
                @Name = @name;
                @Path = @path;
                @Default = @default;
            }

            public string @Name { get; }
            public string @Path { get; }
            public string @Default { get; }
        }

        public consul_key_prefix(string @pathPrefix,
                                 subkey[] @subkey = null,
                                 string @token = null)
        {
            @PathPrefix = @pathPrefix;
            @Subkey = @subkey;
            @Token = @token;
        }

        public string @PathPrefix { get; }
        public string @Datacenter { get; }
        public subkey[] @Subkey { get; }
        public Dictionary<string,string> @Subkeys { get; }
        public string @Token { get; }
        public Dictionary<string,string> @Var { get; }
    }

}
