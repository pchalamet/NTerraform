using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_iam_group")]
    public sealed class aws_iam_group : nterraform.Core.data
    {
        public aws_iam_group(string @groupName)
        {
            @GroupName = @groupName;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "group_name", @out: false, min: 1, max: 1)]
        public string @GroupName { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "group_id", @out: true, min: 0, max: 1)]
        public string @GroupId { get; }

        [nterraform.Core.TerraformProperty(name: "path", @out: true, min: 0, max: 1)]
        public string @Path { get; }
    }

}
