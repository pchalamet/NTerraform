using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_iam_user_policy")]
    public sealed class aws_iam_user_policy : nterraform.resource
    {
        public aws_iam_user_policy(string @policy,
                                   string @user,
                                   string @namePrefix = null)
        {
            @Policy = @policy;
            @User = @user;
            @NamePrefix = @namePrefix;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "policy", @out: false, min: 1, max: 1)]
        public string @Policy { get; }

        [nterraform.TerraformProperty(name: "user", @out: false, min: 1, max: 1)]
        public string @User { get; }

        [nterraform.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "name_prefix", @out: false, min: 0, max: 1)]
        public string @NamePrefix { get; }
    }

}
