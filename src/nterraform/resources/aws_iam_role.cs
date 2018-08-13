using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_iam_role")]
    public sealed class aws_iam_role : nterraform.Core.resource
    {
        public aws_iam_role(string @assumeRolePolicy,
                            string @description = null,
                            bool? @forceDetachPolicies = null,
                            int? @maxSessionDuration = null,
                            string @namePrefix = null,
                            string @path = null,
                            string @permissionsBoundary = null)
        {
            @AssumeRolePolicy = @assumeRolePolicy;
            @Description = @description;
            @ForceDetachPolicies = @forceDetachPolicies;
            @MaxSessionDuration = @maxSessionDuration;
            @NamePrefix = @namePrefix;
            @Path = @path;
            @PermissionsBoundary = @permissionsBoundary;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "assume_role_policy", @out: false, min: 1, max: 1)]
        public string @AssumeRolePolicy { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "create_date", @out: true, min: 0, max: 1)]
        public string @CreateDate { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "force_detach_policies", @out: false, min: 0, max: 1)]
        public bool? @ForceDetachPolicies { get; }

        [nterraform.Core.TerraformProperty(name: "max_session_duration", @out: false, min: 0, max: 1)]
        public int? @MaxSessionDuration { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "name_prefix", @out: false, min: 0, max: 1)]
        public string @NamePrefix { get; }

        [nterraform.Core.TerraformProperty(name: "path", @out: false, min: 0, max: 1)]
        public string @Path { get; }

        [nterraform.Core.TerraformProperty(name: "permissions_boundary", @out: false, min: 0, max: 1)]
        public string @PermissionsBoundary { get; }

        [nterraform.Core.TerraformProperty(name: "unique_id", @out: true, min: 0, max: 1)]
        public string @UniqueId { get; }
    }

}
