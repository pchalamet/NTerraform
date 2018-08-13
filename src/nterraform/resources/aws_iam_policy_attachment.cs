using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_iam_policy_attachment")]
    public sealed class aws_iam_policy_attachment : nterraform.resource
    {
        public aws_iam_policy_attachment(string @name,
                                         string @policyArn,
                                         string[] @groups = null,
                                         string[] @roles = null,
                                         string[] @users = null)
        {
            @Name = @name;
            @PolicyArn = @policyArn;
            @Groups = @groups;
            @Roles = @roles;
            @Users = @users;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "policy_arn", @out: false, min: 1, max: 1)]
        public string @PolicyArn { get; }

        [nterraform.TerraformProperty(name: "groups", @out: false, min: 0, max: 1)]
        public string[] @Groups { get; }

        [nterraform.TerraformProperty(name: "roles", @out: false, min: 0, max: 1)]
        public string[] @Roles { get; }

        [nterraform.TerraformProperty(name: "users", @out: false, min: 0, max: 1)]
        public string[] @Users { get; }
    }

}
