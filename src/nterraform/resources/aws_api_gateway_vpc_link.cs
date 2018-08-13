using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_api_gateway_vpc_link")]
    public sealed class aws_api_gateway_vpc_link : nterraform.Core.resource
    {
        public aws_api_gateway_vpc_link(string @name,
                                        string[] @targetArns,
                                        string @description = null)
        {
            @Name = @name;
            @TargetArns = @targetArns;
            @Description = @description;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "target_arns", @out: false, min: 1, max: 1)]
        public string[] @TargetArns { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }
    }

}
