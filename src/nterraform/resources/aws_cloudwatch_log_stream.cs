using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_cloudwatch_log_stream")]
    public sealed class aws_cloudwatch_log_stream : nterraform.Core.resource
    {
        public aws_cloudwatch_log_stream(string @logGroupName,
                                         string @name)
        {
            @LogGroupName = @logGroupName;
            @Name = @name;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "log_group_name", @out: false, min: 1, max: 1)]
        public string @LogGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }
    }

}
