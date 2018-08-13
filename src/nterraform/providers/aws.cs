using System.Collections.Generic;

namespace nterraform.providers
{
    [nterraform.Core.TerraformStructure(category: "provider", typeName: "aws")]
    public sealed class aws : nterraform.Core.provider
    {
        [nterraform.Core.TerraformStructure(category: "provider", typeName: "endpoints")]
        public sealed class endpoints : nterraform.Core.structure
        {
            public endpoints(string @acm = null,
                             string @apigateway = null,
                             string @autoscaling = null,
                             string @cloudformation = null,
                             string @cloudwatch = null,
                             string @cloudwatchevents = null,
                             string @cloudwatchlogs = null,
                             string @devicefarm = null,
                             string @dynamodb = null,
                             string @ec2 = null,
                             string @ecr = null,
                             string @ecs = null,
                             string @efs = null,
                             string @elb = null,
                             string @es = null,
                             string @iam = null,
                             string @kinesis = null,
                             string @kms = null,
                             string @lambda = null,
                             string @r53 = null,
                             string @rds = null,
                             string @s3 = null,
                             string @sns = null,
                             string @sqs = null,
                             string @ssm = null,
                             string @sts = null)
            {
                @Acm = @acm;
                @Apigateway = @apigateway;
                @Autoscaling = @autoscaling;
                @Cloudformation = @cloudformation;
                @Cloudwatch = @cloudwatch;
                @Cloudwatchevents = @cloudwatchevents;
                @Cloudwatchlogs = @cloudwatchlogs;
                @Devicefarm = @devicefarm;
                @Dynamodb = @dynamodb;
                @Ec2 = @ec2;
                @Ecr = @ecr;
                @Ecs = @ecs;
                @Efs = @efs;
                @Elb = @elb;
                @Es = @es;
                @Iam = @iam;
                @Kinesis = @kinesis;
                @Kms = @kms;
                @Lambda = @lambda;
                @R53 = @r53;
                @Rds = @rds;
                @S3 = @s3;
                @Sns = @sns;
                @Sqs = @sqs;
                @Ssm = @ssm;
                @Sts = @sts;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "acm", @out: false, min: 0, max: 1)]
            public string @Acm { get; }

            [nterraform.Core.TerraformProperty(name: "apigateway", @out: false, min: 0, max: 1)]
            public string @Apigateway { get; }

            [nterraform.Core.TerraformProperty(name: "autoscaling", @out: false, min: 0, max: 1)]
            public string @Autoscaling { get; }

            [nterraform.Core.TerraformProperty(name: "cloudformation", @out: false, min: 0, max: 1)]
            public string @Cloudformation { get; }

            [nterraform.Core.TerraformProperty(name: "cloudwatch", @out: false, min: 0, max: 1)]
            public string @Cloudwatch { get; }

            [nterraform.Core.TerraformProperty(name: "cloudwatchevents", @out: false, min: 0, max: 1)]
            public string @Cloudwatchevents { get; }

            [nterraform.Core.TerraformProperty(name: "cloudwatchlogs", @out: false, min: 0, max: 1)]
            public string @Cloudwatchlogs { get; }

            [nterraform.Core.TerraformProperty(name: "devicefarm", @out: false, min: 0, max: 1)]
            public string @Devicefarm { get; }

            [nterraform.Core.TerraformProperty(name: "dynamodb", @out: false, min: 0, max: 1)]
            public string @Dynamodb { get; }

            [nterraform.Core.TerraformProperty(name: "ec2", @out: false, min: 0, max: 1)]
            public string @Ec2 { get; }

            [nterraform.Core.TerraformProperty(name: "ecr", @out: false, min: 0, max: 1)]
            public string @Ecr { get; }

            [nterraform.Core.TerraformProperty(name: "ecs", @out: false, min: 0, max: 1)]
            public string @Ecs { get; }

