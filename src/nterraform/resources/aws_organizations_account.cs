using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_organizations_account")]
    public sealed class aws_organizations_account : nterraform.Core.resource
    {
        public aws_organizations_account(string @email,
                                         string @name,
                                         string @iamUserAccessToBilling = null,
                                         string @roleName = null)
        {
            @Email = @email;
            @Name = @name;
            @IamUserAccessToBilling = @iamUserAccessToBilling;
            @RoleName = @roleName;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "email", @out: false, min: 1, max: 1)]
        public string @Email { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "iam_user_access_to_billing", @out: false, min: 0, max: 1)]
        public string @IamUserAccessToBilling { get; }

        [nterraform.Core.TerraformProperty(name: "joined_method", @out: true, min: 0, max: 1)]
        public string @JoinedMethod { get; }

        [nterraform.Core.TerraformProperty(name: "joined_timestamp", @out: true, min: 0, max: 1)]
        public string @JoinedTimestamp { get; }

        [nterraform.Core.TerraformProperty(name: "role_name", @out: false, min: 0, max: 1)]
        public string @RoleName { get; }

        [nterraform.Core.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }
    }

}
