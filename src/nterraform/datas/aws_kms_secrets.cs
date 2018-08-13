using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_kms_secrets")]
    public sealed class aws_kms_secrets : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "secret")]
        public sealed class secret : nterraform.Core.structure
        {
            public secret(string @name,
                          string @payload,
                          Dictionary<string,string> @context = null,
                          string[] @grantTokens = null)
            {
                @Name = @name;
                @Payload = @payload;
                @Context = @context;
                @GrantTokens = @grantTokens;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "payload", @out: false, min: 1, max: 1)]
            public string @Payload { get; }

            [nterraform.Core.TerraformProperty(name: "context", @out: false, min: 0, max: 1)]
            public Dictionary<string,string> @Context { get; }

            [nterraform.Core.TerraformProperty(name: "grant_tokens", @out: false, min: 0, max: 1)]
            public string[] @GrantTokens { get; }
        }

        public aws_kms_secrets(secret[] @secret)
        {
            @Secret = @secret;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "secret", @out: false, min: 1, max: 0)]
        public secret[] @Secret { get; }

        [nterraform.Core.TerraformProperty(name: "plaintext", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Plaintext { get; }
    }

}
