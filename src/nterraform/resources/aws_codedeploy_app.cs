using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_codedeploy_app")]
    public sealed class aws_codedeploy_app : nterraform.Core.resource
    {
        public aws_codedeploy_app(string @name,
                                  string @computePlatform = null)
        {
            @Name = @name;
            @ComputePlatform = @computePlatform;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "compute_platform", @out: false, min: 0, max: 1)]
        public string @ComputePlatform { get; }

        [nterraform.Core.TerraformProperty(name: "unique_id", @out: true, min: 0, max: 1)]
        public string @UniqueId { get; }
    }

}
