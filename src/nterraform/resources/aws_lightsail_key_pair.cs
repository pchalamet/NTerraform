using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_lightsail_key_pair")]
    public sealed class aws_lightsail_key_pair : nterraform.resource
    {
        public aws_lightsail_key_pair(string @namePrefix = null,
                                      string @pgpKey = null)
        {
            @NamePrefix = @namePrefix;
            @PgpKey = @pgpKey;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "encrypted_fingerprint", @out: true, min: 0, max: 1)]
        public string @EncryptedFingerprint { get; }

        [nterraform.TerraformProperty(name: "encrypted_private_key", @out: true, min: 0, max: 1)]
        public string @EncryptedPrivateKey { get; }

        [nterraform.TerraformProperty(name: "fingerprint", @out: true, min: 0, max: 1)]
        public string @Fingerprint { get; }

        [nterraform.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "name_prefix", @out: false, min: 0, max: 1)]
        public string @NamePrefix { get; }

        [nterraform.TerraformProperty(name: "pgp_key", @out: false, min: 0, max: 1)]
        public string @PgpKey { get; }

        [nterraform.TerraformProperty(name: "private_key", @out: true, min: 0, max: 1)]
        public string @PrivateKey { get; }

        [nterraform.TerraformProperty(name: "public_key", @out: true, min: 0, max: 1)]
        public string @PublicKey { get; }
    }

}
