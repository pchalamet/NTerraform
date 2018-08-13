using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_codecommit_repository")]
    public sealed class aws_codecommit_repository : nterraform.data
    {
        public aws_codecommit_repository(string @repositoryName)
        {
            @RepositoryName = @repositoryName;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "repository_name", @out: false, min: 1, max: 1)]
        public string @RepositoryName { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "clone_url_http", @out: true, min: 0, max: 1)]
        public string @CloneUrlHttp { get; }

        [nterraform.TerraformProperty(name: "clone_url_ssh", @out: true, min: 0, max: 1)]
        public string @CloneUrlSsh { get; }

        [nterraform.TerraformProperty(name: "repository_id", @out: true, min: 0, max: 1)]
        public string @RepositoryId { get; }
    }

}
