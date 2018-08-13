using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_iam_instance_profile")]
    public sealed class aws_iam_instance_profile : nterraform.data
    {
        public aws_iam_instance_profile(string @name)
        {
            @Name = @name;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "create_date", @out: true, min: 0, max: 1)]
        public string @CreateDate { get; }

        [nterraform.TerraformProperty(name: "path", @out: true, min: 0, max: 1)]
        public string @Path { get; }

        [nterraform.TerraformProperty(name: "role_arn", @out: true, min: 0, max: 1)]
        public string @RoleArn { get; }

        [nterraform.TerraformProperty(name: "role_id", @out: true, min: 0, max: 1)]
        public string @RoleId { get; }

        [nterraform.TerraformProperty(name: "role_name", @out: true, min: 0, max: 1)]
        public string @RoleName { get; }
    }

}
