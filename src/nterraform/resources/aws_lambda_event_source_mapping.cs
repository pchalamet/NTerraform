using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_lambda_event_source_mapping")]
    public sealed class aws_lambda_event_source_mapping : nterraform.Core.resource
    {
        public aws_lambda_event_source_mapping(string @eventSourceArn,
                                               string @functionName,
                                               int? @batchSize = null,
                                               bool? @enabled = null,
                                               string @startingPosition = null)
        {
            @EventSourceArn = @eventSourceArn;
            @FunctionName = @functionName;
            @BatchSize = @batchSize;
            @Enabled = @enabled;
            @StartingPosition = @startingPosition;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "event_source_arn", @out: false, min: 1, max: 1)]
        public string @EventSourceArn { get; }

        [nterraform.Core.TerraformProperty(name: "function_name", @out: false, min: 1, max: 1)]
        public string @FunctionName { get; }

        [nterraform.Core.TerraformProperty(name: "batch_size", @out: false, min: 0, max: 1)]
        public int? @BatchSize { get; }

        [nterraform.Core.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
        public bool? @Enabled { get; }

        [nterraform.Core.TerraformProperty(name: "function_arn", @out: true, min: 0, max: 1)]
        public string @FunctionArn { get; }

        [nterraform.Core.TerraformProperty(name: "last_modified", @out: true, min: 0, max: 1)]
        public string @LastModified { get; }

        [nterraform.Core.TerraformProperty(name: "last_processing_result", @out: true, min: 0, max: 1)]
        public string @LastProcessingResult { get; }

        [nterraform.Core.TerraformProperty(name: "starting_position", @out: false, min: 0, max: 1)]
        public string @StartingPosition { get; }

        [nterraform.Core.TerraformProperty(name: "state", @out: true, min: 0, max: 1)]
        public string @State { get; }

        [nterraform.Core.TerraformProperty(name: "state_transition_reason", @out: true, min: 0, max: 1)]
        public string @StateTransitionReason { get; }

        [nterraform.Core.TerraformProperty(name: "uuid", @out: true, min: 0, max: 1)]
        public string @Uuid { get; }
    }

}
