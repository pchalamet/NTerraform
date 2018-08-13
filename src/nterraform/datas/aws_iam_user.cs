using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_iam_user")]
    public sealed class aws_iam_user : nterraform.data
    {
        public aws_iam_user(string @userName)
        {
            @UserName = @userName;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "user_name", @out: false, min: 1, max: 1)]
        public string @UserName { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "path", @out: true, min: 0, max: 1)]
        public string @Path { get; }

        [nterraform.TerraformProperty(name: "permissions_boundary", @out: true, min: 0, max: 1)]
        public string @PermissionsBoundary { get; }

        [nterraform.TerraformProperty(name: "user_id", @out: true, min: 0, max: 1)]
        public string @UserId { get; }
    }

}
