using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "consul_keys")]
    public sealed class consul_keys : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "key")]
        public sealed class key
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

            [TerraformProperty(name: "path", @out: false, min: 1, max: 1)]
            public string @Path { get; }

            [TerraformProperty(name: "default", @out: false, min: 0, max: 1)]
            public string @Default { get; }

            [TerraformProperty(name: "delete", @out: false, min: 0, max: 1)]
            public bool? @Delete { get; }

            [TerraformProperty(name: "name", @out: false, min: 0, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "value", @out: true, min: 0, max: 1)]
            public string @Value { get; }
        }

        public consul_keys(key[] @key = null,
                           string @token = null)
        {
            @Key = @key;
            @Token = @token;
        }

        [TerraformProperty(name: "datacenter", @out: true, min: 0, max: 1)]
        public string @Datacenter { get; }

        [TerraformProperty(name: "key", @out: false, min: 0, max: 0)]
        public key[] @Key { get; }

        [TerraformProperty(name: "token", @out: false, min: 0, max: 1)]
        public string @Token { get; }

        [TerraformProperty(name: "var", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Var { get; }
    }

}
