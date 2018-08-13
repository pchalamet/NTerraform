using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_secretsmanager_secret_version")]
    public sealed class aws_secretsmanager_secret_version : nterraform.data
    {
        public aws_secretsmanager_secret_version(string @secretId,
                                                 string @versionStage = null)
        {
            @SecretId = @secretId;
            @VersionStage = @versionStage;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "secret_id", @out: false, min: 1, max: 1)]
        public string @SecretId { get; }

        [nterraform.TerraformProperty(name: "secret_string", @out: true, min: 0, max: 1)]
        public string @SecretString { get; }

        [nterraform.TerraformProperty(name: "version_id", @out: true, min: 0, max: 1)]
        public string @VersionId { get; }

        [nterraform.TerraformProperty(name: "version_stage", @out: false, min: 0, max: 1)]
        public string @VersionStage { get; }

        [nterraform.TerraformProperty(name: "version_stages", @out: true, min: 0, max: 1)]
        public string[] @VersionStages { get; }
    }

}
