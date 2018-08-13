using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_ses_receipt_rule")]
    public sealed class aws_ses_receipt_rule : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "bounce_action")]
        public sealed class bounce_action : nterraform.structure
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

            [nterraform.TerraformProperty(name: "message", @out: false, min: 1, max: 1)]
            public string @Message { get; }

            [nterraform.TerraformProperty(name: "position", @out: false, min: 1, max: 1)]
            public int @Position { get; }

            [nterraform.TerraformProperty(name: "sender", @out: false, min: 1, max: 1)]
            public string @Sender { get; }

            [nterraform.TerraformProperty(name: "smtp_reply_code", @out: false, min: 1, max: 1)]
            public string @SmtpReplyCode { get; }

            [nterraform.TerraformProperty(name: "status_code", @out: false, min: 0, max: 1)]
            public string @StatusCode { get; }

            [nterraform.TerraformProperty(name: "topic_arn", @out: false, min: 0, max: 1)]
            public string @TopicArn { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "sns_action")]
        public sealed class sns_action : nterraform.structure
        {
            public sns_action(int @position,
                              string @topicArn)
            {
                @Position = @position;
                @TopicArn = @topicArn;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "position", @out: false, min: 1, max: 1)]
            public int @Position { get; }

            [nterraform.TerraformProperty(name: "topic_arn", @out: false, min: 1, max: 1)]
            public string @TopicArn { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "lambda_action")]
        public sealed class lambda_action : nterraform.structure
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

            [nterraform.TerraformProperty(name: "function_arn", @out: false, min: 1, max: 1)]
            public string @FunctionArn { get; }

            [nterraform.TerraformProperty(name: "position", @out: false, min: 1, max: 1)]
            public int @Position { get; }

            [nterraform.TerraformProperty(name: "invocation_type", @out: true, min: 0, max: 1)]
            public string @InvocationType { get; }

            [nterraform.TerraformProperty(name: "topic_arn", @out: false, min: 0, max: 1)]
            public string @TopicArn { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "s3_action")]
        public sealed class s3_action : nterraform.structure
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

            [nterraform.TerraformProperty(name: "bucket_name", @out: false, min: 1, max: 1)]
            public string @BucketName { get; }

            [nterraform.TerraformProperty(name: "position", @out: false, min: 1, max: 1)]
            public int @Position { get; }

            [nterraform.TerraformProperty(name: "kms_key_arn", @out: false, min: 0, max: 1)]
            public string @KmsKeyArn { get; }

            [nterraform.TerraformProperty(name: "object_key_prefix", @out: false, min: 0, max: 1)]
            public string @ObjectKeyPrefix { get; }

            [nterraform.TerraformProperty(name: "topic_arn", @out: false, min: 0, max: 1)]
            public string @TopicArn { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "workmail_action")]
        public sealed class workmail_action : nterraform.structure
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

            [nterraform.TerraformProperty(name: "organization_arn", @out: false, min: 1, max: 1)]
            public string @OrganizationArn { get; }

            [nterraform.TerraformProperty(name: "position", @out: false, min: 1, max: 1)]
            public int @Position { get; }

            [nterraform.TerraformProperty(name: "topic_arn", @out: false, min: 0, max: 1)]
            public string @TopicArn { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "stop_action")]
        public sealed class stop_action : nterraform.structure
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

            [nterraform.TerraformProperty(name: "position", @out: false, min: 1, max: 1)]
            public int @Position { get; }

            [nterraform.TerraformProperty(name: "scope", @out: false, min: 1, max: 1)]
            public string @Scope { get; }

            [nterraform.TerraformProperty(name: "topic_arn", @out: false, min: 0, max: 1)]
            public string @TopicArn { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "add_header_action")]
        public sealed class add_header_action : nterraform.structure
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

            [nterraform.TerraformProperty(name: "header_name", @out: false, min: 1, max: 1)]
            public string @HeaderName { get; }

            [nterraform.TerraformProperty(name: "header_value", @out: false, min: 1, max: 1)]
            public string @HeaderValue { get; }

            [nterraform.TerraformProperty(name: "position", @out: false, min: 1, max: 1)]
            public int @Position { get; }
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

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "rule_set_name", @out: false, min: 1, max: 1)]
        public string @RuleSetName { get; }

        [nterraform.TerraformProperty(name: "add_header_action", @out: false, min: 0, max: 0)]
        public add_header_action[] @AddHeaderAction { get; }

        [nterraform.TerraformProperty(name: "after", @out: false, min: 0, max: 1)]
        public string @After { get; }

        [nterraform.TerraformProperty(name: "bounce_action", @out: false, min: 0, max: 0)]
        public bounce_action[] @BounceAction { get; }

        [nterraform.TerraformProperty(name: "enabled", @out: true, min: 0, max: 1)]
        public bool? @Enabled { get; }

        [nterraform.TerraformProperty(name: "lambda_action", @out: false, min: 0, max: 0)]
        public lambda_action[] @LambdaAction { get; }

        [nterraform.TerraformProperty(name: "recipients", @out: false, min: 0, max: 1)]
        public string[] @Recipients { get; }

        [nterraform.TerraformProperty(name: "s3_action", @out: false, min: 0, max: 0)]
        public s3_action[] @S3Action { get; }

        [nterraform.TerraformProperty(name: "scan_enabled", @out: true, min: 0, max: 1)]
        public bool? @ScanEnabled { get; }

        [nterraform.TerraformProperty(name: "sns_action", @out: false, min: 0, max: 0)]
        public sns_action[] @SnsAction { get; }

        [nterraform.TerraformProperty(name: "stop_action", @out: false, min: 0, max: 0)]
        public stop_action[] @StopAction { get; }

        [nterraform.TerraformProperty(name: "tls_policy", @out: true, min: 0, max: 1)]
        public string @TlsPolicy { get; }

        [nterraform.TerraformProperty(name: "workmail_action", @out: false, min: 0, max: 0)]
        public workmail_action[] @WorkmailAction { get; }
    }

}
