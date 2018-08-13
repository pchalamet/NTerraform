using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_iam_access_key")]
    public sealed class aws_iam_access_key : nterraform.Core.resource
    {
        public aws_iam_access_key(string @user,
                                  string @pgpKey = null)
        {
            @User = @user;
            @PgpKey = @pgpKey;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "user", @out: false, min: 1, max: 1)]
        public string @User { get; }

        [nterraform.Core.TerraformProperty(name: "encrypted_secret", @out: true, min: 0, max: 1)]
        public string @EncryptedSecret { get; }

        [nterraform.Core.TerraformProperty(name: "key_fingerprint", @out: true, min: 0, max: 1)]
        public string @KeyFingerprint { get; }

        [nterraform.Core.TerraformProperty(name: "pgp_key", @out: false, min: 0, max: 1)]
        public string @PgpKey { get; }

        [nterraform.Core.TerraformProperty(name: "secret", @out: true, min: 0, max: 1)]
        public string @Secret { get; }

        [nterraform.Core.TerraformProperty(name: "ses_smtp_password", @out: true, min: 0, max: 1)]
        public string @SesSmtpPassword { get; }

        [nterraform.Core.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }
    }

}
