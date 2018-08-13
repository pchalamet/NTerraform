using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_iot_policy")]
    public sealed class aws_iot_policy : nterraform.Core.resource
    {
        public aws_iot_policy(string @name,
                              string @policy)
        {
            @Name = @name;
            @Policy = @policy;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "policy", @out: false, min: 1, max: 1)]
        public string @Policy { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "default_version_id", @out: true, min: 0, max: 1)]
        public string @DefaultVersionId { get; }
    }

}
