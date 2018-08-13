using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_iam_account_password_policy")]
    public sealed class aws_iam_account_password_policy : nterraform.Core.resource
    {
        public aws_iam_account_password_policy(bool? @allowUsersToChangePassword = null,
                                               int? @minimumPasswordLength = null)
        {
            @AllowUsersToChangePassword = @allowUsersToChangePassword;
            @MinimumPasswordLength = @minimumPasswordLength;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "allow_users_to_change_password", @out: false, min: 0, max: 1)]
        public bool? @AllowUsersToChangePassword { get; }

        [nterraform.Core.TerraformProperty(name: "expire_passwords", @out: true, min: 0, max: 1)]
        public bool? @ExpirePasswords { get; }

        [nterraform.Core.TerraformProperty(name: "hard_expiry", @out: true, min: 0, max: 1)]
        public bool? @HardExpiry { get; }

        [nterraform.Core.TerraformProperty(name: "max_password_age", @out: true, min: 0, max: 1)]
        public int? @MaxPasswordAge { get; }

        [nterraform.Core.TerraformProperty(name: "minimum_password_length", @out: false, min: 0, max: 1)]
        public int? @MinimumPasswordLength { get; }

        [nterraform.Core.TerraformProperty(name: "password_reuse_prevention", @out: true, min: 0, max: 1)]
        public int? @PasswordReusePrevention { get; }

        [nterraform.Core.TerraformProperty(name: "require_lowercase_characters", @out: true, min: 0, max: 1)]
        public bool? @RequireLowercaseCharacters { get; }

        [nterraform.Core.TerraformProperty(name: "require_numbers", @out: true, min: 0, max: 1)]
        public bool? @RequireNumbers { get; }

        [nterraform.Core.TerraformProperty(name: "require_symbols", @out: true, min: 0, max: 1)]
        public bool? @RequireSymbols { get; }

        [nterraform.Core.TerraformProperty(name: "require_uppercase_characters", @out: true, min: 0, max: 1)]
        public bool? @RequireUppercaseCharacters { get; }
    }

}
