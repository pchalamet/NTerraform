using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "consul_key_prefix")]
    public sealed class consul_key_prefix : NTerraform.data
    {
        [TerraformStructure(category: "", typeName: "subkey")]
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

            [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "path", @out: false, min: 1, max: 1)]
            public string @Path { get; }

            [TerraformProperty(name: "default", @out: false, min: 0, max: 1)]
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

        [TerraformProperty(name: "path_prefix", @out: false, min: 1, max: 1)]
        public string @PathPrefix { get; }

        [TerraformProperty(name: "datacenter", @out: true, min: 0, max: 1)]
        public string @Datacenter { get; }

        [TerraformProperty(name: "subkey", @out: false, min: 0, max: 0)]
        public subkey[] @Subkey { get; }

        [TerraformProperty(name: "subkeys", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Subkeys { get; }

        [TerraformProperty(name: "token", @out: false, min: 0, max: 1)]
        public string @Token { get; }

        [TerraformProperty(name: "var", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Var { get; }
    }

}
