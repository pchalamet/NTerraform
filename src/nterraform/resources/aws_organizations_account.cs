using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_organizations_account")]
    public sealed class aws_organizations_account : nterraform.resource
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

        [nterraform.TerraformProperty(name: "email", @out: false, min: 1, max: 1)]
        public string @Email { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "iam_user_access_to_billing", @out: false, min: 0, max: 1)]
        public string @IamUserAccessToBilling { get; }

        [nterraform.TerraformProperty(name: "joined_method", @out: true, min: 0, max: 1)]
        public string @JoinedMethod { get; }

        [nterraform.TerraformProperty(name: "joined_timestamp", @out: true, min: 0, max: 1)]
        public string @JoinedTimestamp { get; }

        [nterraform.TerraformProperty(name: "role_name", @out: false, min: 0, max: 1)]
        public string @RoleName { get; }

        [nterraform.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }
    }

}
