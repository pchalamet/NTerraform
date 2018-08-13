using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_iam_user_policy")]
    public sealed class aws_iam_user_policy : nterraform.Core.resource
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

        [nterraform.Core.TerraformProperty(name: "policy", @out: false, min: 1, max: 1)]
        public string @Policy { get; }

        [nterraform.Core.TerraformProperty(name: "user", @out: false, min: 1, max: 1)]
        public string @User { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "name_prefix", @out: false, min: 0, max: 1)]
        public string @NamePrefix { get; }
    }

}
