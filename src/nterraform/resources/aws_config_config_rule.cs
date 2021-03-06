using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_config_config_rule")]
    public sealed class aws_config_config_rule : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "scope")]
        public sealed class scope : nterraform.structure
        {
            public scope(string @complianceResourceId = null,
                         string[] @complianceResourceTypes = null,
                         string @tagKey = null,
                         string @tagValue = null)
            {
                @ComplianceResourceId = @complianceResourceId;
                @ComplianceResourceTypes = @complianceResourceTypes;
                @TagKey = @tagKey;
                @TagValue = @tagValue;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "compliance_resource_id", @out: false, min: 0, max: 1)]
            public string @ComplianceResourceId { get; }

            [nterraform.TerraformProperty(name: "compliance_resource_types", @out: false, min: 0, max: 1)]
            public string[] @ComplianceResourceTypes { get; }

            [nterraform.TerraformProperty(name: "tag_key", @out: false, min: 0, max: 1)]
            public string @TagKey { get; }

            [nterraform.TerraformProperty(name: "tag_value", @out: false, min: 0, max: 1)]
            public string @TagValue { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "source")]
        public sealed class source : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "source_detail")]
            public sealed class source_detail : nterraform.structure
            {
                public source_detail(string @eventSource = null,
                                     string @maximumExecutionFrequency = null,
                                     string @messageType = null)
                {
                    @EventSource = @eventSource;
                    @MaximumExecutionFrequency = @maximumExecutionFrequency;
                    @MessageType = @messageType;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "event_source", @out: false, min: 0, max: 1)]
                public string @EventSource { get; }

                [nterraform.TerraformProperty(name: "maximum_execution_frequency", @out: false, min: 0, max: 1)]
                public string @MaximumExecutionFrequency { get; }

                [nterraform.TerraformProperty(name: "message_type", @out: false, min: 0, max: 1)]
                public string @MessageType { get; }
            }

            public source(string @owner,
                          string @sourceIdentifier,
                          source_detail[] @sourceDetail = null)
            {
                @Owner = @owner;
                @SourceIdentifier = @sourceIdentifier;
                @SourceDetail = @sourceDetail;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "owner", @out: false, min: 1, max: 1)]
            public string @Owner { get; }

            [nterraform.TerraformProperty(name: "source_identifier", @out: false, min: 1, max: 1)]
            public string @SourceIdentifier { get; }

            [nterraform.TerraformProperty(name: "source_detail", @out: false, min: 0, max: 25)]
            public source_detail[] @SourceDetail { get; }
        }

        public aws_config_config_rule(string @name,
                                      source[] @source,
                                      string @description = null,
                                      string @inputParameters = null,
                                      string @maximumExecutionFrequency = null,
                                      scope[] @scope = null)
        {
            @Name = @name;
            @Source = @source;
            @Description = @description;
            @InputParameters = @inputParameters;
            @MaximumExecutionFrequency = @maximumExecutionFrequency;
            @Scope = @scope;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "source", @out: false, min: 1, max: 1)]
        public source[] @Source { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "input_parameters", @out: false, min: 0, max: 1)]
        public string @InputParameters { get; }

        [nterraform.TerraformProperty(name: "maximum_execution_frequency", @out: false, min: 0, max: 1)]
        public string @MaximumExecutionFrequency { get; }

        [nterraform.TerraformProperty(name: "rule_id", @out: true, min: 0, max: 1)]
        public string @RuleId { get; }

        [nterraform.TerraformProperty(name: "scope", @out: false, min: 0, max: 1)]
        public scope[] @Scope { get; }
    }

}
