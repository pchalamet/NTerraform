using System.Collections.Generic;

namespace NTerraform.Datas
{
    public class consul_keys : NTerraform.data
    {
        public class key
        {
            public key(string @name,
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
