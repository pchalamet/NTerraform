using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_lightsail_key_pair")]
    public sealed class aws_lightsail_key_pair : nterraform.Core.resource
    {
        public aws_lightsail_key_pair(string @namePrefix = null,
                                      string @pgpKey = null)
        {
            @NamePrefix = @namePrefix;
            @PgpKey = @pgpKey;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "encrypted_fingerprint", @out: true, min: 0, max: 1)]
        public string @EncryptedFingerprint { get; }

        [nterraform.Core.TerraformProperty(name: "encrypted_private_key", @out: true, min: 0, max: 1)]
        public string @EncryptedPrivateKey { get; }

        [nterraform.Core.TerraformProperty(name: "fingerprint", @out: true, min: 0, max: 1)]
        public string @Fingerprint { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "name_prefix", @out: false, min: 0, max: 1)]
        public string @NamePrefix { get; }

        [nterraform.Core.TerraformProperty(name: "pgp_key", @out: false, min: 0, max: 1)]
        public string @PgpKey { get; }

        [nterraform.Core.TerraformProperty(name: "private_key", @out: true, min: 0, max: 1)]
        public string @PrivateKey { get; }

        [nterraform.Core.TerraformProperty(name: "public_key", @out: true, min: 0, max: 1)]
        public string @PublicKey { get; }
    }

}
