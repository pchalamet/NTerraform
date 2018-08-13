using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_iam_user_group_membership")]
    public sealed class aws_iam_user_group_membership : nterraform.Core.resource
    {
        public aws_iam_user_group_membership(string[] @groups,
                                             string @user)
        {
            @Groups = @groups;
            @User = @user;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "groups", @out: false, min: 1, max: 1)]
        public string[] @Groups { get; }

        [nterraform.Core.TerraformProperty(name: "user", @out: false, min: 1, max: 1)]
        public string @User { get; }
    }

}