            [nterraform.Core.TerraformProperty(name: "efs", @out: false, min: 0, max: 1)]
            public string @Efs { get; }

            [nterraform.Core.TerraformProperty(name: "elb", @out: false, min: 0, max: 1)]
            public string @Elb { get; }

            [nterraform.Core.TerraformProperty(name: "es", @out: false, min: 0, max: 1)]
            public string @Es { get; }

            [nterraform.Core.TerraformProperty(name: "iam", @out: false, min: 0, max: 1)]
            public string @Iam { get; }

            [nterraform.Core.TerraformProperty(name: "kinesis", @out: false, min: 0, max: 1)]
            public string @Kinesis { get; }

            [nterraform.Core.TerraformProperty(name: "kms", @out: false, min: 0, max: 1)]
            public string @Kms { get; }

            [nterraform.Core.TerraformProperty(name: "lambda", @out: false, min: 0, max: 1)]
            public string @Lambda { get; }

            [nterraform.Core.TerraformProperty(name: "r53", @out: false, min: 0, max: 1)]
            public string @R53 { get; }

            [nterraform.Core.TerraformProperty(name: "rds", @out: false, min: 0, max: 1)]
            public string @Rds { get; }

            [nterraform.Core.TerraformProperty(name: "s3", @out: false, min: 0, max: 1)]
            public string @S3 { get; }

            [nterraform.Core.TerraformProperty(name: "sns", @out: false, min: 0, max: 1)]
            public string @Sns { get; }

            [nterraform.Core.TerraformProperty(name: "sqs", @out: false, min: 0, max: 1)]
            public string @Sqs { get; }

            [nterraform.Core.TerraformProperty(name: "ssm", @out: false, min: 0, max: 1)]
            public string @Ssm { get; }

            [nterraform.Core.TerraformProperty(name: "sts", @out: false, min: 0, max: 1)]
            public string @Sts { get; }
        }

        [nterraform.Core.TerraformStructure(category: "provider", typeName: "assume_role")]
        public sealed class assume_role : nterraform.Core.structure
        {
            public assume_role(string @externalId = null,
                               string @policy = null,
                               string @roleArn = null,
                               string @sessionName = null)
            {
                @ExternalId = @externalId;
                @Policy = @policy;
                @RoleArn = @roleArn;
                @SessionName = @sessionName;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "external_id", @out: false, min: 0, max: 1)]
            public string @ExternalId { get; }

            [nterraform.Core.TerraformProperty(name: "policy", @out: false, min: 0, max: 1)]
            public string @Policy { get; }

            [nterraform.Core.TerraformProperty(name: "role_arn", @out: false, min: 0, max: 1)]
            public string @RoleArn { get; }

