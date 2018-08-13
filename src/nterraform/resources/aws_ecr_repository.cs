using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_ecr_repository")]
    public sealed class aws_ecr_repository : nterraform.Core.resource
    {
        public aws_ecr_repository(string @name)
        {
            @Name = @name;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "registry_id", @out: true, min: 0, max: 1)]
        public string @RegistryId { get; }

        [nterraform.Core.TerraformProperty(name: "repository_url", @out: true, min: 0, max: 1)]
        public string @RepositoryUrl { get; }
    }

}