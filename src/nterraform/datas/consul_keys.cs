using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "consul_keys")]
    public sealed class consul_keys : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "key")]
        public sealed class key : nterraform.Core.structure
        {
            public key(string @name,
                       string @path,
                       FSharpOption<string> @default = null)
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
            public FSharpOption<string> @Default { get; }
        }

        public consul_keys(FSharpOption<FSharpList<key>> @key = null,
                           FSharpOption<string> @token = null)
        {
            @Key = @key ?? FSharpList<key>.Empty;
            @Token = @token;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "datacenter", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Datacenter { get; }

        [nterraform.Core.TerraformProperty(name: "key", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpList<key>> @Key { get; }

        [nterraform.Core.TerraformProperty(name: "token", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @Token { get; }

        [nterraform.Core.TerraformProperty(name: "var", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpMap<string,string>> @Var { get; }
    }

}
