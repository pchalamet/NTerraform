using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "consul_key_prefix")]
    public sealed class consul_key_prefix : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "subkey")]
        public sealed class subkey : nterraform.Core.structure
        {
            public subkey(string @name,
                          string @path,
                          string @default = null)
            {
                @Name = @name;
                @Path = @path;
                @Default = @default;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "path", @out: false, min: 1, max: 1)]
            public string @Path { get; }

            [nterraform.Core.TerraformProperty(name: "default", @out: false, min: 0, max: 1)]
            public string @Default { get; }
        }

        public consul_key_prefix(string @pathPrefix,
                                 subkey[] @subkey = null,
                                 string @token = null)
        {
            @PathPrefix = @pathPrefix;
            @Subkey = @subkey;
            @Token = @token;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "path_prefix", @out: false, min: 1, max: 1)]
        public string @PathPrefix { get; }

        [nterraform.Core.TerraformProperty(name: "datacenter", @out: true, min: 0, max: 1)]
        public string @Datacenter { get; }

        [nterraform.Core.TerraformProperty(name: "subkey", @out: false, min: 0, max: 0)]
        public subkey[] @Subkey { get; }

        [nterraform.Core.TerraformProperty(name: "subkeys", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Subkeys { get; }

        [nterraform.Core.TerraformProperty(name: "token", @out: false, min: 0, max: 1)]
        public string @Token { get; }

        [nterraform.Core.TerraformProperty(name: "var", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Var { get; }
    }

}
