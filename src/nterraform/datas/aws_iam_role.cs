using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_iam_role")]
    public sealed class aws_iam_role : nterraform.Core.data
    {
        public aws_iam_role(string @name = null,
                            string @roleName = null)
        {
            @Name = @name;
            @RoleName = @roleName;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "assume_role_policy", @out: true, min: 0, max: 1)]
        public string @AssumeRolePolicy { get; }

        [nterraform.Core.TerraformProperty(name: "assume_role_policy_document", @out: true, min: 0, max: 1)]
        public string @AssumeRolePolicyDocument { get; }

        [nterraform.Core.TerraformProperty(name: "create_date", @out: true, min: 0, max: 1)]
        public string @CreateDate { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: true, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "max_session_duration", @out: true, min: 0, max: 1)]
        public int? @MaxSessionDuration { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "path", @out: true, min: 0, max: 1)]
        public string @Path { get; }

        [nterraform.Core.TerraformProperty(name: "permissions_boundary", @out: true, min: 0, max: 1)]
        public string @PermissionsBoundary { get; }

        [nterraform.Core.TerraformProperty(name: "role_id", @out: true, min: 0, max: 1)]
        public string @RoleId { get; }

        [nterraform.Core.TerraformProperty(name: "role_name", @out: false, min: 0, max: 1)]
        public string @RoleName { get; }

        [nterraform.Core.TerraformProperty(name: "unique_id", @out: true, min: 0, max: 1)]
        public string @UniqueId { get; }
    }

}
