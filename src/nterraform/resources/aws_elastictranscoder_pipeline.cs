using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_elastictranscoder_pipeline")]
    public sealed class aws_elastictranscoder_pipeline : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "thumbnail_config_permissions")]
        public sealed class thumbnail_config_permissions : nterraform.Core.structure
        {
            public thumbnail_config_permissions(string[] @access = null,
                                                string @grantee = null,
                                                string @granteeType = null)
            {
                @Access = @access;
                @Grantee = @grantee;
                @GranteeType = @granteeType;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "access", @out: false, min: 0, max: 1)]
            public string[] @Access { get; }

            [nterraform.Core.TerraformProperty(name: "grantee", @out: false, min: 0, max: 1)]
            public string @Grantee { get; }

            [nterraform.Core.TerraformProperty(name: "grantee_type", @out: false, min: 0, max: 1)]
            public string @GranteeType { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "content_config_permissions")]
        public sealed class content_config_permissions : nterraform.Core.structure
        {
            public content_config_permissions(string[] @access = null,
                                              string @grantee = null,
                                              string @granteeType = null)
            {
                @Access = @access;
                @Grantee = @grantee;
                @GranteeType = @granteeType;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "access", @out: false, min: 0, max: 1)]
            public string[] @Access { get; }

            [nterraform.Core.TerraformProperty(name: "grantee", @out: false, min: 0, max: 1)]
            public string @Grantee { get; }

            [nterraform.Core.TerraformProperty(name: "grantee_type", @out: false, min: 0, max: 1)]
            public string @GranteeType { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "notifications")]
        public sealed class notifications : nterraform.Core.structure
        {
            public notifications(string @completed = null,
                                 string @error = null,
                                 string @progressing = null,
                                 string @warning = null)
            {
                @Completed = @completed;
                @Error = @error;
                @Progressing = @progressing;
                @Warning = @warning;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "completed", @out: false, min: 0, max: 1)]
            public string @Completed { get; }

            [nterraform.Core.TerraformProperty(name: "error", @out: false, min: 0, max: 1)]
            public string @Error { get; }

            [nterraform.Core.TerraformProperty(name: "progressing", @out: false, min: 0, max: 1)]
            public string @Progressing { get; }

            [nterraform.Core.TerraformProperty(name: "warning", @out: false, min: 0, max: 1)]
            public string @Warning { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "thumbnail_config")]
        public sealed class thumbnail_config : nterraform.Core.structure
        {
            public thumbnail_config(string @storageClass = null)
            {
                @StorageClass = @storageClass;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "bucket", @out: true, min: 0, max: 1)]
            public string @Bucket { get; }

            [nterraform.Core.TerraformProperty(name: "storage_class", @out: false, min: 0, max: 1)]
            public string @StorageClass { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "content_config")]
        public sealed class content_config : nterraform.Core.structure
        {
            public content_config(string @storageClass = null)
            {
                @StorageClass = @storageClass;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "bucket", @out: true, min: 0, max: 1)]
            public string @Bucket { get; }

            [nterraform.Core.TerraformProperty(name: "storage_class", @out: false, min: 0, max: 1)]
            public string @StorageClass { get; }
        }

        public aws_elastictranscoder_pipeline(string @inputBucket,
                                              string @role,
                                              string @awsKmsKeyArn = null,
                                              content_config[] @contentConfig = null,
                                              content_config_permissions[] @contentConfigPermissions = null,
                                              notifications[] @notifications = null,
                                              thumbnail_config[] @thumbnailConfig = null,
                                              thumbnail_config_permissions[] @thumbnailConfigPermissions = null)
        {
            @InputBucket = @inputBucket;
            @Role = @role;
            @AwsKmsKeyArn = @awsKmsKeyArn;
            @ContentConfig = @contentConfig;
            @ContentConfigPermissions = @contentConfigPermissions;
            @Notifications = @notifications;
            @ThumbnailConfig = @thumbnailConfig;
            @ThumbnailConfigPermissions = @thumbnailConfigPermissions;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "input_bucket", @out: false, min: 1, max: 1)]
        public string @InputBucket { get; }

        [nterraform.Core.TerraformProperty(name: "role", @out: false, min: 1, max: 1)]
        public string @Role { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "aws_kms_key_arn", @out: false, min: 0, max: 1)]
        public string @AwsKmsKeyArn { get; }

        [nterraform.Core.TerraformProperty(name: "content_config", @out: false, min: 0, max: 1)]
        public content_config[] @ContentConfig { get; }

        [nterraform.Core.TerraformProperty(name: "content_config_permissions", @out: false, min: 0, max: 0)]
        public content_config_permissions[] @ContentConfigPermissions { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "notifications", @out: false, min: 0, max: 1)]
        public notifications[] @Notifications { get; }

        [nterraform.Core.TerraformProperty(name: "output_bucket", @out: true, min: 0, max: 1)]
        public string @OutputBucket { get; }

        [nterraform.Core.TerraformProperty(name: "thumbnail_config", @out: false, min: 0, max: 1)]
        public thumbnail_config[] @ThumbnailConfig { get; }

        [nterraform.Core.TerraformProperty(name: "thumbnail_config_permissions", @out: false, min: 0, max: 0)]
        public thumbnail_config_permissions[] @ThumbnailConfigPermissions { get; }
    }

}
