using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_cloudwatch_log_group")]
    public sealed class aws_cloudwatch_log_group : nterraform.resource
    {
        public aws_cloudwatch_log_group(string @kmsKeyId = null,
                                        string @namePrefix = null,
                                        int? @retentionInDays = null,
                                        Dictionary<string,string> @tags = null)
        {
            @KmsKeyId = @kmsKeyId;
            @NamePrefix = @namePrefix;
            @RetentionInDays = @retentionInDays;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "kms_key_id", @out: false, min: 0, max: 1)]
        public string @KmsKeyId { get; }

        [nterraform.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "name_prefix", @out: false, min: 0, max: 1)]
        public string @NamePrefix { get; }

        [nterraform.TerraformProperty(name: "retention_in_days", @out: false, min: 0, max: 1)]
        public int? @RetentionInDays { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
