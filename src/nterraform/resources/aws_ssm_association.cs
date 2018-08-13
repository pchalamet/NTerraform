using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_ssm_association")]
    public sealed class aws_ssm_association : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "output_location")]
        public sealed class output_location : nterraform.Core.structure
        {
            public output_location(string @s3BucketName,
                                   string @s3KeyPrefix = null)
            {
                @S3BucketName = @s3BucketName;
                @S3KeyPrefix = @s3KeyPrefix;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "s3_bucket_name", @out: false, min: 1, max: 1)]
            public string @S3BucketName { get; }

            [nterraform.Core.TerraformProperty(name: "s3_key_prefix", @out: false, min: 0, max: 1)]
            public string @S3KeyPrefix { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "targets")]
        public sealed class targets : nterraform.Core.structure
        {
            public targets(string @key,
                           string[] @values)
            {
                @Key = @key;
                @Values = @values;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "key", @out: false, min: 1, max: 1)]
            public string @Key { get; }

            [nterraform.Core.TerraformProperty(name: "values", @out: false, min: 1, max: 1)]
            public string[] @Values { get; }
        }

        public aws_ssm_association(string @name,
                                   string @associationName = null,
                                   string @instanceId = null,
                                   output_location[] @outputLocation = null,
                                   string @scheduleExpression = null,
                                   targets[] @targets = null)
        {
            @Name = @name;
            @AssociationName = @associationName;
            @InstanceId = @instanceId;
            @OutputLocation = @outputLocation;
            @ScheduleExpression = @scheduleExpression;
            @Targets = @targets;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "association_id", @out: true, min: 0, max: 1)]
        public string @AssociationId { get; }

        [nterraform.Core.TerraformProperty(name: "association_name", @out: false, min: 0, max: 1)]
        public string @AssociationName { get; }

        [nterraform.Core.TerraformProperty(name: "document_version", @out: true, min: 0, max: 1)]
        public string @DocumentVersion { get; }

        [nterraform.Core.TerraformProperty(name: "instance_id", @out: false, min: 0, max: 1)]
        public string @InstanceId { get; }

        [nterraform.Core.TerraformProperty(name: "output_location", @out: false, min: 0, max: 1)]
        public output_location[] @OutputLocation { get; }

        [nterraform.Core.TerraformProperty(name: "parameters", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Parameters { get; }

        [nterraform.Core.TerraformProperty(name: "schedule_expression", @out: false, min: 0, max: 1)]
        public string @ScheduleExpression { get; }

        [nterraform.Core.TerraformProperty(name: "targets", @out: false, min: 0, max: 5)]
        public targets[] @Targets { get; }
    }

}
