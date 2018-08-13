using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_s3_bucket")]
    public sealed class aws_s3_bucket : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "website")]
        public sealed class website : nterraform.Core.structure
        {
            public website(string @errorDocument = null,
                           string @indexDocument = null,
                           string @redirectAllRequestsTo = null,
                           string @routingRules = null)
            {
                @ErrorDocument = @errorDocument;
                @IndexDocument = @indexDocument;
                @RedirectAllRequestsTo = @redirectAllRequestsTo;
                @RoutingRules = @routingRules;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "error_document", @out: false, min: 0, max: 1)]
            public string @ErrorDocument { get; }

            [nterraform.Core.TerraformProperty(name: "index_document", @out: false, min: 0, max: 1)]
            public string @IndexDocument { get; }

            [nterraform.Core.TerraformProperty(name: "redirect_all_requests_to", @out: false, min: 0, max: 1)]
            public string @RedirectAllRequestsTo { get; }

            [nterraform.Core.TerraformProperty(name: "routing_rules", @out: false, min: 0, max: 1)]
            public string @RoutingRules { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "logging")]
        public sealed class logging : nterraform.Core.structure
        {
            public logging(string @targetBucket,
                           string @targetPrefix = null)
            {
                @TargetBucket = @targetBucket;
                @TargetPrefix = @targetPrefix;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "target_bucket", @out: false, min: 1, max: 1)]
            public string @TargetBucket { get; }

            [nterraform.Core.TerraformProperty(name: "target_prefix", @out: false, min: 0, max: 1)]
            public string @TargetPrefix { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "lifecycle_rule")]
        public sealed class lifecycle_rule : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "transition")]
            public sealed class transition : nterraform.Core.structure
            {
                public transition(string @storageClass,
                                  string @date = null,
                                  int? @days = null)
                {
                    @StorageClass = @storageClass;
                    @Date = @date;
                    @Days = @days;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "storage_class", @out: false, min: 1, max: 1)]
                public string @StorageClass { get; }

                [nterraform.Core.TerraformProperty(name: "date", @out: false, min: 0, max: 1)]
                public string @Date { get; }

                [nterraform.Core.TerraformProperty(name: "days", @out: false, min: 0, max: 1)]
                public int? @Days { get; }
            }

            [nterraform.Core.TerraformStructure(category: "resource", typeName: "noncurrent_version_transition")]
            public sealed class noncurrent_version_transition : nterraform.Core.structure
            {
                public noncurrent_version_transition(string @storageClass,
                                                     int? @days = null)
                {
                    @StorageClass = @storageClass;
                    @Days = @days;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "storage_class", @out: false, min: 1, max: 1)]
                public string @StorageClass { get; }

                [nterraform.Core.TerraformProperty(name: "days", @out: false, min: 0, max: 1)]
                public int? @Days { get; }
            }

            [nterraform.Core.TerraformStructure(category: "resource", typeName: "expiration")]
            public sealed class expiration : nterraform.Core.structure
            {
                public expiration(string @date = null,
                                  int? @days = null,
                                  bool? @expiredObjectDeleteMarker = null)
                {
                    @Date = @date;
                    @Days = @days;
                    @ExpiredObjectDeleteMarker = @expiredObjectDeleteMarker;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "date", @out: false, min: 0, max: 1)]
                public string @Date { get; }

                [nterraform.Core.TerraformProperty(name: "days", @out: false, min: 0, max: 1)]
                public int? @Days { get; }

                [nterraform.Core.TerraformProperty(name: "expired_object_delete_marker", @out: false, min: 0, max: 1)]
                public bool? @ExpiredObjectDeleteMarker { get; }
            }

            [nterraform.Core.TerraformStructure(category: "resource", typeName: "noncurrent_version_expiration")]
            public sealed class noncurrent_version_expiration : nterraform.Core.structure
            {
                public noncurrent_version_expiration(int? @days = null)
                {
                    @Days = @days;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "days", @out: false, min: 0, max: 1)]
                public int? @Days { get; }
            }

            public lifecycle_rule(bool @enabled,
                                  int? @abortIncompleteMultipartUploadDays = null,
                                  expiration[] @expiration = null,
                                  noncurrent_version_expiration[] @noncurrentVersionExpiration = null,
                                  noncurrent_version_transition[] @noncurrentVersionTransition = null,
                                  string @prefix = null,
                                  Dictionary<string,string> @tags = null,
                                  transition[] @transition = null)
            {
                @Enabled = @enabled;
                @AbortIncompleteMultipartUploadDays = @abortIncompleteMultipartUploadDays;
                @Expiration = @expiration;
                @NoncurrentVersionExpiration = @noncurrentVersionExpiration;
                @NoncurrentVersionTransition = @noncurrentVersionTransition;
                @Prefix = @prefix;
                @Tags = @tags;
                @Transition = @transition;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "enabled", @out: false, min: 1, max: 1)]
            public bool @Enabled { get; }

            [nterraform.Core.TerraformProperty(name: "abort_incomplete_multipart_upload_days", @out: false, min: 0, max: 1)]
            public int? @AbortIncompleteMultipartUploadDays { get; }

            [nterraform.Core.TerraformProperty(name: "expiration", @out: false, min: 0, max: 0)]
            public expiration[] @Expiration { get; }

            [nterraform.Core.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }

            [nterraform.Core.TerraformProperty(name: "noncurrent_version_expiration", @out: false, min: 0, max: 0)]
            public noncurrent_version_expiration[] @NoncurrentVersionExpiration { get; }

            [nterraform.Core.TerraformProperty(name: "noncurrent_version_transition", @out: false, min: 0, max: 0)]
            public noncurrent_version_transition[] @NoncurrentVersionTransition { get; }

            [nterraform.Core.TerraformProperty(name: "prefix", @out: false, min: 0, max: 1)]
            public string @Prefix { get; }

            [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
            public Dictionary<string,string> @Tags { get; }

            [nterraform.Core.TerraformProperty(name: "transition", @out: false, min: 0, max: 0)]
            public transition[] @Transition { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "replication_configuration")]
        public sealed class replication_configuration : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "rules")]
            public sealed class rules : nterraform.Core.structure
            {
                [nterraform.Core.TerraformStructure(category: "resource", typeName: "destination")]
                public sealed class destination : nterraform.Core.structure
                {
                    public destination(string @bucket,
                                       string @replicaKmsKeyId = null,
                                       string @storageClass = null)
                    {
                        @Bucket = @bucket;
                        @ReplicaKmsKeyId = @replicaKmsKeyId;
                        @StorageClass = @storageClass;
                        base._validate_();
                    }

                    [nterraform.Core.TerraformProperty(name: "bucket", @out: false, min: 1, max: 1)]
                    public string @Bucket { get; }

                    [nterraform.Core.TerraformProperty(name: "replica_kms_key_id", @out: false, min: 0, max: 1)]
                    public string @ReplicaKmsKeyId { get; }

                    [nterraform.Core.TerraformProperty(name: "storage_class", @out: false, min: 0, max: 1)]
                    public string @StorageClass { get; }
                }

                [nterraform.Core.TerraformStructure(category: "resource", typeName: "source_selection_criteria")]
                public sealed class source_selection_criteria : nterraform.Core.structure
                {
                    [nterraform.Core.TerraformStructure(category: "resource", typeName: "sse_kms_encrypted_objects")]
                    public sealed class sse_kms_encrypted_objects : nterraform.Core.structure
                    {
                        public sse_kms_encrypted_objects(bool @enabled)
                        {
                            @Enabled = @enabled;
                            base._validate_();
                        }

                        [nterraform.Core.TerraformProperty(name: "enabled", @out: false, min: 1, max: 1)]
                        public bool @Enabled { get; }
                    }

                    public source_selection_criteria(sse_kms_encrypted_objects[] @sseKmsEncryptedObjects)
                    {
                        @SseKmsEncryptedObjects = @sseKmsEncryptedObjects;
                        base._validate_();
                    }

                    [nterraform.Core.TerraformProperty(name: "sse_kms_encrypted_objects", @out: false, min: 1, max: 1)]
                    public sse_kms_encrypted_objects[] @SseKmsEncryptedObjects { get; }
                }

                public rules(destination[] @destination,
                             string @prefix,
                             source_selection_criteria[] @sourceSelectionCriteria,
                             string @status,
                             string @id = null)
                {
                    @Destination = @destination;
                    @Prefix = @prefix;
                    @SourceSelectionCriteria = @sourceSelectionCriteria;
                    @Status = @status;
                    @Id = @id;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "destination", @out: false, min: 1, max: 1)]
                public destination[] @Destination { get; }

                [nterraform.Core.TerraformProperty(name: "prefix", @out: false, min: 1, max: 1)]
                public string @Prefix { get; }

                [nterraform.Core.TerraformProperty(name: "source_selection_criteria", @out: false, min: 1, max: 1)]
                public source_selection_criteria[] @SourceSelectionCriteria { get; }

                [nterraform.Core.TerraformProperty(name: "status", @out: false, min: 1, max: 1)]
                public string @Status { get; }

                [nterraform.Core.TerraformProperty(name: "id", @out: false, min: 0, max: 1)]
                public string @Id { get; }
            }

            public replication_configuration(string @role,
                                             rules[] @rules)
            {
                @Role = @role;
                @Rules = @rules;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "role", @out: false, min: 1, max: 1)]
            public string @Role { get; }

            [nterraform.Core.TerraformProperty(name: "rules", @out: false, min: 1, max: 0)]
            public rules[] @Rules { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "server_side_encryption_configuration")]
        public sealed class server_side_encryption_configuration : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "rule")]
            public sealed class rule : nterraform.Core.structure
            {
                [nterraform.Core.TerraformStructure(category: "resource", typeName: "apply_server_side_encryption_by_default")]
                public sealed class apply_server_side_encryption_by_default : nterraform.Core.structure
                {
                    public apply_server_side_encryption_by_default(string @sseAlgorithm,
                                                                   string @kmsMasterKeyId = null)
                    {
                        @SseAlgorithm = @sseAlgorithm;
                        @KmsMasterKeyId = @kmsMasterKeyId;
                        base._validate_();
                    }

                    [nterraform.Core.TerraformProperty(name: "sse_algorithm", @out: false, min: 1, max: 1)]
                    public string @SseAlgorithm { get; }

                    [nterraform.Core.TerraformProperty(name: "kms_master_key_id", @out: false, min: 0, max: 1)]
                    public string @KmsMasterKeyId { get; }
                }

                public rule(apply_server_side_encryption_by_default[] @applyServerSideEncryptionByDefault)
                {
                    @ApplyServerSideEncryptionByDefault = @applyServerSideEncryptionByDefault;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "apply_server_side_encryption_by_default", @out: false, min: 1, max: 1)]
                public apply_server_side_encryption_by_default[] @ApplyServerSideEncryptionByDefault { get; }
            }

            public server_side_encryption_configuration(rule[] @rule)
            {
                @Rule = @rule;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "rule", @out: false, min: 1, max: 1)]
            public rule[] @Rule { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "cors_rule")]
        public sealed class cors_rule : nterraform.Core.structure
        {
            public cors_rule(string[] @allowedMethods,
                             string[] @allowedOrigins,
                             string[] @allowedHeaders = null,
                             string[] @exposeHeaders = null,
                             int? @maxAgeSeconds = null)
            {
                @AllowedMethods = @allowedMethods;
                @AllowedOrigins = @allowedOrigins;
                @AllowedHeaders = @allowedHeaders;
                @ExposeHeaders = @exposeHeaders;
                @MaxAgeSeconds = @maxAgeSeconds;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "allowed_methods", @out: false, min: 1, max: 1)]
            public string[] @AllowedMethods { get; }

            [nterraform.Core.TerraformProperty(name: "allowed_origins", @out: false, min: 1, max: 1)]
            public string[] @AllowedOrigins { get; }

            [nterraform.Core.TerraformProperty(name: "allowed_headers", @out: false, min: 0, max: 1)]
            public string[] @AllowedHeaders { get; }

            [nterraform.Core.TerraformProperty(name: "expose_headers", @out: false, min: 0, max: 1)]
            public string[] @ExposeHeaders { get; }

            [nterraform.Core.TerraformProperty(name: "max_age_seconds", @out: false, min: 0, max: 1)]
            public int? @MaxAgeSeconds { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "versioning")]
        public sealed class versioning : nterraform.Core.structure
        {
            public versioning(bool? @enabled = null,
                              bool? @mfaDelete = null)
            {
                @Enabled = @enabled;
                @MfaDelete = @mfaDelete;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
            public bool? @Enabled { get; }

            [nterraform.Core.TerraformProperty(name: "mfa_delete", @out: false, min: 0, max: 1)]
            public bool? @MfaDelete { get; }
        }

        public aws_s3_bucket(string @acl = null,
                             string @bucketPrefix = null,
                             cors_rule[] @corsRule = null,
                             bool? @forceDestroy = null,
                             lifecycle_rule[] @lifecycleRule = null,
                             logging[] @logging = null,
                             string @policy = null,
                             replication_configuration[] @replicationConfiguration = null,
                             server_side_encryption_configuration[] @serverSideEncryptionConfiguration = null,
                             Dictionary<string,string> @tags = null,
                             versioning[] @versioning = null,
                             website[] @website = null)
        {
            @Acl = @acl;
            @BucketPrefix = @bucketPrefix;
            @CorsRule = @corsRule;
            @ForceDestroy = @forceDestroy;
            @LifecycleRule = @lifecycleRule;
            @Logging = @logging;
            @Policy = @policy;
            @ReplicationConfiguration = @replicationConfiguration;
            @ServerSideEncryptionConfiguration = @serverSideEncryptionConfiguration;
            @Tags = @tags;
            @Versioning = @versioning;
            @Website = @website;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "acceleration_status", @out: true, min: 0, max: 1)]
        public string @AccelerationStatus { get; }

        [nterraform.Core.TerraformProperty(name: "acl", @out: false, min: 0, max: 1)]
        public string @Acl { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "bucket", @out: true, min: 0, max: 1)]
        public string @Bucket { get; }

        [nterraform.Core.TerraformProperty(name: "bucket_domain_name", @out: true, min: 0, max: 1)]
        public string @BucketDomainName { get; }

        [nterraform.Core.TerraformProperty(name: "bucket_prefix", @out: false, min: 0, max: 1)]
        public string @BucketPrefix { get; }

        [nterraform.Core.TerraformProperty(name: "bucket_regional_domain_name", @out: true, min: 0, max: 1)]
        public string @BucketRegionalDomainName { get; }

        [nterraform.Core.TerraformProperty(name: "cors_rule", @out: false, min: 0, max: 0)]
        public cors_rule[] @CorsRule { get; }

        [nterraform.Core.TerraformProperty(name: "force_destroy", @out: false, min: 0, max: 1)]
        public bool? @ForceDestroy { get; }

        [nterraform.Core.TerraformProperty(name: "hosted_zone_id", @out: true, min: 0, max: 1)]
        public string @HostedZoneId { get; }

        [nterraform.Core.TerraformProperty(name: "lifecycle_rule", @out: false, min: 0, max: 0)]
        public lifecycle_rule[] @LifecycleRule { get; }

        [nterraform.Core.TerraformProperty(name: "logging", @out: false, min: 0, max: 0)]
        public logging[] @Logging { get; }

        [nterraform.Core.TerraformProperty(name: "policy", @out: false, min: 0, max: 1)]
        public string @Policy { get; }

        [nterraform.Core.TerraformProperty(name: "region", @out: true, min: 0, max: 1)]
        public string @Region { get; }

        [nterraform.Core.TerraformProperty(name: "replication_configuration", @out: false, min: 0, max: 1)]
        public replication_configuration[] @ReplicationConfiguration { get; }

        [nterraform.Core.TerraformProperty(name: "request_payer", @out: true, min: 0, max: 1)]
        public string @RequestPayer { get; }

        [nterraform.Core.TerraformProperty(name: "server_side_encryption_configuration", @out: false, min: 0, max: 1)]
        public server_side_encryption_configuration[] @ServerSideEncryptionConfiguration { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "versioning", @out: false, min: 0, max: 1)]
        public versioning[] @Versioning { get; }

        [nterraform.Core.TerraformProperty(name: "website", @out: false, min: 0, max: 0)]
        public website[] @Website { get; }

        [nterraform.Core.TerraformProperty(name: "website_domain", @out: true, min: 0, max: 1)]
        public string @WebsiteDomain { get; }

        [nterraform.Core.TerraformProperty(name: "website_endpoint", @out: true, min: 0, max: 1)]
        public string @WebsiteEndpoint { get; }
    }

}
