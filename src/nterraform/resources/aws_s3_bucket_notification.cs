using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_s3_bucket_notification")]
    public sealed class aws_s3_bucket_notification : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "queue")]
        public sealed class queue : nterraform.structure
        {
            public queue(string[] @events,
                         string @queueArn,
                         string @filterPrefix = null,
                         string @filterSuffix = null)
            {
                @Events = @events;
                @QueueArn = @queueArn;
                @FilterPrefix = @filterPrefix;
                @FilterSuffix = @filterSuffix;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "events", @out: false, min: 1, max: 1)]
            public string[] @Events { get; }

            [nterraform.TerraformProperty(name: "queue_arn", @out: false, min: 1, max: 1)]
            public string @QueueArn { get; }

            [nterraform.TerraformProperty(name: "filter_prefix", @out: false, min: 0, max: 1)]
            public string @FilterPrefix { get; }

            [nterraform.TerraformProperty(name: "filter_suffix", @out: false, min: 0, max: 1)]
            public string @FilterSuffix { get; }

            [nterraform.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "lambda_function")]
        public sealed class lambda_function : nterraform.structure
        {
            public lambda_function(string[] @events,
                                   string @filterPrefix = null,
                                   string @filterSuffix = null,
                                   string @lambdaFunctionArn = null)
            {
                @Events = @events;
                @FilterPrefix = @filterPrefix;
                @FilterSuffix = @filterSuffix;
                @LambdaFunctionArn = @lambdaFunctionArn;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "events", @out: false, min: 1, max: 1)]
            public string[] @Events { get; }

            [nterraform.TerraformProperty(name: "filter_prefix", @out: false, min: 0, max: 1)]
            public string @FilterPrefix { get; }

            [nterraform.TerraformProperty(name: "filter_suffix", @out: false, min: 0, max: 1)]
            public string @FilterSuffix { get; }

            [nterraform.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }

            [nterraform.TerraformProperty(name: "lambda_function_arn", @out: false, min: 0, max: 1)]
            public string @LambdaFunctionArn { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "topic")]
        public sealed class topic : nterraform.structure
        {
            public topic(string[] @events,
                         string @topicArn,
                         string @filterPrefix = null,
                         string @filterSuffix = null)
            {
                @Events = @events;
                @TopicArn = @topicArn;
                @FilterPrefix = @filterPrefix;
                @FilterSuffix = @filterSuffix;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "events", @out: false, min: 1, max: 1)]
            public string[] @Events { get; }

            [nterraform.TerraformProperty(name: "topic_arn", @out: false, min: 1, max: 1)]
            public string @TopicArn { get; }

            [nterraform.TerraformProperty(name: "filter_prefix", @out: false, min: 0, max: 1)]
            public string @FilterPrefix { get; }

            [nterraform.TerraformProperty(name: "filter_suffix", @out: false, min: 0, max: 1)]
            public string @FilterSuffix { get; }

            [nterraform.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }
        }

        public aws_s3_bucket_notification(string @bucket,
                                          lambda_function[] @lambdaFunction = null,
                                          queue[] @queue = null,
                                          topic[] @topic = null)
        {
            @Bucket = @bucket;
            @LambdaFunction = @lambdaFunction;
            @Queue = @queue;
            @Topic = @topic;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "bucket", @out: false, min: 1, max: 1)]
        public string @Bucket { get; }

        [nterraform.TerraformProperty(name: "lambda_function", @out: false, min: 0, max: 0)]
        public lambda_function[] @LambdaFunction { get; }

        [nterraform.TerraformProperty(name: "queue", @out: false, min: 0, max: 0)]
        public queue[] @Queue { get; }

        [nterraform.TerraformProperty(name: "topic", @out: false, min: 0, max: 0)]
        public topic[] @Topic { get; }
    }

}
