using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_neptune_event_subscription")]
    public sealed class aws_neptune_event_subscription : nterraform.Core.resource
    {
        public aws_neptune_event_subscription(string @snsTopicArn,
                                              bool? @enabled = null,
                                              string[] @eventCategories = null,
                                              string[] @sourceIds = null,
                                              string @sourceType = null,
                                              Dictionary<string,string> @tags = null)
        {
            @SnsTopicArn = @snsTopicArn;
            @Enabled = @enabled;
            @EventCategories = @eventCategories;
            @SourceIds = @sourceIds;
            @SourceType = @sourceType;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "sns_topic_arn", @out: false, min: 1, max: 1)]
        public string @SnsTopicArn { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "customer_aws_id", @out: true, min: 0, max: 1)]
        public string @CustomerAwsId { get; }

        [nterraform.Core.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
        public bool? @Enabled { get; }

        [nterraform.Core.TerraformProperty(name: "event_categories", @out: false, min: 0, max: 1)]
        public string[] @EventCategories { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "name_prefix", @out: true, min: 0, max: 1)]
        public string @NamePrefix { get; }

        [nterraform.Core.TerraformProperty(name: "source_ids", @out: false, min: 0, max: 1)]
        public string[] @SourceIds { get; }

        [nterraform.Core.TerraformProperty(name: "source_type", @out: false, min: 0, max: 1)]
        public string @SourceType { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
