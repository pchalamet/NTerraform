using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_cloudwatch_log_group")]
    public sealed class aws_cloudwatch_log_group : nterraform.Core.data
    {
        public aws_cloudwatch_log_group(string @name)
        {
            @Name = @name;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "creation_time", @out: true, min: 0, max: 1)]
        public int? @CreationTime { get; }
    }

}