            [nterraform.Core.TerraformProperty(name: "session_name", @out: false, min: 0, max: 1)]
            public string @SessionName { get; }
        }

        public aws(string @region,
                   string @accessKey = null,
                   string[] @allowedAccountIds = null,
                   assume_role[] @assumeRole = null,
                   string @dynamodbEndpoint = null,
                   endpoints[] @endpoints = null,
                   string[] @forbiddenAccountIds = null,
                   bool? @insecure = null,
                   string @kinesisEndpoint = null,
                   int? @maxRetries = null,
                   string @profile = null,
                   bool? @s3ForcePathStyle = null,
                   string @secretKey = null,
                   string @sharedCredentialsFile = null,
                   bool? @skipCredentialsValidation = null,
                   bool? @skipGetEc2Platforms = null,
                   bool? @skipMetadataApiCheck = null,
                   bool? @skipRegionValidation = null,
                   bool? @skipRequestingAccountId = null,
                   string @token = null)
        {
            @Region = @region;
            @AccessKey = @accessKey;
            @AllowedAccountIds = @allowedAccountIds;
            @AssumeRole = @assumeRole;
            @DynamodbEndpoint = @dynamodbEndpoint;
            @Endpoints = @endpoints;
            @ForbiddenAccountIds = @forbiddenAccountIds;
            @Insecure = @insecure;
            @KinesisEndpoint = @kinesisEndpoint;
            @MaxRetries = @maxRetries;
            @Profile = @profile;
            @S3ForcePathStyle = @s3ForcePathStyle;
            @SecretKey = @secretKey;
            @SharedCredentialsFile = @sharedCredentialsFile;
            @SkipCredentialsValidation = @skipCredentialsValidation;
            @SkipGetEc2Platforms = @skipGetEc2Platforms;
            @SkipMetadataApiCheck = @skipMetadataApiCheck;
            @SkipRegionValidation = @skipRegionValidation;
            @SkipRequestingAccountId = @skipRequestingAccountId;
            @Token = @token;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "region", @out: false, min: 1, max: 1)]
        public string @Region { get; }

        [nterraform.Core.TerraformProperty(name: "access_key", @out: false, min: 0, max: 1)]
        public string @AccessKey { get; }

        [nterraform.Core.TerraformProperty(name: "allowed_account_ids", @out: false, min: 0, max: 1)]
        public string[] @AllowedAccountIds { get; }

        [nterraform.Core.TerraformProperty(name: "assume_role", @out: false, min: 0, max: 1)]
        public assume_role[] @AssumeRole { get; }

        [nterraform.Core.TerraformProperty(name: "dynamodb_endpoint", @out: false, min: 0, max: 1)]
        public string @DynamodbEndpoint { get; }

        [nterraform.Core.TerraformProperty(name: "endpoints", @out: false, min: 0, max: 0)]
        public endpoints[] @Endpoints { get; }

        [nterraform.Core.TerraformProperty(name: "forbidden_account_ids", @out: false, min: 0, max: 1)]
        public string[] @ForbiddenAccountIds { get; }

        [nterraform.Core.TerraformProperty(name: "insecure", @out: false, min: 0, max: 1)]
        public bool? @Insecure { get; }

        [nterraform.Core.TerraformProperty(name: "kinesis_endpoint", @out: false, min: 0, max: 1)]
        public string @KinesisEndpoint { get; }

        [nterraform.Core.TerraformProperty(name: "max_retries", @out: false, min: 0, max: 1)]
        public int? @MaxRetries { get; }

        [nterraform.Core.TerraformProperty(name: "profile", @out: false, min: 0, max: 1)]
        public string @Profile { get; }

        [nterraform.Core.TerraformProperty(name: "s3_force_path_style", @out: false, min: 0, max: 1)]
        public bool? @S3ForcePathStyle { get; }

        [nterraform.Core.TerraformProperty(name: "secret_key", @out: false, min: 0, max: 1)]
        public string @SecretKey { get; }

        [nterraform.Core.TerraformProperty(name: "shared_credentials_file", @out: false, min: 0, max: 1)]
        public string @SharedCredentialsFile { get; }

        [nterraform.Core.TerraformProperty(name: "skip_credentials_validation", @out: false, min: 0, max: 1)]
        public bool? @SkipCredentialsValidation { get; }

        [nterraform.Core.TerraformProperty(name: "skip_get_ec2_platforms", @out: false, min: 0, max: 1)]
        public bool? @SkipGetEc2Platforms { get; }

        [nterraform.Core.TerraformProperty(name: "skip_metadata_api_check", @out: false, min: 0, max: 1)]
        public bool? @SkipMetadataApiCheck { get; }

        [nterraform.Core.TerraformProperty(name: "skip_region_validation", @out: false, min: 0, max: 1)]
        public bool? @SkipRegionValidation { get; }

        [nterraform.Core.TerraformProperty(name: "skip_requesting_account_id", @out: false, min: 0, max: 1)]
        public bool? @SkipRequestingAccountId { get; }

        [nterraform.Core.TerraformProperty(name: "token", @out: false, min: 0, max: 1)]
        public string @Token { get; }
    }

}
