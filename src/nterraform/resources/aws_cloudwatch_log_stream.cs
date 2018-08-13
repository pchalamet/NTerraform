using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_cloudwatch_log_stream")]
    public sealed class aws_cloudwatch_log_stream : nterraform.resource
    {
        public aws_cloudwatch_log_stream(string @logGroupName,
                                         string @name)
        {
            @LogGroupName = @logGroupName;
            @Name = @name;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "log_group_name", @out: false, min: 1, max: 1)]
        public string @LogGroupName { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }
    }

}
