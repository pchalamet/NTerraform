using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_dms_endpoint")]
    public sealed class aws_dms_endpoint : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "mongodb_settings")]
        public sealed class mongodb_settings : nterraform.structure
        {
            public mongodb_settings(string @authMechanism = null,
                                    string @authSource = null,
                                    string @authType = null,
                                    string @docsToInvestigate = null,
                                    string @extractDocId = null,
                                    string @nestingLevel = null)
            {
                @AuthMechanism = @authMechanism;
                @AuthSource = @authSource;
                @AuthType = @authType;
                @DocsToInvestigate = @docsToInvestigate;
                @ExtractDocId = @extractDocId;
                @NestingLevel = @nestingLevel;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "auth_mechanism", @out: false, min: 0, max: 1)]
            public string @AuthMechanism { get; }

            [nterraform.TerraformProperty(name: "auth_source", @out: false, min: 0, max: 1)]
            public string @AuthSource { get; }

            [nterraform.TerraformProperty(name: "auth_type", @out: false, min: 0, max: 1)]
            public string @AuthType { get; }

            [nterraform.TerraformProperty(name: "docs_to_investigate", @out: false, min: 0, max: 1)]
            public string @DocsToInvestigate { get; }

            [nterraform.TerraformProperty(name: "extract_doc_id", @out: false, min: 0, max: 1)]
            public string @ExtractDocId { get; }

            [nterraform.TerraformProperty(name: "nesting_level", @out: false, min: 0, max: 1)]
            public string @NestingLevel { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "s3_settings")]
        public sealed class s3_settings : nterraform.structure
        {
            public s3_settings(string @bucketFolder = null,
                               string @bucketName = null,
                               string @compressionType = null,
                               string @csvDelimiter = null,
                               string @csvRowDelimiter = null,
                               string @externalTableDefinition = null,
                               string @serviceAccessRoleArn = null)
            {
                @BucketFolder = @bucketFolder;
                @BucketName = @bucketName;
                @CompressionType = @compressionType;
                @CsvDelimiter = @csvDelimiter;
                @CsvRowDelimiter = @csvRowDelimiter;
                @ExternalTableDefinition = @externalTableDefinition;
                @ServiceAccessRoleArn = @serviceAccessRoleArn;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "bucket_folder", @out: false, min: 0, max: 1)]
            public string @BucketFolder { get; }

            [nterraform.TerraformProperty(name: "bucket_name", @out: false, min: 0, max: 1)]
            public string @BucketName { get; }

            [nterraform.TerraformProperty(name: "compression_type", @out: false, min: 0, max: 1)]
            public string @CompressionType { get; }

            [nterraform.TerraformProperty(name: "csv_delimiter", @out: false, min: 0, max: 1)]
            public string @CsvDelimiter { get; }

            [nterraform.TerraformProperty(name: "csv_row_delimiter", @out: false, min: 0, max: 1)]
            public string @CsvRowDelimiter { get; }

            [nterraform.TerraformProperty(name: "external_table_definition", @out: false, min: 0, max: 1)]
            public string @ExternalTableDefinition { get; }

            [nterraform.TerraformProperty(name: "service_access_role_arn", @out: false, min: 0, max: 1)]
            public string @ServiceAccessRoleArn { get; }
        }

        public aws_dms_endpoint(string @endpointId,
                                string @endpointType,
                                string @engineName,
                                string @databaseName = null,
                                mongodb_settings[] @mongodbSettings = null,
                                string @password = null,
                                int? @port = null,
                                s3_settings[] @s3Settings = null,
                                string @serverName = null,
                                string @serviceAccessRole = null,
                                Dictionary<string,string> @tags = null,
                                string @username = null)
        {
            @EndpointId = @endpointId;
            @EndpointType = @endpointType;
            @EngineName = @engineName;
            @DatabaseName = @databaseName;
            @MongodbSettings = @mongodbSettings;
            @Password = @password;
            @Port = @port;
            @S3Settings = @s3Settings;
            @ServerName = @serverName;
            @ServiceAccessRole = @serviceAccessRole;
            @Tags = @tags;
            @Username = @username;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "endpoint_id", @out: false, min: 1, max: 1)]
        public string @EndpointId { get; }

        [nterraform.TerraformProperty(name: "endpoint_type", @out: false, min: 1, max: 1)]
        public string @EndpointType { get; }

        [nterraform.TerraformProperty(name: "engine_name", @out: false, min: 1, max: 1)]
        public string @EngineName { get; }

        [nterraform.TerraformProperty(name: "certificate_arn", @out: true, min: 0, max: 1)]
        public string @CertificateArn { get; }

        [nterraform.TerraformProperty(name: "database_name", @out: false, min: 0, max: 1)]
        public string @DatabaseName { get; }

        [nterraform.TerraformProperty(name: "endpoint_arn", @out: true, min: 0, max: 1)]
        public string @EndpointArn { get; }

        [nterraform.TerraformProperty(name: "extra_connection_attributes", @out: true, min: 0, max: 1)]
        public string @ExtraConnectionAttributes { get; }

        [nterraform.TerraformProperty(name: "kms_key_arn", @out: true, min: 0, max: 1)]
        public string @KmsKeyArn { get; }

        [nterraform.TerraformProperty(name: "mongodb_settings", @out: false, min: 0, max: 1)]
        public mongodb_settings[] @MongodbSettings { get; }

        [nterraform.TerraformProperty(name: "password", @out: false, min: 0, max: 1)]
        public string @Password { get; }

        [nterraform.TerraformProperty(name: "port", @out: false, min: 0, max: 1)]
        public int? @Port { get; }

        [nterraform.TerraformProperty(name: "s3_settings", @out: false, min: 0, max: 1)]
        public s3_settings[] @S3Settings { get; }

        [nterraform.TerraformProperty(name: "server_name", @out: false, min: 0, max: 1)]
        public string @ServerName { get; }

        [nterraform.TerraformProperty(name: "service_access_role", @out: false, min: 0, max: 1)]
        public string @ServiceAccessRole { get; }

        [nterraform.TerraformProperty(name: "ssl_mode", @out: true, min: 0, max: 1)]
        public string @SslMode { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "username", @out: false, min: 0, max: 1)]
        public string @Username { get; }
    }

}
