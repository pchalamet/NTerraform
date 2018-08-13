using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_kinesis_firehose_delivery_stream")]
    public sealed class aws_kinesis_firehose_delivery_stream : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "kinesis_source_configuration")]
        public sealed class kinesis_source_configuration : nterraform.structure
        {
            public kinesis_source_configuration(string @kinesisStreamArn,
                                                string @roleArn)
            {
                @KinesisStreamArn = @kinesisStreamArn;
                @RoleArn = @roleArn;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "kinesis_stream_arn", @out: false, min: 1, max: 1)]
            public string @KinesisStreamArn { get; }

            [nterraform.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
            public string @RoleArn { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "s3_configuration")]
        public sealed class s3_configuration : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "cloudwatch_logging_options")]
            public sealed class cloudwatch_logging_options : nterraform.structure
            {
                public cloudwatch_logging_options(bool? @enabled = null,
                                                  string @logGroupName = null,
                                                  string @logStreamName = null)
                {
                    @Enabled = @enabled;
                    @LogGroupName = @logGroupName;
                    @LogStreamName = @logStreamName;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
                public bool? @Enabled { get; }

                [nterraform.TerraformProperty(name: "log_group_name", @out: false, min: 0, max: 1)]
                public string @LogGroupName { get; }

                [nterraform.TerraformProperty(name: "log_stream_name", @out: false, min: 0, max: 1)]
                public string @LogStreamName { get; }
            }

            public s3_configuration(string @bucketArn,
                                    string @roleArn,
                                    int? @bufferInterval = null,
                                    int? @bufferSize = null,
                                    cloudwatch_logging_options[] @cloudwatchLoggingOptions = null,
                                    string @compressionFormat = null,
                                    string @kmsKeyArn = null,
                                    string @prefix = null)
            {
                @BucketArn = @bucketArn;
                @RoleArn = @roleArn;
                @BufferInterval = @bufferInterval;
                @BufferSize = @bufferSize;
                @CloudwatchLoggingOptions = @cloudwatchLoggingOptions;
                @CompressionFormat = @compressionFormat;
                @KmsKeyArn = @kmsKeyArn;
                @Prefix = @prefix;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "bucket_arn", @out: false, min: 1, max: 1)]
            public string @BucketArn { get; }

            [nterraform.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
            public string @RoleArn { get; }

            [nterraform.TerraformProperty(name: "buffer_interval", @out: false, min: 0, max: 1)]
            public int? @BufferInterval { get; }

            [nterraform.TerraformProperty(name: "buffer_size", @out: false, min: 0, max: 1)]
            public int? @BufferSize { get; }

            [nterraform.TerraformProperty(name: "cloudwatch_logging_options", @out: false, min: 0, max: 1)]
            public cloudwatch_logging_options[] @CloudwatchLoggingOptions { get; }

            [nterraform.TerraformProperty(name: "compression_format", @out: false, min: 0, max: 1)]
            public string @CompressionFormat { get; }

            [nterraform.TerraformProperty(name: "kms_key_arn", @out: false, min: 0, max: 1)]
            public string @KmsKeyArn { get; }

            [nterraform.TerraformProperty(name: "prefix", @out: false, min: 0, max: 1)]
            public string @Prefix { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "redshift_configuration")]
        public sealed class redshift_configuration : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "processing_configuration")]
            public sealed class processing_configuration : nterraform.structure
            {
                [nterraform.TerraformStructure(category: "resource", typeName: "processors")]
                public sealed class processors : nterraform.structure
                {
                    [nterraform.TerraformStructure(category: "resource", typeName: "parameters")]
                    public sealed class parameters : nterraform.structure
                    {
                        public parameters(string @parameterName,
                                          string @parameterValue)
                        {
                            @ParameterName = @parameterName;
                            @ParameterValue = @parameterValue;
                            base._validate_();
                        }

                        [nterraform.TerraformProperty(name: "parameter_name", @out: false, min: 1, max: 1)]
                        public string @ParameterName { get; }

                        [nterraform.TerraformProperty(name: "parameter_value", @out: false, min: 1, max: 1)]
                        public string @ParameterValue { get; }
                    }

                    public processors(string @type,
                                      parameters[] @parameters = null)
                    {
                        @Type = @type;
                        @Parameters = @parameters;
                        base._validate_();
                    }

                    [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
                    public string @Type { get; }

                    [nterraform.TerraformProperty(name: "parameters", @out: false, min: 0, max: 0)]
                    public parameters[] @Parameters { get; }
                }

                public processing_configuration(bool? @enabled = null,
                                                processors[] @processors = null)
                {
                    @Enabled = @enabled;
                    @Processors = @processors;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
                public bool? @Enabled { get; }

                [nterraform.TerraformProperty(name: "processors", @out: false, min: 0, max: 0)]
                public processors[] @Processors { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "cloudwatch_logging_options")]
            public sealed class cloudwatch_logging_options : nterraform.structure
            {
                public cloudwatch_logging_options(bool? @enabled = null,
                                                  string @logGroupName = null,
                                                  string @logStreamName = null)
                {
                    @Enabled = @enabled;
                    @LogGroupName = @logGroupName;
                    @LogStreamName = @logStreamName;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
                public bool? @Enabled { get; }

                [nterraform.TerraformProperty(name: "log_group_name", @out: false, min: 0, max: 1)]
                public string @LogGroupName { get; }

                [nterraform.TerraformProperty(name: "log_stream_name", @out: false, min: 0, max: 1)]
                public string @LogStreamName { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "s3_backup_configuration")]
            public sealed class s3_backup_configuration : nterraform.structure
            {
                [nterraform.TerraformStructure(category: "resource", typeName: "cloudwatch_logging_options")]
                public sealed class cloudwatch_logging_options : nterraform.structure
                {
                    public cloudwatch_logging_options(bool? @enabled = null,
                                                      string @logGroupName = null,
                                                      string @logStreamName = null)
                    {
                        @Enabled = @enabled;
                        @LogGroupName = @logGroupName;
                        @LogStreamName = @logStreamName;
                        base._validate_();
                    }

                    [nterraform.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
                    public bool? @Enabled { get; }

                    [nterraform.TerraformProperty(name: "log_group_name", @out: false, min: 0, max: 1)]
                    public string @LogGroupName { get; }

                    [nterraform.TerraformProperty(name: "log_stream_name", @out: false, min: 0, max: 1)]
                    public string @LogStreamName { get; }
                }

                public s3_backup_configuration(string @bucketArn,
                                               string @roleArn,
                                               int? @bufferInterval = null,
                                               int? @bufferSize = null,
                                               cloudwatch_logging_options[] @cloudwatchLoggingOptions = null,
                                               string @compressionFormat = null,
                                               string @kmsKeyArn = null,
                                               string @prefix = null)
                {
                    @BucketArn = @bucketArn;
                    @RoleArn = @roleArn;
                    @BufferInterval = @bufferInterval;
                    @BufferSize = @bufferSize;
                    @CloudwatchLoggingOptions = @cloudwatchLoggingOptions;
                    @CompressionFormat = @compressionFormat;
                    @KmsKeyArn = @kmsKeyArn;
                    @Prefix = @prefix;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "bucket_arn", @out: false, min: 1, max: 1)]
                public string @BucketArn { get; }

                [nterraform.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
                public string @RoleArn { get; }

                [nterraform.TerraformProperty(name: "buffer_interval", @out: false, min: 0, max: 1)]
                public int? @BufferInterval { get; }

                [nterraform.TerraformProperty(name: "buffer_size", @out: false, min: 0, max: 1)]
                public int? @BufferSize { get; }

                [nterraform.TerraformProperty(name: "cloudwatch_logging_options", @out: false, min: 0, max: 1)]
                public cloudwatch_logging_options[] @CloudwatchLoggingOptions { get; }

                [nterraform.TerraformProperty(name: "compression_format", @out: false, min: 0, max: 1)]
                public string @CompressionFormat { get; }

                [nterraform.TerraformProperty(name: "kms_key_arn", @out: false, min: 0, max: 1)]
                public string @KmsKeyArn { get; }

                [nterraform.TerraformProperty(name: "prefix", @out: false, min: 0, max: 1)]
                public string @Prefix { get; }
            }

            public redshift_configuration(string @clusterJdbcurl,
                                          string @dataTableName,
                                          string @password,
                                          string @roleArn,
                                          string @username,
                                          cloudwatch_logging_options[] @cloudwatchLoggingOptions = null,
                                          string @copyOptions = null,
                                          string @dataTableColumns = null,
                                          processing_configuration[] @processingConfiguration = null,
                                          int? @retryDuration = null,
                                          s3_backup_configuration[] @s3BackupConfiguration = null,
                                          string @s3BackupMode = null)
            {
                @ClusterJdbcurl = @clusterJdbcurl;
                @DataTableName = @dataTableName;
                @Password = @password;
                @RoleArn = @roleArn;
                @Username = @username;
                @CloudwatchLoggingOptions = @cloudwatchLoggingOptions;
                @CopyOptions = @copyOptions;
                @DataTableColumns = @dataTableColumns;
                @ProcessingConfiguration = @processingConfiguration;
                @RetryDuration = @retryDuration;
                @S3BackupConfiguration = @s3BackupConfiguration;
                @S3BackupMode = @s3BackupMode;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "cluster_jdbcurl", @out: false, min: 1, max: 1)]
            public string @ClusterJdbcurl { get; }

            [nterraform.TerraformProperty(name: "data_table_name", @out: false, min: 1, max: 1)]
            public string @DataTableName { get; }

            [nterraform.TerraformProperty(name: "password", @out: false, min: 1, max: 1)]
            public string @Password { get; }

            [nterraform.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
            public string @RoleArn { get; }

            [nterraform.TerraformProperty(name: "username", @out: false, min: 1, max: 1)]
            public string @Username { get; }

            [nterraform.TerraformProperty(name: "cloudwatch_logging_options", @out: false, min: 0, max: 1)]
            public cloudwatch_logging_options[] @CloudwatchLoggingOptions { get; }

            [nterraform.TerraformProperty(name: "copy_options", @out: false, min: 0, max: 1)]
            public string @CopyOptions { get; }

            [nterraform.TerraformProperty(name: "data_table_columns", @out: false, min: 0, max: 1)]
            public string @DataTableColumns { get; }

            [nterraform.TerraformProperty(name: "processing_configuration", @out: false, min: 0, max: 1)]
            public processing_configuration[] @ProcessingConfiguration { get; }

            [nterraform.TerraformProperty(name: "retry_duration", @out: false, min: 0, max: 1)]
            public int? @RetryDuration { get; }

            [nterraform.TerraformProperty(name: "s3_backup_configuration", @out: false, min: 0, max: 1)]
            public s3_backup_configuration[] @S3BackupConfiguration { get; }

            [nterraform.TerraformProperty(name: "s3_backup_mode", @out: false, min: 0, max: 1)]
            public string @S3BackupMode { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "elasticsearch_configuration")]
        public sealed class elasticsearch_configuration : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "cloudwatch_logging_options")]
            public sealed class cloudwatch_logging_options : nterraform.structure
            {
                public cloudwatch_logging_options(bool? @enabled = null,
                                                  string @logGroupName = null,
                                                  string @logStreamName = null)
                {
                    @Enabled = @enabled;
                    @LogGroupName = @logGroupName;
                    @LogStreamName = @logStreamName;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
                public bool? @Enabled { get; }

                [nterraform.TerraformProperty(name: "log_group_name", @out: false, min: 0, max: 1)]
                public string @LogGroupName { get; }

                [nterraform.TerraformProperty(name: "log_stream_name", @out: false, min: 0, max: 1)]
                public string @LogStreamName { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "processing_configuration")]
            public sealed class processing_configuration : nterraform.structure
            {
                [nterraform.TerraformStructure(category: "resource", typeName: "processors")]
                public sealed class processors : nterraform.structure
                {
                    [nterraform.TerraformStructure(category: "resource", typeName: "parameters")]
                    public sealed class parameters : nterraform.structure
                    {
                        public parameters(string @parameterName,
                                          string @parameterValue)
                        {
                            @ParameterName = @parameterName;
                            @ParameterValue = @parameterValue;
                            base._validate_();
                        }

                        [nterraform.TerraformProperty(name: "parameter_name", @out: false, min: 1, max: 1)]
                        public string @ParameterName { get; }

                        [nterraform.TerraformProperty(name: "parameter_value", @out: false, min: 1, max: 1)]
                        public string @ParameterValue { get; }
                    }

                    public processors(string @type,
                                      parameters[] @parameters = null)
                    {
                        @Type = @type;
                        @Parameters = @parameters;
                        base._validate_();
                    }

                    [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
                    public string @Type { get; }

                    [nterraform.TerraformProperty(name: "parameters", @out: false, min: 0, max: 0)]
                    public parameters[] @Parameters { get; }
                }

                public processing_configuration(bool? @enabled = null,
                                                processors[] @processors = null)
                {
                    @Enabled = @enabled;
                    @Processors = @processors;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
                public bool? @Enabled { get; }

                [nterraform.TerraformProperty(name: "processors", @out: false, min: 0, max: 0)]
                public processors[] @Processors { get; }
            }

            public elasticsearch_configuration(string @domainArn,
                                               string @indexName,
                                               string @roleArn,
                                               int? @bufferingInterval = null,
                                               int? @bufferingSize = null,
                                               cloudwatch_logging_options[] @cloudwatchLoggingOptions = null,
                                               string @indexRotationPeriod = null,
                                               processing_configuration[] @processingConfiguration = null,
                                               int? @retryDuration = null,
                                               string @s3BackupMode = null,
                                               string @typeName = null)
            {
                @DomainArn = @domainArn;
                @IndexName = @indexName;
                @RoleArn = @roleArn;
                @BufferingInterval = @bufferingInterval;
                @BufferingSize = @bufferingSize;
                @CloudwatchLoggingOptions = @cloudwatchLoggingOptions;
                @IndexRotationPeriod = @indexRotationPeriod;
                @ProcessingConfiguration = @processingConfiguration;
                @RetryDuration = @retryDuration;
                @S3BackupMode = @s3BackupMode;
                @TypeName = @typeName;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "domain_arn", @out: false, min: 1, max: 1)]
            public string @DomainArn { get; }

            [nterraform.TerraformProperty(name: "index_name", @out: false, min: 1, max: 1)]
            public string @IndexName { get; }

            [nterraform.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
            public string @RoleArn { get; }

            [nterraform.TerraformProperty(name: "buffering_interval", @out: false, min: 0, max: 1)]
            public int? @BufferingInterval { get; }

            [nterraform.TerraformProperty(name: "buffering_size", @out: false, min: 0, max: 1)]
            public int? @BufferingSize { get; }

            [nterraform.TerraformProperty(name: "cloudwatch_logging_options", @out: false, min: 0, max: 1)]
            public cloudwatch_logging_options[] @CloudwatchLoggingOptions { get; }

            [nterraform.TerraformProperty(name: "index_rotation_period", @out: false, min: 0, max: 1)]
            public string @IndexRotationPeriod { get; }

            [nterraform.TerraformProperty(name: "processing_configuration", @out: false, min: 0, max: 1)]
            public processing_configuration[] @ProcessingConfiguration { get; }

            [nterraform.TerraformProperty(name: "retry_duration", @out: false, min: 0, max: 1)]
            public int? @RetryDuration { get; }

            [nterraform.TerraformProperty(name: "s3_backup_mode", @out: false, min: 0, max: 1)]
            public string @S3BackupMode { get; }

            [nterraform.TerraformProperty(name: "type_name", @out: false, min: 0, max: 1)]
            public string @TypeName { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "splunk_configuration")]
        public sealed class splunk_configuration : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "cloudwatch_logging_options")]
            public sealed class cloudwatch_logging_options : nterraform.structure
            {
                public cloudwatch_logging_options(bool? @enabled = null,
                                                  string @logGroupName = null,
                                                  string @logStreamName = null)
                {
                    @Enabled = @enabled;
                    @LogGroupName = @logGroupName;
                    @LogStreamName = @logStreamName;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
                public bool? @Enabled { get; }

                [nterraform.TerraformProperty(name: "log_group_name", @out: false, min: 0, max: 1)]
                public string @LogGroupName { get; }

                [nterraform.TerraformProperty(name: "log_stream_name", @out: false, min: 0, max: 1)]
                public string @LogStreamName { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "processing_configuration")]
            public sealed class processing_configuration : nterraform.structure
            {
                [nterraform.TerraformStructure(category: "resource", typeName: "processors")]
                public sealed class processors : nterraform.structure
                {
                    [nterraform.TerraformStructure(category: "resource", typeName: "parameters")]
                    public sealed class parameters : nterraform.structure
                    {
                        public parameters(string @parameterName,
                                          string @parameterValue)
                        {
                            @ParameterName = @parameterName;
                            @ParameterValue = @parameterValue;
                            base._validate_();
                        }

                        [nterraform.TerraformProperty(name: "parameter_name", @out: false, min: 1, max: 1)]
                        public string @ParameterName { get; }

                        [nterraform.TerraformProperty(name: "parameter_value", @out: false, min: 1, max: 1)]
                        public string @ParameterValue { get; }
                    }

                    public processors(string @type,
                                      parameters[] @parameters = null)
                    {
                        @Type = @type;
                        @Parameters = @parameters;
                        base._validate_();
                    }

                    [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
                    public string @Type { get; }

                    [nterraform.TerraformProperty(name: "parameters", @out: false, min: 0, max: 0)]
                    public parameters[] @Parameters { get; }
                }

                public processing_configuration(bool? @enabled = null,
                                                processors[] @processors = null)
                {
                    @Enabled = @enabled;
                    @Processors = @processors;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
                public bool? @Enabled { get; }

                [nterraform.TerraformProperty(name: "processors", @out: false, min: 0, max: 0)]
                public processors[] @Processors { get; }
            }

            public splunk_configuration(string @hecEndpoint,
                                        string @hecToken,
                                        cloudwatch_logging_options[] @cloudwatchLoggingOptions = null,
                                        int? @hecAcknowledgmentTimeout = null,
                                        string @hecEndpointType = null,
                                        processing_configuration[] @processingConfiguration = null,
                                        int? @retryDuration = null,
                                        string @s3BackupMode = null)
            {
                @HecEndpoint = @hecEndpoint;
                @HecToken = @hecToken;
                @CloudwatchLoggingOptions = @cloudwatchLoggingOptions;
                @HecAcknowledgmentTimeout = @hecAcknowledgmentTimeout;
                @HecEndpointType = @hecEndpointType;
                @ProcessingConfiguration = @processingConfiguration;
                @RetryDuration = @retryDuration;
                @S3BackupMode = @s3BackupMode;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "hec_endpoint", @out: false, min: 1, max: 1)]
            public string @HecEndpoint { get; }

            [nterraform.TerraformProperty(name: "hec_token", @out: false, min: 1, max: 1)]
            public string @HecToken { get; }

            [nterraform.TerraformProperty(name: "cloudwatch_logging_options", @out: false, min: 0, max: 1)]
            public cloudwatch_logging_options[] @CloudwatchLoggingOptions { get; }

            [nterraform.TerraformProperty(name: "hec_acknowledgment_timeout", @out: false, min: 0, max: 1)]
            public int? @HecAcknowledgmentTimeout { get; }

            [nterraform.TerraformProperty(name: "hec_endpoint_type", @out: false, min: 0, max: 1)]
            public string @HecEndpointType { get; }

            [nterraform.TerraformProperty(name: "processing_configuration", @out: false, min: 0, max: 1)]
            public processing_configuration[] @ProcessingConfiguration { get; }

            [nterraform.TerraformProperty(name: "retry_duration", @out: false, min: 0, max: 1)]
            public int? @RetryDuration { get; }

            [nterraform.TerraformProperty(name: "s3_backup_mode", @out: false, min: 0, max: 1)]
            public string @S3BackupMode { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "extended_s3_configuration")]
        public sealed class extended_s3_configuration : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "cloudwatch_logging_options")]
            public sealed class cloudwatch_logging_options : nterraform.structure
            {
                public cloudwatch_logging_options(bool? @enabled = null,
                                                  string @logGroupName = null,
                                                  string @logStreamName = null)
                {
                    @Enabled = @enabled;
                    @LogGroupName = @logGroupName;
                    @LogStreamName = @logStreamName;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
                public bool? @Enabled { get; }

                [nterraform.TerraformProperty(name: "log_group_name", @out: false, min: 0, max: 1)]
                public string @LogGroupName { get; }

                [nterraform.TerraformProperty(name: "log_stream_name", @out: false, min: 0, max: 1)]
                public string @LogStreamName { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "s3_backup_configuration")]
            public sealed class s3_backup_configuration : nterraform.structure
            {
                [nterraform.TerraformStructure(category: "resource", typeName: "cloudwatch_logging_options")]
                public sealed class cloudwatch_logging_options : nterraform.structure
                {
                    public cloudwatch_logging_options(bool? @enabled = null,
                                                      string @logGroupName = null,
                                                      string @logStreamName = null)
                    {
                        @Enabled = @enabled;
                        @LogGroupName = @logGroupName;
                        @LogStreamName = @logStreamName;
                        base._validate_();
                    }

                    [nterraform.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
                    public bool? @Enabled { get; }

                    [nterraform.TerraformProperty(name: "log_group_name", @out: false, min: 0, max: 1)]
                    public string @LogGroupName { get; }

                    [nterraform.TerraformProperty(name: "log_stream_name", @out: false, min: 0, max: 1)]
                    public string @LogStreamName { get; }
                }

                public s3_backup_configuration(string @bucketArn,
                                               string @roleArn,
                                               int? @bufferInterval = null,
                                               int? @bufferSize = null,
                                               cloudwatch_logging_options[] @cloudwatchLoggingOptions = null,
                                               string @compressionFormat = null,
                                               string @kmsKeyArn = null,
                                               string @prefix = null)
                {
                    @BucketArn = @bucketArn;
                    @RoleArn = @roleArn;
                    @BufferInterval = @bufferInterval;
                    @BufferSize = @bufferSize;
                    @CloudwatchLoggingOptions = @cloudwatchLoggingOptions;
                    @CompressionFormat = @compressionFormat;
                    @KmsKeyArn = @kmsKeyArn;
                    @Prefix = @prefix;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "bucket_arn", @out: false, min: 1, max: 1)]
                public string @BucketArn { get; }

                [nterraform.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
                public string @RoleArn { get; }

                [nterraform.TerraformProperty(name: "buffer_interval", @out: false, min: 0, max: 1)]
                public int? @BufferInterval { get; }

                [nterraform.TerraformProperty(name: "buffer_size", @out: false, min: 0, max: 1)]
                public int? @BufferSize { get; }

                [nterraform.TerraformProperty(name: "cloudwatch_logging_options", @out: false, min: 0, max: 1)]
                public cloudwatch_logging_options[] @CloudwatchLoggingOptions { get; }

                [nterraform.TerraformProperty(name: "compression_format", @out: false, min: 0, max: 1)]
                public string @CompressionFormat { get; }

                [nterraform.TerraformProperty(name: "kms_key_arn", @out: false, min: 0, max: 1)]
                public string @KmsKeyArn { get; }

                [nterraform.TerraformProperty(name: "prefix", @out: false, min: 0, max: 1)]
                public string @Prefix { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "data_format_conversion_configuration")]
            public sealed class data_format_conversion_configuration : nterraform.structure
            {
                [nterraform.TerraformStructure(category: "resource", typeName: "output_format_configuration")]
                public sealed class output_format_configuration : nterraform.structure
                {
                    [nterraform.TerraformStructure(category: "resource", typeName: "serializer")]
                    public sealed class serializer : nterraform.structure
                    {
                        [nterraform.TerraformStructure(category: "resource", typeName: "orc_ser_de")]
                        public sealed class orc_ser_de : nterraform.structure
                        {
                            public orc_ser_de(int? @blockSizeBytes = null,
                                              string[] @bloomFilterColumns = null,
                                              int? @bloomFilterFalsePositiveProbability = null,
                                              string @compression = null,
                                              int? @dictionaryKeyThreshold = null,
                                              bool? @enablePadding = null,
                                              string @formatVersion = null,
                                              int? @paddingTolerance = null,
                                              int? @rowIndexStride = null,
                                              int? @stripeSizeBytes = null)
                            {
                                @BlockSizeBytes = @blockSizeBytes;
                                @BloomFilterColumns = @bloomFilterColumns;
                                @BloomFilterFalsePositiveProbability = @bloomFilterFalsePositiveProbability;
                                @Compression = @compression;
                                @DictionaryKeyThreshold = @dictionaryKeyThreshold;
                                @EnablePadding = @enablePadding;
                                @FormatVersion = @formatVersion;
                                @PaddingTolerance = @paddingTolerance;
                                @RowIndexStride = @rowIndexStride;
                                @StripeSizeBytes = @stripeSizeBytes;
                                base._validate_();
                            }

                            [nterraform.TerraformProperty(name: "block_size_bytes", @out: false, min: 0, max: 1)]
                            public int? @BlockSizeBytes { get; }

                            [nterraform.TerraformProperty(name: "bloom_filter_columns", @out: false, min: 0, max: 1)]
                            public string[] @BloomFilterColumns { get; }

                            [nterraform.TerraformProperty(name: "bloom_filter_false_positive_probability", @out: false, min: 0, max: 1)]
                            public int? @BloomFilterFalsePositiveProbability { get; }

                            [nterraform.TerraformProperty(name: "compression", @out: false, min: 0, max: 1)]
                            public string @Compression { get; }

                            [nterraform.TerraformProperty(name: "dictionary_key_threshold", @out: false, min: 0, max: 1)]
                            public int? @DictionaryKeyThreshold { get; }

                            [nterraform.TerraformProperty(name: "enable_padding", @out: false, min: 0, max: 1)]
                            public bool? @EnablePadding { get; }

                            [nterraform.TerraformProperty(name: "format_version", @out: false, min: 0, max: 1)]
                            public string @FormatVersion { get; }

                            [nterraform.TerraformProperty(name: "padding_tolerance", @out: false, min: 0, max: 1)]
                            public int? @PaddingTolerance { get; }

                            [nterraform.TerraformProperty(name: "row_index_stride", @out: false, min: 0, max: 1)]
                            public int? @RowIndexStride { get; }

                            [nterraform.TerraformProperty(name: "stripe_size_bytes", @out: false, min: 0, max: 1)]
                            public int? @StripeSizeBytes { get; }
                        }

                        [nterraform.TerraformStructure(category: "resource", typeName: "parquet_ser_de")]
                        public sealed class parquet_ser_de : nterraform.structure
                        {
                            public parquet_ser_de(int? @blockSizeBytes = null,
                                                  string @compression = null,
                                                  bool? @enableDictionaryCompression = null,
                                                  int? @maxPaddingBytes = null,
                                                  int? @pageSizeBytes = null,
                                                  string @writerVersion = null)
                            {
                                @BlockSizeBytes = @blockSizeBytes;
                                @Compression = @compression;
                                @EnableDictionaryCompression = @enableDictionaryCompression;
                                @MaxPaddingBytes = @maxPaddingBytes;
                                @PageSizeBytes = @pageSizeBytes;
                                @WriterVersion = @writerVersion;
                                base._validate_();
                            }

                            [nterraform.TerraformProperty(name: "block_size_bytes", @out: false, min: 0, max: 1)]
                            public int? @BlockSizeBytes { get; }

                            [nterraform.TerraformProperty(name: "compression", @out: false, min: 0, max: 1)]
                            public string @Compression { get; }

                            [nterraform.TerraformProperty(name: "enable_dictionary_compression", @out: false, min: 0, max: 1)]
                            public bool? @EnableDictionaryCompression { get; }

                            [nterraform.TerraformProperty(name: "max_padding_bytes", @out: false, min: 0, max: 1)]
                            public int? @MaxPaddingBytes { get; }

                            [nterraform.TerraformProperty(name: "page_size_bytes", @out: false, min: 0, max: 1)]
                            public int? @PageSizeBytes { get; }

                            [nterraform.TerraformProperty(name: "writer_version", @out: false, min: 0, max: 1)]
                            public string @WriterVersion { get; }
                        }

                        public serializer(orc_ser_de[] @orcSerDe = null,
                                          parquet_ser_de[] @parquetSerDe = null)
                        {
                            @OrcSerDe = @orcSerDe;
                            @ParquetSerDe = @parquetSerDe;
                            base._validate_();
                        }

                        [nterraform.TerraformProperty(name: "orc_ser_de", @out: false, min: 0, max: 1)]
                        public orc_ser_de[] @OrcSerDe { get; }

                        [nterraform.TerraformProperty(name: "parquet_ser_de", @out: false, min: 0, max: 1)]
                        public parquet_ser_de[] @ParquetSerDe { get; }
                    }

                    public output_format_configuration(serializer[] @serializer)
                    {
                        @Serializer = @serializer;
                        base._validate_();
                    }

                    [nterraform.TerraformProperty(name: "serializer", @out: false, min: 1, max: 1)]
                    public serializer[] @Serializer { get; }
                }

                [nterraform.TerraformStructure(category: "resource", typeName: "schema_configuration")]
                public sealed class schema_configuration : nterraform.structure
                {
                    public schema_configuration(string @databaseName,
                                                string @roleArn,
                                                string @tableName,
                                                string @versionId = null)
                    {
                        @DatabaseName = @databaseName;
                        @RoleArn = @roleArn;
                        @TableName = @tableName;
                        @VersionId = @versionId;
                        base._validate_();
                    }

                    [nterraform.TerraformProperty(name: "database_name", @out: false, min: 1, max: 1)]
                    public string @DatabaseName { get; }

                    [nterraform.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
                    public string @RoleArn { get; }

                    [nterraform.TerraformProperty(name: "table_name", @out: false, min: 1, max: 1)]
                    public string @TableName { get; }

                    [nterraform.TerraformProperty(name: "catalog_id", @out: true, min: 0, max: 1)]
                    public string @CatalogId { get; }

                    [nterraform.TerraformProperty(name: "region", @out: true, min: 0, max: 1)]
                    public string @Region { get; }

                    [nterraform.TerraformProperty(name: "version_id", @out: false, min: 0, max: 1)]
                    public string @VersionId { get; }
                }

                [nterraform.TerraformStructure(category: "resource", typeName: "input_format_configuration")]
                public sealed class input_format_configuration : nterraform.structure
                {
                    [nterraform.TerraformStructure(category: "resource", typeName: "deserializer")]
                    public sealed class deserializer : nterraform.structure
                    {
                        [nterraform.TerraformStructure(category: "resource", typeName: "hive_json_ser_de")]
                        public sealed class hive_json_ser_de : nterraform.structure
                        {
                            public hive_json_ser_de(string[] @timestampFormats = null)
                            {
                                @TimestampFormats = @timestampFormats;
                                base._validate_();
                            }

                            [nterraform.TerraformProperty(name: "timestamp_formats", @out: false, min: 0, max: 1)]
                            public string[] @TimestampFormats { get; }
                        }

                        [nterraform.TerraformStructure(category: "resource", typeName: "open_x_json_ser_de")]
                        public sealed class open_x_json_ser_de : nterraform.structure
                        {
                            public open_x_json_ser_de(bool? @caseInsensitive = null,
                                                      Dictionary<string,string> @columnToJsonKeyMappings = null,
                                                      bool? @convertDotsInJsonKeysToUnderscores = null)
                            {
                                @CaseInsensitive = @caseInsensitive;
                                @ColumnToJsonKeyMappings = @columnToJsonKeyMappings;
                                @ConvertDotsInJsonKeysToUnderscores = @convertDotsInJsonKeysToUnderscores;
                                base._validate_();
                            }

                            [nterraform.TerraformProperty(name: "case_insensitive", @out: false, min: 0, max: 1)]
                            public bool? @CaseInsensitive { get; }

                            [nterraform.TerraformProperty(name: "column_to_json_key_mappings", @out: false, min: 0, max: 1)]
                            public Dictionary<string,string> @ColumnToJsonKeyMappings { get; }

                            [nterraform.TerraformProperty(name: "convert_dots_in_json_keys_to_underscores", @out: false, min: 0, max: 1)]
                            public bool? @ConvertDotsInJsonKeysToUnderscores { get; }
                        }

                        public deserializer(hive_json_ser_de[] @hiveJsonSerDe = null,
                                            open_x_json_ser_de[] @openXJsonSerDe = null)
                        {
                            @HiveJsonSerDe = @hiveJsonSerDe;
                            @OpenXJsonSerDe = @openXJsonSerDe;
                            base._validate_();
                        }

                        [nterraform.TerraformProperty(name: "hive_json_ser_de", @out: false, min: 0, max: 1)]
                        public hive_json_ser_de[] @HiveJsonSerDe { get; }

                        [nterraform.TerraformProperty(name: "open_x_json_ser_de", @out: false, min: 0, max: 1)]
                        public open_x_json_ser_de[] @OpenXJsonSerDe { get; }
                    }

                    public input_format_configuration(deserializer[] @deserializer)
                    {
                        @Deserializer = @deserializer;
                        base._validate_();
                    }

                    [nterraform.TerraformProperty(name: "deserializer", @out: false, min: 1, max: 1)]
                    public deserializer[] @Deserializer { get; }
                }

                public data_format_conversion_configuration(input_format_configuration[] @inputFormatConfiguration,
                                                            output_format_configuration[] @outputFormatConfiguration,
                                                            schema_configuration[] @schemaConfiguration,
                                                            bool? @enabled = null)
                {
                    @InputFormatConfiguration = @inputFormatConfiguration;
                    @OutputFormatConfiguration = @outputFormatConfiguration;
                    @SchemaConfiguration = @schemaConfiguration;
                    @Enabled = @enabled;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "input_format_configuration", @out: false, min: 1, max: 1)]
                public input_format_configuration[] @InputFormatConfiguration { get; }

                [nterraform.TerraformProperty(name: "output_format_configuration", @out: false, min: 1, max: 1)]
                public output_format_configuration[] @OutputFormatConfiguration { get; }

                [nterraform.TerraformProperty(name: "schema_configuration", @out: false, min: 1, max: 1)]
                public schema_configuration[] @SchemaConfiguration { get; }

                [nterraform.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
                public bool? @Enabled { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "processing_configuration")]
            public sealed class processing_configuration : nterraform.structure
            {
                [nterraform.TerraformStructure(category: "resource", typeName: "processors")]
                public sealed class processors : nterraform.structure
                {
                    [nterraform.TerraformStructure(category: "resource", typeName: "parameters")]
                    public sealed class parameters : nterraform.structure
                    {
                        public parameters(string @parameterName,
                                          string @parameterValue)
                        {
                            @ParameterName = @parameterName;
                            @ParameterValue = @parameterValue;
                            base._validate_();
                        }

                        [nterraform.TerraformProperty(name: "parameter_name", @out: false, min: 1, max: 1)]
                        public string @ParameterName { get; }

                        [nterraform.TerraformProperty(name: "parameter_value", @out: false, min: 1, max: 1)]
                        public string @ParameterValue { get; }
                    }

                    public processors(string @type,
                                      parameters[] @parameters = null)
                    {
                        @Type = @type;
                        @Parameters = @parameters;
                        base._validate_();
                    }

                    [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
                    public string @Type { get; }

                    [nterraform.TerraformProperty(name: "parameters", @out: false, min: 0, max: 0)]
                    public parameters[] @Parameters { get; }
                }

                public processing_configuration(bool? @enabled = null,
                                                processors[] @processors = null)
                {
                    @Enabled = @enabled;
                    @Processors = @processors;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
                public bool? @Enabled { get; }

                [nterraform.TerraformProperty(name: "processors", @out: false, min: 0, max: 0)]
                public processors[] @Processors { get; }
            }

            public extended_s3_configuration(string @bucketArn,
                                             string @roleArn,
                                             int? @bufferInterval = null,
                                             int? @bufferSize = null,
                                             cloudwatch_logging_options[] @cloudwatchLoggingOptions = null,
                                             string @compressionFormat = null,
                                             data_format_conversion_configuration[] @dataFormatConversionConfiguration = null,
                                             string @kmsKeyArn = null,
                                             string @prefix = null,
                                             processing_configuration[] @processingConfiguration = null,
                                             s3_backup_configuration[] @s3BackupConfiguration = null,
                                             string @s3BackupMode = null)
            {
                @BucketArn = @bucketArn;
                @RoleArn = @roleArn;
                @BufferInterval = @bufferInterval;
                @BufferSize = @bufferSize;
                @CloudwatchLoggingOptions = @cloudwatchLoggingOptions;
                @CompressionFormat = @compressionFormat;
                @DataFormatConversionConfiguration = @dataFormatConversionConfiguration;
                @KmsKeyArn = @kmsKeyArn;
                @Prefix = @prefix;
                @ProcessingConfiguration = @processingConfiguration;
                @S3BackupConfiguration = @s3BackupConfiguration;
                @S3BackupMode = @s3BackupMode;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "bucket_arn", @out: false, min: 1, max: 1)]
            public string @BucketArn { get; }

            [nterraform.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
            public string @RoleArn { get; }

            [nterraform.TerraformProperty(name: "buffer_interval", @out: false, min: 0, max: 1)]
            public int? @BufferInterval { get; }

            [nterraform.TerraformProperty(name: "buffer_size", @out: false, min: 0, max: 1)]
            public int? @BufferSize { get; }

            [nterraform.TerraformProperty(name: "cloudwatch_logging_options", @out: false, min: 0, max: 1)]
            public cloudwatch_logging_options[] @CloudwatchLoggingOptions { get; }

            [nterraform.TerraformProperty(name: "compression_format", @out: false, min: 0, max: 1)]
            public string @CompressionFormat { get; }

            [nterraform.TerraformProperty(name: "data_format_conversion_configuration", @out: false, min: 0, max: 1)]
            public data_format_conversion_configuration[] @DataFormatConversionConfiguration { get; }

            [nterraform.TerraformProperty(name: "kms_key_arn", @out: false, min: 0, max: 1)]
            public string @KmsKeyArn { get; }

            [nterraform.TerraformProperty(name: "prefix", @out: false, min: 0, max: 1)]
            public string @Prefix { get; }

            [nterraform.TerraformProperty(name: "processing_configuration", @out: false, min: 0, max: 1)]
            public processing_configuration[] @ProcessingConfiguration { get; }

            [nterraform.TerraformProperty(name: "s3_backup_configuration", @out: false, min: 0, max: 1)]
            public s3_backup_configuration[] @S3BackupConfiguration { get; }

            [nterraform.TerraformProperty(name: "s3_backup_mode", @out: false, min: 0, max: 1)]
            public string @S3BackupMode { get; }
        }

        public aws_kinesis_firehose_delivery_stream(string @destination,
                                                    string @name,
                                                    elasticsearch_configuration[] @elasticsearchConfiguration = null,
                                                    extended_s3_configuration[] @extendedS3Configuration = null,
                                                    kinesis_source_configuration[] @kinesisSourceConfiguration = null,
                                                    redshift_configuration[] @redshiftConfiguration = null,
                                                    s3_configuration[] @s3Configuration = null,
                                                    splunk_configuration[] @splunkConfiguration = null)
        {
            @Destination = @destination;
            @Name = @name;
            @ElasticsearchConfiguration = @elasticsearchConfiguration;
            @ExtendedS3Configuration = @extendedS3Configuration;
            @KinesisSourceConfiguration = @kinesisSourceConfiguration;
            @RedshiftConfiguration = @redshiftConfiguration;
            @S3Configuration = @s3Configuration;
            @SplunkConfiguration = @splunkConfiguration;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "destination", @out: false, min: 1, max: 1)]
        public string @Destination { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "destination_id", @out: true, min: 0, max: 1)]
        public string @DestinationId { get; }

        [nterraform.TerraformProperty(name: "elasticsearch_configuration", @out: false, min: 0, max: 1)]
        public elasticsearch_configuration[] @ElasticsearchConfiguration { get; }

        [nterraform.TerraformProperty(name: "extended_s3_configuration", @out: false, min: 0, max: 1)]
        public extended_s3_configuration[] @ExtendedS3Configuration { get; }

        [nterraform.TerraformProperty(name: "kinesis_source_configuration", @out: false, min: 0, max: 1)]
        public kinesis_source_configuration[] @KinesisSourceConfiguration { get; }

        [nterraform.TerraformProperty(name: "redshift_configuration", @out: false, min: 0, max: 1)]
        public redshift_configuration[] @RedshiftConfiguration { get; }

        [nterraform.TerraformProperty(name: "s3_configuration", @out: false, min: 0, max: 1)]
        public s3_configuration[] @S3Configuration { get; }

        [nterraform.TerraformProperty(name: "splunk_configuration", @out: false, min: 0, max: 1)]
        public splunk_configuration[] @SplunkConfiguration { get; }

        [nterraform.TerraformProperty(name: "version_id", @out: true, min: 0, max: 1)]
        public string @VersionId { get; }
    }

}
