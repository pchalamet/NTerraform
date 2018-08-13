using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_iam_access_key")]
    public sealed class aws_iam_access_key : nterraform.resource
    {
        public aws_iam_access_key(string @user,
                                  string @pgpKey = null)
        {
            @User = @user;
            @PgpKey = @pgpKey;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "user", @out: false, min: 1, max: 1)]
        public string @User { get; }

        [nterraform.TerraformProperty(name: "encrypted_secret", @out: true, min: 0, max: 1)]
        public string @EncryptedSecret { get; }

        [nterraform.TerraformProperty(name: "key_fingerprint", @out: true, min: 0, max: 1)]
        public string @KeyFingerprint { get; }

        [nterraform.TerraformProperty(name: "pgp_key", @out: false, min: 0, max: 1)]
        public string @PgpKey { get; }

        [nterraform.TerraformProperty(name: "secret", @out: true, min: 0, max: 1)]
        public string @Secret { get; }

        [nterraform.TerraformProperty(name: "ses_smtp_password", @out: true, min: 0, max: 1)]
        public string @SesSmtpPassword { get; }

        [nterraform.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }
    }

}
