using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_iam_role")]
    public sealed class aws_iam_role : nterraform.data
    {
        public aws_iam_role(string @name = null,
                            string @roleName = null)
        {
            @Name = @name;
            @RoleName = @roleName;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "assume_role_policy", @out: true, min: 0, max: 1)]
        public string @AssumeRolePolicy { get; }

        [nterraform.TerraformProperty(name: "assume_role_policy_document", @out: true, min: 0, max: 1)]
        public string @AssumeRolePolicyDocument { get; }

        [nterraform.TerraformProperty(name: "create_date", @out: true, min: 0, max: 1)]
        public string @CreateDate { get; }

        [nterraform.TerraformProperty(name: "description", @out: true, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "max_session_duration", @out: true, min: 0, max: 1)]
        public int? @MaxSessionDuration { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "path", @out: true, min: 0, max: 1)]
        public string @Path { get; }

        [nterraform.TerraformProperty(name: "permissions_boundary", @out: true, min: 0, max: 1)]
        public string @PermissionsBoundary { get; }

        [nterraform.TerraformProperty(name: "role_id", @out: true, min: 0, max: 1)]
        public string @RoleId { get; }

        [nterraform.TerraformProperty(name: "role_name", @out: false, min: 0, max: 1)]
        public string @RoleName { get; }

        [nterraform.TerraformProperty(name: "unique_id", @out: true, min: 0, max: 1)]
        public string @UniqueId { get; }
    }

}
