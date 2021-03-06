using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_codedeploy_app")]
    public sealed class aws_codedeploy_app : nterraform.resource
    {
        public aws_codedeploy_app(string @name,
                                  string @computePlatform = null)
        {
            @Name = @name;
            @ComputePlatform = @computePlatform;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "compute_platform", @out: false, min: 0, max: 1)]
        public string @ComputePlatform { get; }

        [nterraform.TerraformProperty(name: "unique_id", @out: true, min: 0, max: 1)]
        public string @UniqueId { get; }
    }

}
