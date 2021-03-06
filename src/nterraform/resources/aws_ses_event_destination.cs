using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_ses_event_destination")]
    public sealed class aws_ses_event_destination : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "cloudwatch_destination")]
        public sealed class cloudwatch_destination : nterraform.structure
        {
            public cloudwatch_destination(string @defaultValue,
                                          string @dimensionName,
                                          string @valueSource)
            {
                @DefaultValue = @defaultValue;
                @DimensionName = @dimensionName;
                @ValueSource = @valueSource;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "default_value", @out: false, min: 1, max: 1)]
            public string @DefaultValue { get; }

            [nterraform.TerraformProperty(name: "dimension_name", @out: false, min: 1, max: 1)]
            public string @DimensionName { get; }

            [nterraform.TerraformProperty(name: "value_source", @out: false, min: 1, max: 1)]
            public string @ValueSource { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "kinesis_destination")]
        public sealed class kinesis_destination : nterraform.structure
        {
            public kinesis_destination(string @roleArn,
                                       string @streamArn)
            {
                @RoleArn = @roleArn;
                @StreamArn = @streamArn;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
            public string @RoleArn { get; }

            [nterraform.TerraformProperty(name: "stream_arn", @out: false, min: 1, max: 1)]
            public string @StreamArn { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "sns_destination")]
        public sealed class sns_destination : nterraform.structure
        {
            public sns_destination(string @topicArn)
            {
                @TopicArn = @topicArn;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "topic_arn", @out: false, min: 1, max: 1)]
            public string @TopicArn { get; }
        }

        public aws_ses_event_destination(string @configurationSetName,
                                         string[] @matchingTypes,
                                         string @name,
                                         cloudwatch_destination[] @cloudwatchDestination = null,
                                         bool? @enabled = null,
                                         kinesis_destination[] @kinesisDestination = null,
                                         sns_destination[] @snsDestination = null)
        {
            @ConfigurationSetName = @configurationSetName;
            @MatchingTypes = @matchingTypes;
            @Name = @name;
            @CloudwatchDestination = @cloudwatchDestination;
            @Enabled = @enabled;
            @KinesisDestination = @kinesisDestination;
            @SnsDestination = @snsDestination;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "configuration_set_name", @out: false, min: 1, max: 1)]
        public string @ConfigurationSetName { get; }

        [nterraform.TerraformProperty(name: "matching_types", @out: false, min: 1, max: 1)]
        public string[] @MatchingTypes { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "cloudwatch_destination", @out: false, min: 0, max: 1)]
        public cloudwatch_destination[] @CloudwatchDestination { get; }

        [nterraform.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
        public bool? @Enabled { get; }

        [nterraform.TerraformProperty(name: "kinesis_destination", @out: false, min: 0, max: 1)]
        public kinesis_destination[] @KinesisDestination { get; }

        [nterraform.TerraformProperty(name: "sns_destination", @out: false, min: 0, max: 1)]
        public sns_destination[] @SnsDestination { get; }
    }

}
