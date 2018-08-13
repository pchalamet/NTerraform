using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_codecommit_repository")]
    public sealed class aws_codecommit_repository : nterraform.Core.data
    {
        public aws_codecommit_repository(string @repositoryName)
        {
            @RepositoryName = @repositoryName;
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

        [nterraform.Core.TerraformProperty(name: "repository_id", @out: true, min: 0, max: 1)]
        public string @RepositoryId { get; }
    }

}
