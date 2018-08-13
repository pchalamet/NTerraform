using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_key_pair")]
    public sealed class aws_key_pair : nterraform.resource
    {
        public aws_key_pair(string @publicKey,
                            string @keyNamePrefix = null)
        {
            @PublicKey = @publicKey;
            @KeyNamePrefix = @keyNamePrefix;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "public_key", @out: false, min: 1, max: 1)]
        public string @PublicKey { get; }

        [nterraform.TerraformProperty(name: "fingerprint", @out: true, min: 0, max: 1)]
        public string @Fingerprint { get; }

        [nterraform.TerraformProperty(name: "key_name", @out: true, min: 0, max: 1)]
        public string @KeyName { get; }

        [nterraform.TerraformProperty(name: "key_name_prefix", @out: false, min: 0, max: 1)]
        public string @KeyNamePrefix { get; }
    }

}
