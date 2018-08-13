using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_iam_user_login_profile")]
    public sealed class aws_iam_user_login_profile : nterraform.Core.resource
    {
        public aws_iam_user_login_profile(string @pgpKey,
                                          string @user,
                                          int? @passwordLength = null,
                                          bool? @passwordResetRequired = null)
        {
            @PgpKey = @pgpKey;
            @User = @user;
            @PasswordLength = @passwordLength;
            @PasswordResetRequired = @passwordResetRequired;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "pgp_key", @out: false, min: 1, max: 1)]
        public string @PgpKey { get; }

        [nterraform.Core.TerraformProperty(name: "user", @out: false, min: 1, max: 1)]
        public string @User { get; }

        [nterraform.Core.TerraformProperty(name: "encrypted_password", @out: true, min: 0, max: 1)]
        public string @EncryptedPassword { get; }

        [nterraform.Core.TerraformProperty(name: "key_fingerprint", @out: true, min: 0, max: 1)]
        public string @KeyFingerprint { get; }

        [nterraform.Core.TerraformProperty(name: "password_length", @out: false, min: 0, max: 1)]
        public int? @PasswordLength { get; }

        [nterraform.Core.TerraformProperty(name: "password_reset_required", @out: false, min: 0, max: 1)]
        public bool? @PasswordResetRequired { get; }
    }

}
