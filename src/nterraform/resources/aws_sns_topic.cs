using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_sns_topic")]
    public sealed class aws_sns_topic : nterraform.Core.resource
    {
        public aws_sns_topic(string @applicationFailureFeedbackRoleArn = null,
                             string @applicationSuccessFeedbackRoleArn = null,
                             int? @applicationSuccessFeedbackSampleRate = null,
                             string @deliveryPolicy = null,
                             string @displayName = null,
                             string @httpFailureFeedbackRoleArn = null,
                             string @httpSuccessFeedbackRoleArn = null,
                             int? @httpSuccessFeedbackSampleRate = null,
                             string @lambdaFailureFeedbackRoleArn = null,
                             string @lambdaSuccessFeedbackRoleArn = null,
                             int? @lambdaSuccessFeedbackSampleRate = null,
                             string @namePrefix = null,
                             string @sqsFailureFeedbackRoleArn = null,
                             string @sqsSuccessFeedbackRoleArn = null,
                             int? @sqsSuccessFeedbackSampleRate = null)
        {
            @ApplicationFailureFeedbackRoleArn = @applicationFailureFeedbackRoleArn;
            @ApplicationSuccessFeedbackRoleArn = @applicationSuccessFeedbackRoleArn;
            @ApplicationSuccessFeedbackSampleRate = @applicationSuccessFeedbackSampleRate;
            @DeliveryPolicy = @deliveryPolicy;
            @DisplayName = @displayName;
            @HttpFailureFeedbackRoleArn = @httpFailureFeedbackRoleArn;
            @HttpSuccessFeedbackRoleArn = @httpSuccessFeedbackRoleArn;
            @HttpSuccessFeedbackSampleRate = @httpSuccessFeedbackSampleRate;
            @LambdaFailureFeedbackRoleArn = @lambdaFailureFeedbackRoleArn;
            @LambdaSuccessFeedbackRoleArn = @lambdaSuccessFeedbackRoleArn;
            @LambdaSuccessFeedbackSampleRate = @lambdaSuccessFeedbackSampleRate;
            @NamePrefix = @namePrefix;
            @SqsFailureFeedbackRoleArn = @sqsFailureFeedbackRoleArn;
            @SqsSuccessFeedbackRoleArn = @sqsSuccessFeedbackRoleArn;
            @SqsSuccessFeedbackSampleRate = @sqsSuccessFeedbackSampleRate;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "application_failure_feedback_role_arn", @out: false, min: 0, max: 1)]
        public string @ApplicationFailureFeedbackRoleArn { get; }

        [nterraform.Core.TerraformProperty(name: "application_success_feedback_role_arn", @out: false, min: 0, max: 1)]
        public string @ApplicationSuccessFeedbackRoleArn { get; }

        [nterraform.Core.TerraformProperty(name: "application_success_feedback_sample_rate", @out: false, min: 0, max: 1)]
        public int? @ApplicationSuccessFeedbackSampleRate { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "delivery_policy", @out: false, min: 0, max: 1)]
        public string @DeliveryPolicy { get; }

        [nterraform.Core.TerraformProperty(name: "display_name", @out: false, min: 0, max: 1)]
        public string @DisplayName { get; }

        [nterraform.Core.TerraformProperty(name: "http_failure_feedback_role_arn", @out: false, min: 0, max: 1)]
        public string @HttpFailureFeedbackRoleArn { get; }

        [nterraform.Core.TerraformProperty(name: "http_success_feedback_role_arn", @out: false, min: 0, max: 1)]
        public string @HttpSuccessFeedbackRoleArn { get; }

        [nterraform.Core.TerraformProperty(name: "http_success_feedback_sample_rate", @out: false, min: 0, max: 1)]
        public int? @HttpSuccessFeedbackSampleRate { get; }

        [nterraform.Core.TerraformProperty(name: "lambda_failure_feedback_role_arn", @out: false, min: 0, max: 1)]
        public string @LambdaFailureFeedbackRoleArn { get; }

        [nterraform.Core.TerraformProperty(name: "lambda_success_feedback_role_arn", @out: false, min: 0, max: 1)]
        public string @LambdaSuccessFeedbackRoleArn { get; }

        [nterraform.Core.TerraformProperty(name: "lambda_success_feedback_sample_rate", @out: false, min: 0, max: 1)]
        public int? @LambdaSuccessFeedbackSampleRate { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "name_prefix", @out: false, min: 0, max: 1)]
        public string @NamePrefix { get; }

        [nterraform.Core.TerraformProperty(name: "policy", @out: true, min: 0, max: 1)]
        public string @Policy { get; }

        [nterraform.Core.TerraformProperty(name: "sqs_failure_feedback_role_arn", @out: false, min: 0, max: 1)]
        public string @SqsFailureFeedbackRoleArn { get; }

        [nterraform.Core.TerraformProperty(name: "sqs_success_feedback_role_arn", @out: false, min: 0, max: 1)]
        public string @SqsSuccessFeedbackRoleArn { get; }

        [nterraform.Core.TerraformProperty(name: "sqs_success_feedback_sample_rate", @out: false, min: 0, max: 1)]
        public int? @SqsSuccessFeedbackSampleRate { get; }
    }

}
