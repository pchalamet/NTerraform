using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_iot_policy")]
    public sealed class aws_iot_policy : nterraform.resource
    {
        public aws_iot_policy(string @name,
                              string @policy)
        {
            @Name = @name;
            @Policy = @policy;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "policy", @out: false, min: 1, max: 1)]
        public string @Policy { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "default_version_id", @out: true, min: 0, max: 1)]
        public string @DefaultVersionId { get; }
    }

}
