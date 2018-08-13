using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_iam_account_password_policy")]
    public sealed class aws_iam_account_password_policy : nterraform.resource
    {
        public aws_iam_account_password_policy(bool? @allowUsersToChangePassword = null,
                                               int? @minimumPasswordLength = null)
        {
            @AllowUsersToChangePassword = @allowUsersToChangePassword;
            @MinimumPasswordLength = @minimumPasswordLength;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "allow_users_to_change_password", @out: false, min: 0, max: 1)]
        public bool? @AllowUsersToChangePassword { get; }

        [nterraform.TerraformProperty(name: "expire_passwords", @out: true, min: 0, max: 1)]
        public bool? @ExpirePasswords { get; }

        [nterraform.TerraformProperty(name: "hard_expiry", @out: true, min: 0, max: 1)]
        public bool? @HardExpiry { get; }

        [nterraform.TerraformProperty(name: "max_password_age", @out: true, min: 0, max: 1)]
        public int? @MaxPasswordAge { get; }

        [nterraform.TerraformProperty(name: "minimum_password_length", @out: false, min: 0, max: 1)]
        public int? @MinimumPasswordLength { get; }

        [nterraform.TerraformProperty(name: "password_reuse_prevention", @out: true, min: 0, max: 1)]
        public int? @PasswordReusePrevention { get; }

        [nterraform.TerraformProperty(name: "require_lowercase_characters", @out: true, min: 0, max: 1)]
        public bool? @RequireLowercaseCharacters { get; }

        [nterraform.TerraformProperty(name: "require_numbers", @out: true, min: 0, max: 1)]
        public bool? @RequireNumbers { get; }

        [nterraform.TerraformProperty(name: "require_symbols", @out: true, min: 0, max: 1)]
        public bool? @RequireSymbols { get; }

        [nterraform.TerraformProperty(name: "require_uppercase_characters", @out: true, min: 0, max: 1)]
        public bool? @RequireUppercaseCharacters { get; }
    }

}
