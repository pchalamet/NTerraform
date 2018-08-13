using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_iam_user_group_membership")]
    public sealed class aws_iam_user_group_membership : nterraform.resource
    {
        public aws_iam_user_group_membership(string[] @groups,
                                             string @user)
        {
            @Groups = @groups;
            @User = @user;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "groups", @out: false, min: 1, max: 1)]
        public string[] @Groups { get; }

        [nterraform.TerraformProperty(name: "user", @out: false, min: 1, max: 1)]
        public string @User { get; }
    }

}
