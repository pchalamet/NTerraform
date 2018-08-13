using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_ecr_repository_policy")]
    public sealed class aws_ecr_repository_policy : nterraform.resource
    {
        public aws_ecr_repository_policy(string @policy,
                                         string @repository)
        {
            @Policy = @policy;
            @Repository = @repository;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "policy", @out: false, min: 1, max: 1)]
        public string @Policy { get; }

        [nterraform.TerraformProperty(name: "repository", @out: false, min: 1, max: 1)]
        public string @Repository { get; }

        [nterraform.TerraformProperty(name: "registry_id", @out: true, min: 0, max: 1)]
        public string @RegistryId { get; }
    }

}
