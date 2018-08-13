using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_codecommit_repository")]
    public sealed class aws_codecommit_repository : nterraform.Core.resource
    {
        public aws_codecommit_repository(string @repositoryName,
                                         string @defaultBranch = null,
                                         string @description = null)
        {
            @RepositoryName = @repositoryName;
            @DefaultBranch = @defaultBranch;
            @Description = @description;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "repository_name", @out: false, min: 1, max: 1)]
        public string @RepositoryName { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "clone_url_http", @out: true, min: 0, max: 1)]
        public string @CloneUrlHttp { get; }

        [nterraform.Core.TerraformProperty(name: "clone_url_ssh", @out: true, min: 0, max: 1)]
        public string @CloneUrlSsh { get; }

        [nterraform.Core.TerraformProperty(name: "default_branch", @out: false, min: 0, max: 1)]
        public string @DefaultBranch { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "repository_id", @out: true, min: 0, max: 1)]
        public string @RepositoryId { get; }
    }

}
