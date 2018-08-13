using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_ses_receipt_rule")]
    public sealed class aws_ses_receipt_rule : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "lambda_action")]
        public sealed class lambda_action : nterraform.Core.structure
        {
            public lambda_action(string @functionArn,
                                 int @position,
                                 string @topicArn = null)
            {
                @FunctionArn = @functionArn;
                @Position = @position;
                @TopicArn = @topicArn;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "function_arn", @out: false, min: 1, max: 1)]
            public string @FunctionArn { get; }

            [nterraform.Core.TerraformProperty(name: "position", @out: false, min: 1, max: 1)]
            public int @Position { get; }

            [nterraform.Core.TerraformProperty(name: "invocation_type", @out: true, min: 0, max: 1)]
            public string @InvocationType { get; }

            [nterraform.Core.TerraformProperty(name: "topic_arn", @out: false, min: 0, max: 1)]
            public string @TopicArn { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "sns_action")]
        public sealed class sns_action : nterraform.Core.structure
        {
            public sns_action(int @position,
                              string @topicArn)
            {
                @Position = @position;
                @TopicArn = @topicArn;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "position", @out: false, min: 1, max: 1)]
            public int @Position { get; }

            [nterraform.Core.TerraformProperty(name: "topic_arn", @out: false, min: 1, max: 1)]
            public string @TopicArn { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "workmail_action")]
        public sealed class workmail_action : nterraform.Core.structure
        {
            public workmail_action(string @organizationArn,
                                   int @position,
                                   string @topicArn = null)
            {
                @OrganizationArn = @organizationArn;
                @Position = @position;
                @TopicArn = @topicArn;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "organization_arn", @out: false, min: 1, max: 1)]
            public string @OrganizationArn { get; }

            [nterraform.Core.TerraformProperty(name: "position", @out: false, min: 1, max: 1)]
            public int @Position { get; }

            [nterraform.Core.TerraformProperty(name: "topic_arn", @out: false, min: 0, max: 1)]
            public string @TopicArn { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "s3_action")]
        public sealed class s3_action : nterraform.Core.structure
        {
            public s3_action(string @bucketName,
                             int @position,
                             string @kmsKeyArn = null,
                             string @objectKeyPrefix = null,
                             string @topicArn = null)
            {
                @BucketName = @bucketName;
                @Position = @position;
                @KmsKeyArn = @kmsKeyArn;
                @ObjectKeyPrefix = @objectKeyPrefix;
                @TopicArn = @topicArn;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "bucket_name", @out: false, min: 1, max: 1)]
            public string @BucketName { get; }

            [nterraform.Core.TerraformProperty(name: "position", @out: false, min: 1, max: 1)]
            public int @Position { get; }

            [nterraform.Core.TerraformProperty(name: "kms_key_arn", @out: false, min: 0, max: 1)]
            public string @KmsKeyArn { get; }

            [nterraform.Core.TerraformProperty(name: "object_key_prefix", @out: false, min: 0, max: 1)]
            public string @ObjectKeyPrefix { get; }

            [nterraform.Core.TerraformProperty(name: "topic_arn", @out: false, min: 0, max: 1)]
            public string @TopicArn { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "stop_action")]
        public sealed class stop_action : nterraform.Core.structure
        {
            public stop_action(int @position,
                               string @scope,
                               string @topicArn = null)
            {
                @Position = @position;
                @Scope = @scope;
                @TopicArn = @topicArn;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "position", @out: false, min: 1, max: 1)]
            public int @Position { get; }

            [nterraform.Core.TerraformProperty(name: "scope", @out: false, min: 1, max: 1)]
            public string @Scope { get; }

            [nterraform.Core.TerraformProperty(name: "topic_arn", @out: false, min: 0, max: 1)]
            public string @TopicArn { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "add_header_action")]
        public sealed class add_header_action : nterraform.Core.structure
        {
            public add_header_action(string @headerName,
                                     string @headerValue,
                                     int @position)
            {
                @HeaderName = @headerName;
                @HeaderValue = @headerValue;
                @Position = @position;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "header_name", @out: false, min: 1, max: 1)]
            public string @HeaderName { get; }

            [nterraform.Core.TerraformProperty(name: "header_value", @out: false, min: 1, max: 1)]
            public string @HeaderValue { get; }

            [nterraform.Core.TerraformProperty(name: "position", @out: false, min: 1, max: 1)]
            public int @Position { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "bounce_action")]
        public sealed class bounce_action : nterraform.Core.structure
        {
            public bounce_action(string @message,
                                 int @position,
                                 string @sender,
                                 string @smtpReplyCode,
                                 string @statusCode = null,
                                 string @topicArn = null)
            {
                @Message = @message;
                @Position = @position;
                @Sender = @sender;
                @SmtpReplyCode = @smtpReplyCode;
                @StatusCode = @statusCode;
                @TopicArn = @topicArn;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "message", @out: false, min: 1, max: 1)]
            public string @Message { get; }

            [nterraform.Core.TerraformProperty(name: "position", @out: false, min: 1, max: 1)]
            public int @Position { get; }

            [nterraform.Core.TerraformProperty(name: "sender", @out: false, min: 1, max: 1)]
            public string @Sender { get; }

            [nterraform.Core.TerraformProperty(name: "smtp_reply_code", @out: false, min: 1, max: 1)]
            public string @SmtpReplyCode { get; }

            [nterraform.Core.TerraformProperty(name: "status_code", @out: false, min: 0, max: 1)]
            public string @StatusCode { get; }

            [nterraform.Core.TerraformProperty(name: "topic_arn", @out: false, min: 0, max: 1)]
            public string @TopicArn { get; }
        }

        public aws_ses_receipt_rule(string @name,
                                    string @ruleSetName,
                                    add_header_action[] @addHeaderAction = null,
                                    string @after = null,
                                    bounce_action[] @bounceAction = null,
                                    lambda_action[] @lambdaAction = null,
                                    string[] @recipients = null,
                                    s3_action[] @s3Action = null,
                                    sns_action[] @snsAction = null,
                                    stop_action[] @stopAction = null,
                                    workmail_action[] @workmailAction = null)
        {
            @Name = @name;
            @RuleSetName = @ruleSetName;
            @AddHeaderAction = @addHeaderAction;
            @After = @after;
            @BounceAction = @bounceAction;
            @LambdaAction = @lambdaAction;
            @Recipients = @recipients;
            @S3Action = @s3Action;
            @SnsAction = @snsAction;
            @StopAction = @stopAction;
            @WorkmailAction = @workmailAction;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "rule_set_name", @out: false, min: 1, max: 1)]
        public string @RuleSetName { get; }

        [nterraform.Core.TerraformProperty(name: "add_header_action", @out: false, min: 0, max: 0)]
        public add_header_action[] @AddHeaderAction { get; }

        [nterraform.Core.TerraformProperty(name: "after", @out: false, min: 0, max: 1)]
        public string @After { get; }

        [nterraform.Core.TerraformProperty(name: "bounce_action", @out: false, min: 0, max: 0)]
        public bounce_action[] @BounceAction { get; }

        [nterraform.Core.TerraformProperty(name: "enabled", @out: true, min: 0, max: 1)]
        public bool? @Enabled { get; }

        [nterraform.Core.TerraformProperty(name: "lambda_action", @out: false, min: 0, max: 0)]
        public lambda_action[] @LambdaAction { get; }

        [nterraform.Core.TerraformProperty(name: "recipients", @out: false, min: 0, max: 1)]
        public string[] @Recipients { get; }

        [nterraform.Core.TerraformProperty(name: "s3_action", @out: false, min: 0, max: 0)]
        public s3_action[] @S3Action { get; }

        [nterraform.Core.TerraformProperty(name: "scan_enabled", @out: true, min: 0, max: 1)]
        public bool? @ScanEnabled { get; }

        [nterraform.Core.TerraformProperty(name: "sns_action", @out: false, min: 0, max: 0)]
        public sns_action[] @SnsAction { get; }

        [nterraform.Core.TerraformProperty(name: "stop_action", @out: false, min: 0, max: 0)]
        public stop_action[] @StopAction { get; }

        [nterraform.Core.TerraformProperty(name: "tls_policy", @out: true, min: 0, max: 1)]
        public string @TlsPolicy { get; }

        [nterraform.Core.TerraformProperty(name: "workmail_action", @out: false, min: 0, max: 0)]
        public workmail_action[] @WorkmailAction { get; }
    }

}
