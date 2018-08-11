using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class consul_keys : NTerraform.resource
    {
        public class key
        {
            public key(string @path,
                       string @default = null,
                       bool? @delete = null,
                       string @name = null)
            {
                @Path = @path;
                @Default = @default;
                @Delete = @delete;
                @Name = @name;
            }

            public string @Path { get; }
            public string @Default { get; }
            public bool? @Delete { get; }
            public string @Name { get; }
            public string @Value { get; }
        }

        public consul_keys(key[] @key = null,
                           string @token = null)
        {
            @Key = @key;
            @Token = @token;
        }

        public string @Datacenter { get; }
        public key[] @Key { get; }
        public string @Token { get; }
        public Dictionary<string,string> @Var { get; }
    }

}
