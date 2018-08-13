using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_iam_group")]
    public sealed class aws_iam_group : nterraform.data
    {
        public aws_iam_group(string @groupName)
        {
            @GroupName = @groupName;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "group_name", @out: false, min: 1, max: 1)]
        public string @GroupName { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "group_id", @out: true, min: 0, max: 1)]
        public string @GroupId { get; }

        [nterraform.TerraformProperty(name: "path", @out: true, min: 0, max: 1)]
        public string @Path { get; }
    }

}
