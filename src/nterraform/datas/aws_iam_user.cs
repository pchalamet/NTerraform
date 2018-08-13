using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_iam_user")]
    public sealed class aws_iam_user : nterraform.Core.data
    {
        public aws_iam_user(string @userName)
        {
            @UserName = @userName;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "user_name", @out: false, min: 1, max: 1)]
        public string @UserName { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "path", @out: true, min: 0, max: 1)]
        public string @Path { get; }

        [nterraform.Core.TerraformProperty(name: "permissions_boundary", @out: true, min: 0, max: 1)]
        public string @PermissionsBoundary { get; }

        [nterraform.Core.TerraformProperty(name: "user_id", @out: true, min: 0, max: 1)]
        public string @UserId { get; }
    }

}
