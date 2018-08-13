using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_kms_secret")]
    public sealed class aws_kms_secret : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "secret")]
        public sealed class secret : nterraform.structure
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

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "payload", @out: false, min: 1, max: 1)]
            public string @Payload { get; }

            [nterraform.TerraformProperty(name: "context", @out: false, min: 0, max: 1)]
            public Dictionary<string,string> @Context { get; }

            [nterraform.TerraformProperty(name: "grant_tokens", @out: false, min: 0, max: 1)]
            public string[] @GrantTokens { get; }
        }

        public aws_kms_secret(secret[] @secret,
                              string @hasDynamicAttributes = null)
        {
            @Secret = @secret;
            @HasDynamicAttributes = @hasDynamicAttributes;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "secret", @out: false, min: 1, max: 0)]
        public secret[] @Secret { get; }

        [nterraform.TerraformProperty(name: "__has_dynamic_attributes", @out: false, min: 0, max: 1)]
        public string @HasDynamicAttributes { get; }
    }

}
