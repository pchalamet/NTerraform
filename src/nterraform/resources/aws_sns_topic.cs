using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_sns_topic")]
    public sealed class aws_sns_topic : nterraform.resource
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

        [nterraform.TerraformProperty(name: "application_failure_feedback_role_arn", @out: false, min: 0, max: 1)]
        public string @ApplicationFailureFeedbackRoleArn { get; }

        [nterraform.TerraformProperty(name: "application_success_feedback_role_arn", @out: false, min: 0, max: 1)]
        public string @ApplicationSuccessFeedbackRoleArn { get; }

        [nterraform.TerraformProperty(name: "application_success_feedback_sample_rate", @out: false, min: 0, max: 1)]
        public int? @ApplicationSuccessFeedbackSampleRate { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "delivery_policy", @out: false, min: 0, max: 1)]
        public string @DeliveryPolicy { get; }

        [nterraform.TerraformProperty(name: "display_name", @out: false, min: 0, max: 1)]
        public string @DisplayName { get; }

        [nterraform.TerraformProperty(name: "http_failure_feedback_role_arn", @out: false, min: 0, max: 1)]
        public string @HttpFailureFeedbackRoleArn { get; }

        [nterraform.TerraformProperty(name: "http_success_feedback_role_arn", @out: false, min: 0, max: 1)]
        public string @HttpSuccessFeedbackRoleArn { get; }

        [nterraform.TerraformProperty(name: "http_success_feedback_sample_rate", @out: false, min: 0, max: 1)]
        public int? @HttpSuccessFeedbackSampleRate { get; }

        [nterraform.TerraformProperty(name: "lambda_failure_feedback_role_arn", @out: false, min: 0, max: 1)]
        public string @LambdaFailureFeedbackRoleArn { get; }

        [nterraform.TerraformProperty(name: "lambda_success_feedback_role_arn", @out: false, min: 0, max: 1)]
        public string @LambdaSuccessFeedbackRoleArn { get; }

        [nterraform.TerraformProperty(name: "lambda_success_feedback_sample_rate", @out: false, min: 0, max: 1)]
        public int? @LambdaSuccessFeedbackSampleRate { get; }

        [nterraform.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "name_prefix", @out: false, min: 0, max: 1)]
        public string @NamePrefix { get; }

        [nterraform.TerraformProperty(name: "policy", @out: true, min: 0, max: 1)]
        public string @Policy { get; }

        [nterraform.TerraformProperty(name: "sqs_failure_feedback_role_arn", @out: false, min: 0, max: 1)]
        public string @SqsFailureFeedbackRoleArn { get; }

        [nterraform.TerraformProperty(name: "sqs_success_feedback_role_arn", @out: false, min: 0, max: 1)]
        public string @SqsSuccessFeedbackRoleArn { get; }

        [nterraform.TerraformProperty(name: "sqs_success_feedback_sample_rate", @out: false, min: 0, max: 1)]
        public int? @SqsSuccessFeedbackSampleRate { get; }
    }

}
