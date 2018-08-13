using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_inspector_resource_group")]
    public sealed class aws_inspector_resource_group : nterraform.resource
    {
        public aws_inspector_resource_group(Dictionary<string,string> @tags)
        {
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 1, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }
    }

}
