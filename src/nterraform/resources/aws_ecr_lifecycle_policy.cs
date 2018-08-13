using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_ecr_lifecycle_policy")]
    public sealed class aws_ecr_lifecycle_policy : nterraform.Core.resource
    {
        public aws_ecr_lifecycle_policy(string @policy,
                                        string @repository)
        {
            @Policy = @policy;
            @Repository = @repository;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "policy", @out: false, min: 1, max: 1)]
        public string @Policy { get; }

        [nterraform.Core.TerraformProperty(name: "repository", @out: false, min: 1, max: 1)]
        public string @Repository { get; }

        [nterraform.Core.TerraformProperty(name: "registry_id", @out: true, min: 0, max: 1)]
        public string @RegistryId { get; }
    }

}
