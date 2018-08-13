using System.Collections.Generic;

namespace nterraform.providers
{
    [nterraform.TerraformStructure(category: "provider", typeName: "aws")]
    public sealed class aws : nterraform.provider
    {
        [nterraform.TerraformStructure(category: "provider", typeName: "assume_role")]
        public sealed class assume_role : nterraform.structure
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

            [nterraform.TerraformProperty(name: "external_id", @out: false, min: 0, max: 1)]
            public string @ExternalId { get; }

            [nterraform.TerraformProperty(name: "policy", @out: false, min: 0, max: 1)]
            public string @Policy { get; }

            [nterraform.TerraformProperty(name: "role_arn", @out: false, min: 0, max: 1)]
            public string @RoleArn { get; }

            [nterraform.TerraformProperty(name: "session_name", @out: false, min: 0, max: 1)]
            public string @SessionName { get; }
        }

        [nterraform.TerraformStructure(category: "provider", typeName: "endpoints")]
        public sealed class endpoints : nterraform.structure
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

            [nterraform.TerraformProperty(name: "acm", @out: false, min: 0, max: 1)]
            public string @Acm { get; }

            [nterraform.TerraformProperty(name: "apigateway", @out: false, min: 0, max: 1)]
            public string @Apigateway { get; }

            [nterraform.TerraformProperty(name: "autoscaling", @out: false, min: 0, max: 1)]
            public string @Autoscaling { get; }

            [nterraform.TerraformProperty(name: "cloudformation", @out: false, min: 0, max: 1)]
            public string @Cloudformation { get; }

            [nterraform.TerraformProperty(name: "cloudwatch", @out: false, min: 0, max: 1)]
            public string @Cloudwatch { get; }

            [nterraform.TerraformProperty(name: "cloudwatchevents", @out: false, min: 0, max: 1)]
            public string @Cloudwatchevents { get; }

            [nterraform.TerraformProperty(name: "cloudwatchlogs", @out: false, min: 0, max: 1)]
            public string @Cloudwatchlogs { get; }

            [nterraform.TerraformProperty(name: "devicefarm", @out: false, min: 0, max: 1)]
            public string @Devicefarm { get; }

            [nterraform.TerraformProperty(name: "dynamodb", @out: false, min: 0, max: 1)]
            public string @Dynamodb { get; }

            [nterraform.TerraformProperty(name: "ec2", @out: false, min: 0, max: 1)]
            public string @Ec2 { get; }

            [nterraform.TerraformProperty(name: "ecr", @out: false, min: 0, max: 1)]
            public string @Ecr { get; }

            [nterraform.TerraformProperty(name: "ecs", @out: false, min: 0, max: 1)]
            public string @Ecs { get; }

            [nterraform.TerraformProperty(name: "efs", @out: false, min: 0, max: 1)]
            public string @Efs { get; }

            [nterraform.TerraformProperty(name: "elb", @out: false, min: 0, max: 1)]
            public string @Elb { get; }

            [nterraform.TerraformProperty(name: "es", @out: false, min: 0, max: 1)]
            public string @Es { get; }

            [nterraform.TerraformProperty(name: "iam", @out: false, min: 0, max: 1)]
            public string @Iam { get; }

            [nterraform.TerraformProperty(name: "kinesis", @out: false, min: 0, max: 1)]
            public string @Kinesis { get; }

            [nterraform.TerraformProperty(name: "kms", @out: false, min: 0, max: 1)]
            public string @Kms { get; }

            [nterraform.TerraformProperty(name: "lambda", @out: false, min: 0, max: 1)]
            public string @Lambda { get; }

            [nterraform.TerraformProperty(name: "r53", @out: false, min: 0, max: 1)]
            public string @R53 { get; }

            [nterraform.TerraformProperty(name: "rds", @out: false, min: 0, max: 1)]
            public string @Rds { get; }

            [nterraform.TerraformProperty(name: "s3", @out: false, min: 0, max: 1)]
            public string @S3 { get; }

            [nterraform.TerraformProperty(name: "sns", @out: false, min: 0, max: 1)]
            public string @Sns { get; }

            [nterraform.TerraformProperty(name: "sqs", @out: false, min: 0, max: 1)]
            public string @Sqs { get; }

            [nterraform.TerraformProperty(name: "ssm", @out: false, min: 0, max: 1)]
            public string @Ssm { get; }

            [nterraform.TerraformProperty(name: "sts", @out: false, min: 0, max: 1)]
            public string @Sts { get; }
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

        [nterraform.TerraformProperty(name: "region", @out: false, min: 1, max: 1)]
        public string @Region { get; }

        [nterraform.TerraformProperty(name: "access_key", @out: false, min: 0, max: 1)]
        public string @AccessKey { get; }

        [nterraform.TerraformProperty(name: "allowed_account_ids", @out: false, min: 0, max: 1)]
        public string[] @AllowedAccountIds { get; }

        [nterraform.TerraformProperty(name: "assume_role", @out: false, min: 0, max: 1)]
        public assume_role[] @AssumeRole { get; }

        [nterraform.TerraformProperty(name: "dynamodb_endpoint", @out: false, min: 0, max: 1)]
        public string @DynamodbEndpoint { get; }

        [nterraform.TerraformProperty(name: "endpoints", @out: false, min: 0, max: 0)]
        public endpoints[] @Endpoints { get; }

        [nterraform.TerraformProperty(name: "forbidden_account_ids", @out: false, min: 0, max: 1)]
        public string[] @ForbiddenAccountIds { get; }

        [nterraform.TerraformProperty(name: "insecure", @out: false, min: 0, max: 1)]
        public bool? @Insecure { get; }

        [nterraform.TerraformProperty(name: "kinesis_endpoint", @out: false, min: 0, max: 1)]
        public string @KinesisEndpoint { get; }

        [nterraform.TerraformProperty(name: "max_retries", @out: false, min: 0, max: 1)]
        public int? @MaxRetries { get; }

        [nterraform.TerraformProperty(name: "profile", @out: false, min: 0, max: 1)]
        public string @Profile { get; }

        [nterraform.TerraformProperty(name: "s3_force_path_style", @out: false, min: 0, max: 1)]
        public bool? @S3ForcePathStyle { get; }

        [nterraform.TerraformProperty(name: "secret_key", @out: false, min: 0, max: 1)]
        public string @SecretKey { get; }

        [nterraform.TerraformProperty(name: "shared_credentials_file", @out: false, min: 0, max: 1)]
        public string @SharedCredentialsFile { get; }

        [nterraform.TerraformProperty(name: "skip_credentials_validation", @out: false, min: 0, max: 1)]
        public bool? @SkipCredentialsValidation { get; }

        [nterraform.TerraformProperty(name: "skip_get_ec2_platforms", @out: false, min: 0, max: 1)]
        public bool? @SkipGetEc2Platforms { get; }

        [nterraform.TerraformProperty(name: "skip_metadata_api_check", @out: false, min: 0, max: 1)]
        public bool? @SkipMetadataApiCheck { get; }

        [nterraform.TerraformProperty(name: "skip_region_validation", @out: false, min: 0, max: 1)]
        public bool? @SkipRegionValidation { get; }

        [nterraform.TerraformProperty(name: "skip_requesting_account_id", @out: false, min: 0, max: 1)]
        public bool? @SkipRequestingAccountId { get; }

        [nterraform.TerraformProperty(name: "token", @out: false, min: 0, max: 1)]
        public string @Token { get; }
    }

}
