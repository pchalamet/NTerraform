using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "consul_keys")]
    public sealed class consul_keys : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "key")]
        public sealed class key : nterraform.structure
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
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "path", @out: false, min: 1, max: 1)]
            public string @Path { get; }

            [nterraform.TerraformProperty(name: "default", @out: false, min: 0, max: 1)]
            public string @Default { get; }

            [nterraform.TerraformProperty(name: "delete", @out: false, min: 0, max: 1)]
            public bool? @Delete { get; }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 0, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "value", @out: true, min: 0, max: 1)]
            public string @Value { get; }
        }

        public consul_keys(key[] @key = null,
                           string @token = null)
        {
            @Key = @key;
            @Token = @token;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "datacenter", @out: true, min: 0, max: 1)]
        public string @Datacenter { get; }

        [nterraform.TerraformProperty(name: "key", @out: false, min: 0, max: 0)]
        public key[] @Key { get; }

        [nterraform.TerraformProperty(name: "token", @out: false, min: 0, max: 1)]
        public string @Token { get; }

        [nterraform.TerraformProperty(name: "var", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Var { get; }
    }

}
