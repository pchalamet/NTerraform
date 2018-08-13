using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_iam_group_membership")]
    public sealed class aws_iam_group_membership : nterraform.Core.resource
    {
        public aws_iam_group_membership(string @group,
                                        string @name,
                                        string[] @users)
        {
            @Group = @group;
            @Name = @name;
            @Users = @users;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "group", @out: false, min: 1, max: 1)]
        public string @Group { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "users", @out: false, min: 1, max: 1)]
        public string[] @Users { get; }
    }

}
