using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_iam_policy")]
    public sealed class aws_iam_policy : nterraform.Core.data
    {
        public aws_iam_policy(string @arn)
        {
            @Arn = @arn;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "arn", @out: false, min: 1, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: true, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "path", @out: true, min: 0, max: 1)]
        public string @Path { get; }

        [nterraform.Core.TerraformProperty(name: "policy", @out: true, min: 0, max: 1)]
        public string @Policy { get; }
    }

}
