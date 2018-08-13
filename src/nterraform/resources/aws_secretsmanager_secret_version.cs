using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_secretsmanager_secret_version")]
    public sealed class aws_secretsmanager_secret_version : nterraform.Core.resource
    {
        public aws_secretsmanager_secret_version(string @secretId,
                                                 string @secretString)
        {
            @SecretId = @secretId;
            @SecretString = @secretString;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "secret_id", @out: false, min: 1, max: 1)]
        public string @SecretId { get; }

        [nterraform.Core.TerraformProperty(name: "secret_string", @out: false, min: 1, max: 1)]
        public string @SecretString { get; }

        [nterraform.Core.TerraformProperty(name: "version_id", @out: true, min: 0, max: 1)]
        public string @VersionId { get; }

        [nterraform.Core.TerraformProperty(name: "version_stages", @out: true, min: 0, max: 1)]
        public string[] @VersionStages { get; }
    }

}