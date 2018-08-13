using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_inspector_resource_group")]
    public sealed class aws_inspector_resource_group : nterraform.Core.resource
    {
        public aws_inspector_resource_group(Dictionary<string,string> @tags)
        {
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 1, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }
    }

}
