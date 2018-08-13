using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_cloudwatch_log_group")]
    public sealed class aws_cloudwatch_log_group : nterraform.data
    {
        public aws_cloudwatch_log_group(string @name)
        {
            @Name = @name;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "creation_time", @out: true, min: 0, max: 1)]
        public int? @CreationTime { get; }
    }

}
