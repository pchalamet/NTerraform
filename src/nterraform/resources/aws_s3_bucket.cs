using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_s3_bucket")]
    public sealed class aws_s3_bucket : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "cors_rule")]
        public sealed class cors_rule : nterraform.structure
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

            [nterraform.TerraformProperty(name: "allowed_methods", @out: false, min: 1, max: 1)]
            public string[] @AllowedMethods { get; }

            [nterraform.TerraformProperty(name: "allowed_origins", @out: false, min: 1, max: 1)]
            public string[] @AllowedOrigins { get; }

            [nterraform.TerraformProperty(name: "allowed_headers", @out: false, min: 0, max: 1)]
            public string[] @AllowedHeaders { get; }

            [nterraform.TerraformProperty(name: "expose_headers", @out: false, min: 0, max: 1)]
            public string[] @ExposeHeaders { get; }

            [nterraform.TerraformProperty(name: "max_age_seconds", @out: false, min: 0, max: 1)]
            public int? @MaxAgeSeconds { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "server_side_encryption_configuration")]
        public sealed class server_side_encryption_configuration : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "rule")]
            public sealed class rule : nterraform.structure
            {
                [nterraform.TerraformStructure(category: "resource", typeName: "apply_server_side_encryption_by_default")]
                public sealed class apply_server_side_encryption_by_default : nterraform.structure
                {
                    public apply_server_side_encryption_by_default(string @sseAlgorithm,
                                                                   string @kmsMasterKeyId = null)
                    {
                        @SseAlgorithm = @sseAlgorithm;
                        @KmsMasterKeyId = @kmsMasterKeyId;
                        base._validate_();
                    }

                    [nterraform.TerraformProperty(name: "sse_algorithm", @out: false, min: 1, max: 1)]
                    public string @SseAlgorithm { get; }

                    [nterraform.TerraformProperty(name: "kms_master_key_id", @out: false, min: 0, max: 1)]
                    public string @KmsMasterKeyId { get; }
                }

                public rule(apply_server_side_encryption_by_default[] @applyServerSideEncryptionByDefault)
                {
                    @ApplyServerSideEncryptionByDefault = @applyServerSideEncryptionByDefault;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "apply_server_side_encryption_by_default", @out: false, min: 1, max: 1)]
                public apply_server_side_encryption_by_default[] @ApplyServerSideEncryptionByDefault { get; }
            }

            public server_side_encryption_configuration(rule[] @rule)
            {
                @Rule = @rule;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "rule", @out: false, min: 1, max: 1)]
            public rule[] @Rule { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "replication_configuration")]
        public sealed class replication_configuration : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "rules")]
            public sealed class rules : nterraform.structure
            {
                [nterraform.TerraformStructure(category: "resource", typeName: "destination")]
                public sealed class destination : nterraform.structure
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

                    [nterraform.TerraformProperty(name: "bucket", @out: false, min: 1, max: 1)]
                    public string @Bucket { get; }

                    [nterraform.TerraformProperty(name: "replica_kms_key_id", @out: false, min: 0, max: 1)]
                    public string @ReplicaKmsKeyId { get; }

                    [nterraform.TerraformProperty(name: "storage_class", @out: false, min: 0, max: 1)]
                    public string @StorageClass { get; }
                }

                [nterraform.TerraformStructure(category: "resource", typeName: "source_selection_criteria")]
                public sealed class source_selection_criteria : nterraform.structure
                {
                    [nterraform.TerraformStructure(category: "resource", typeName: "sse_kms_encrypted_objects")]
                    public sealed class sse_kms_encrypted_objects : nterraform.structure
                    {
                        public sse_kms_encrypted_objects(bool @enabled)
                        {
                            @Enabled = @enabled;
                            base._validate_();
                        }

                        [nterraform.TerraformProperty(name: "enabled", @out: false, min: 1, max: 1)]
                        public bool @Enabled { get; }
                    }

                    public source_selection_criteria(sse_kms_encrypted_objects[] @sseKmsEncryptedObjects)
                    {
                        @SseKmsEncryptedObjects = @sseKmsEncryptedObjects;
                        base._validate_();
                    }

                    [nterraform.TerraformProperty(name: "sse_kms_encrypted_objects", @out: false, min: 1, max: 1)]
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

                [nterraform.TerraformProperty(name: "destination", @out: false, min: 1, max: 1)]
                public destination[] @Destination { get; }

                [nterraform.TerraformProperty(name: "prefix", @out: false, min: 1, max: 1)]
                public string @Prefix { get; }

                [nterraform.TerraformProperty(name: "source_selection_criteria", @out: false, min: 1, max: 1)]
                public source_selection_criteria[] @SourceSelectionCriteria { get; }

                [nterraform.TerraformProperty(name: "status", @out: false, min: 1, max: 1)]
                public string @Status { get; }

                [nterraform.TerraformProperty(name: "id", @out: false, min: 0, max: 1)]
                public string @Id { get; }
            }

            public replication_configuration(string @role,
                                             rules[] @rules)
            {
                @Role = @role;
                @Rules = @rules;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "role", @out: false, min: 1, max: 1)]
            public string @Role { get; }

            [nterraform.TerraformProperty(name: "rules", @out: false, min: 1, max: 0)]
            public rules[] @Rules { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "lifecycle_rule")]
        public sealed class lifecycle_rule : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "noncurrent_version_expiration")]
            public sealed class noncurrent_version_expiration : nterraform.structure
            {
                public noncurrent_version_expiration(int? @days = null)
                {
                    @Days = @days;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "days", @out: false, min: 0, max: 1)]
                public int? @Days { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "transition")]
            public sealed class transition : nterraform.structure
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

                [nterraform.TerraformProperty(name: "storage_class", @out: false, min: 1, max: 1)]
                public string @StorageClass { get; }

                [nterraform.TerraformProperty(name: "date", @out: false, min: 0, max: 1)]
                public string @Date { get; }

                [nterraform.TerraformProperty(name: "days", @out: false, min: 0, max: 1)]
                public int? @Days { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "noncurrent_version_transition")]
            public sealed class noncurrent_version_transition : nterraform.structure
            {
                public noncurrent_version_transition(string @storageClass,
                                                     int? @days = null)
                {
                    @StorageClass = @storageClass;
                    @Days = @days;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "storage_class", @out: false, min: 1, max: 1)]
                public string @StorageClass { get; }

                [nterraform.TerraformProperty(name: "days", @out: false, min: 0, max: 1)]
                public int? @Days { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "expiration")]
            public sealed class expiration : nterraform.structure
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

                [nterraform.TerraformProperty(name: "date", @out: false, min: 0, max: 1)]
                public string @Date { get; }

                [nterraform.TerraformProperty(name: "days", @out: false, min: 0, max: 1)]
                public int? @Days { get; }

                [nterraform.TerraformProperty(name: "expired_object_delete_marker", @out: false, min: 0, max: 1)]
                public bool? @ExpiredObjectDeleteMarker { get; }
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

            [nterraform.TerraformProperty(name: "enabled", @out: false, min: 1, max: 1)]
            public bool @Enabled { get; }

            [nterraform.TerraformProperty(name: "abort_incomplete_multipart_upload_days", @out: false, min: 0, max: 1)]
            public int? @AbortIncompleteMultipartUploadDays { get; }

            [nterraform.TerraformProperty(name: "expiration", @out: false, min: 0, max: 0)]
            public expiration[] @Expiration { get; }

            [nterraform.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }

            [nterraform.TerraformProperty(name: "noncurrent_version_expiration", @out: false, min: 0, max: 0)]
            public noncurrent_version_expiration[] @NoncurrentVersionExpiration { get; }

            [nterraform.TerraformProperty(name: "noncurrent_version_transition", @out: false, min: 0, max: 0)]
            public noncurrent_version_transition[] @NoncurrentVersionTransition { get; }

            [nterraform.TerraformProperty(name: "prefix", @out: false, min: 0, max: 1)]
            public string @Prefix { get; }

            [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
            public Dictionary<string,string> @Tags { get; }

            [nterraform.TerraformProperty(name: "transition", @out: false, min: 0, max: 0)]
            public transition[] @Transition { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "website")]
        public sealed class website : nterraform.structure
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

            [nterraform.TerraformProperty(name: "error_document", @out: false, min: 0, max: 1)]
            public string @ErrorDocument { get; }

            [nterraform.TerraformProperty(name: "index_document", @out: false, min: 0, max: 1)]
            public string @IndexDocument { get; }

            [nterraform.TerraformProperty(name: "redirect_all_requests_to", @out: false, min: 0, max: 1)]
            public string @RedirectAllRequestsTo { get; }

            [nterraform.TerraformProperty(name: "routing_rules", @out: false, min: 0, max: 1)]
            public string @RoutingRules { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "versioning")]
        public sealed class versioning : nterraform.structure
        {
            public versioning(bool? @enabled = null,
                              bool? @mfaDelete = null)
            {
                @Enabled = @enabled;
                @MfaDelete = @mfaDelete;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
            public bool? @Enabled { get; }

            [nterraform.TerraformProperty(name: "mfa_delete", @out: false, min: 0, max: 1)]
            public bool? @MfaDelete { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "logging")]
        public sealed class logging : nterraform.structure
        {
            public logging(string @targetBucket,
                           string @targetPrefix = null)
            {
                @TargetBucket = @targetBucket;
                @TargetPrefix = @targetPrefix;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "target_bucket", @out: false, min: 1, max: 1)]
            public string @TargetBucket { get; }

            [nterraform.TerraformProperty(name: "target_prefix", @out: false, min: 0, max: 1)]
            public string @TargetPrefix { get; }
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

        [nterraform.TerraformProperty(name: "acceleration_status", @out: true, min: 0, max: 1)]
        public string @AccelerationStatus { get; }

        [nterraform.TerraformProperty(name: "acl", @out: false, min: 0, max: 1)]
        public string @Acl { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "bucket", @out: true, min: 0, max: 1)]
        public string @Bucket { get; }

        [nterraform.TerraformProperty(name: "bucket_domain_name", @out: true, min: 0, max: 1)]
        public string @BucketDomainName { get; }

        [nterraform.TerraformProperty(name: "bucket_prefix", @out: false, min: 0, max: 1)]
        public string @BucketPrefix { get; }

        [nterraform.TerraformProperty(name: "bucket_regional_domain_name", @out: true, min: 0, max: 1)]
        public string @BucketRegionalDomainName { get; }

        [nterraform.TerraformProperty(name: "cors_rule", @out: false, min: 0, max: 0)]
        public cors_rule[] @CorsRule { get; }

        [nterraform.TerraformProperty(name: "force_destroy", @out: false, min: 0, max: 1)]
        public bool? @ForceDestroy { get; }

        [nterraform.TerraformProperty(name: "hosted_zone_id", @out: true, min: 0, max: 1)]
        public string @HostedZoneId { get; }

        [nterraform.TerraformProperty(name: "lifecycle_rule", @out: false, min: 0, max: 0)]
        public lifecycle_rule[] @LifecycleRule { get; }

        [nterraform.TerraformProperty(name: "logging", @out: false, min: 0, max: 0)]
        public logging[] @Logging { get; }

        [nterraform.TerraformProperty(name: "policy", @out: false, min: 0, max: 1)]
        public string @Policy { get; }

        [nterraform.TerraformProperty(name: "region", @out: true, min: 0, max: 1)]
        public string @Region { get; }

        [nterraform.TerraformProperty(name: "replication_configuration", @out: false, min: 0, max: 1)]
        public replication_configuration[] @ReplicationConfiguration { get; }

        [nterraform.TerraformProperty(name: "request_payer", @out: true, min: 0, max: 1)]
        public string @RequestPayer { get; }

        [nterraform.TerraformProperty(name: "server_side_encryption_configuration", @out: false, min: 0, max: 1)]
        public server_side_encryption_configuration[] @ServerSideEncryptionConfiguration { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "versioning", @out: false, min: 0, max: 1)]
        public versioning[] @Versioning { get; }

        [nterraform.TerraformProperty(name: "website", @out: false, min: 0, max: 0)]
        public website[] @Website { get; }

        [nterraform.TerraformProperty(name: "website_domain", @out: true, min: 0, max: 1)]
        public string @WebsiteDomain { get; }

        [nterraform.TerraformProperty(name: "website_endpoint", @out: true, min: 0, max: 1)]
        public string @WebsiteEndpoint { get; }
    }

}
