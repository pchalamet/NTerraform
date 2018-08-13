using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_codebuild_project")]
    public sealed class aws_codebuild_project : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "artifacts")]
        public sealed class artifacts : nterraform.Core.structure
        {
            public artifacts(string @type,
                             string @location = null,
                             string @name = null,
                             string @namespaceType = null,
                             string @packaging = null,
                             string @path = null)
            {
                @Type = @type;
                @Location = @location;
                @Name = @name;
                @NamespaceType = @namespaceType;
                @Packaging = @packaging;
                @Path = @path;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 0, max: 1)]
            public string @Location { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 0, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "namespace_type", @out: false, min: 0, max: 1)]
            public string @NamespaceType { get; }

            [nterraform.Core.TerraformProperty(name: "packaging", @out: false, min: 0, max: 1)]
            public string @Packaging { get; }

            [nterraform.Core.TerraformProperty(name: "path", @out: false, min: 0, max: 1)]
            public string @Path { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "source")]
        public sealed class source : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "auth")]
            public sealed class auth : nterraform.Core.structure
            {
                public auth(string @type,
                            string @resource = null)
                {
                    @Type = @type;
                    @Resource = @resource;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
                public string @Type { get; }

                [nterraform.Core.TerraformProperty(name: "resource", @out: false, min: 0, max: 1)]
                public string @Resource { get; }
            }

            public source(string @type,
                          auth[] @auth = null,
                          string @buildspec = null,
                          int? @gitCloneDepth = null,
                          bool? @insecureSsl = null,
                          string @location = null,
                          bool? @reportBuildStatus = null)
            {
                @Type = @type;
                @Auth = @auth;
                @Buildspec = @buildspec;
                @GitCloneDepth = @gitCloneDepth;
                @InsecureSsl = @insecureSsl;
                @Location = @location;
                @ReportBuildStatus = @reportBuildStatus;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.Core.TerraformProperty(name: "auth", @out: false, min: 0, max: 0)]
            public auth[] @Auth { get; }

            [nterraform.Core.TerraformProperty(name: "buildspec", @out: false, min: 0, max: 1)]
            public string @Buildspec { get; }

            [nterraform.Core.TerraformProperty(name: "git_clone_depth", @out: false, min: 0, max: 1)]
            public int? @GitCloneDepth { get; }

            [nterraform.Core.TerraformProperty(name: "insecure_ssl", @out: false, min: 0, max: 1)]
            public bool? @InsecureSsl { get; }

            [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 0, max: 1)]
            public string @Location { get; }

            [nterraform.Core.TerraformProperty(name: "report_build_status", @out: false, min: 0, max: 1)]
            public bool? @ReportBuildStatus { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "cache")]
        public sealed class cache : nterraform.Core.structure
        {
            public cache(string @location = null,
                         string @type = null)
            {
                @Location = @location;
                @Type = @type;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 0, max: 1)]
            public string @Location { get; }

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 0, max: 1)]
            public string @Type { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "environment")]
        public sealed class environment : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "environment_variable")]
            public sealed class environment_variable : nterraform.Core.structure
            {
                public environment_variable(string @name,
                                            string @value,
                                            string @type = null)
                {
                    @Name = @name;
                    @Value = @value;
                    @Type = @type;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
                public string @Name { get; }

                [nterraform.Core.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
                public string @Value { get; }

                [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 0, max: 1)]
                public string @Type { get; }
            }

            public environment(string @computeType,
                               string @image,
                               string @type,
                               environment_variable[] @environmentVariable = null,
                               bool? @privilegedMode = null)
            {
                @ComputeType = @computeType;
                @Image = @image;
                @Type = @type;
                @EnvironmentVariable = @environmentVariable;
                @PrivilegedMode = @privilegedMode;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "compute_type", @out: false, min: 1, max: 1)]
            public string @ComputeType { get; }

            [nterraform.Core.TerraformProperty(name: "image", @out: false, min: 1, max: 1)]
            public string @Image { get; }

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.Core.TerraformProperty(name: "environment_variable", @out: false, min: 0, max: 0)]
            public environment_variable[] @EnvironmentVariable { get; }

            [nterraform.Core.TerraformProperty(name: "privileged_mode", @out: false, min: 0, max: 1)]
            public bool? @PrivilegedMode { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "vpc_config")]
        public sealed class vpc_config : nterraform.Core.structure
        {
            public vpc_config(string[] @securityGroupIds,
                              string[] @subnets,
                              string @vpcId)
            {
                @SecurityGroupIds = @securityGroupIds;
                @Subnets = @subnets;
                @VpcId = @vpcId;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "security_group_ids", @out: false, min: 1, max: 1)]
            public string[] @SecurityGroupIds { get; }

            [nterraform.Core.TerraformProperty(name: "subnets", @out: false, min: 1, max: 1)]
            public string[] @Subnets { get; }

            [nterraform.Core.TerraformProperty(name: "vpc_id", @out: false, min: 1, max: 1)]
            public string @VpcId { get; }
        }

        public aws_codebuild_project(artifacts[] @artifacts,
                                     environment[] @environment,
                                     string @name,
                                     string @serviceRole,
                                     source[] @source,
                                     bool? @badgeEnabled = null,
                                     int? @buildTimeout = null,
                                     cache[] @cache = null,
                                     Dictionary<string,string> @tags = null,
                                     int? @timeout = null,
                                     vpc_config[] @vpcConfig = null)
        {
            @Artifacts = @artifacts;
            @Environment = @environment;
            @Name = @name;
            @ServiceRole = @serviceRole;
            @Source = @source;
            @BadgeEnabled = @badgeEnabled;
            @BuildTimeout = @buildTimeout;
            @Cache = @cache;
            @Tags = @tags;
            @Timeout = @timeout;
            @VpcConfig = @vpcConfig;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "artifacts", @out: false, min: 1, max: 1)]
        public artifacts[] @Artifacts { get; }

        [nterraform.Core.TerraformProperty(name: "environment", @out: false, min: 1, max: 1)]
        public environment[] @Environment { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "service_role", @out: false, min: 1, max: 1)]
        public string @ServiceRole { get; }

        [nterraform.Core.TerraformProperty(name: "source", @out: false, min: 1, max: 1)]
        public source[] @Source { get; }

        [nterraform.Core.TerraformProperty(name: "badge_enabled", @out: false, min: 0, max: 1)]
        public bool? @BadgeEnabled { get; }

        [nterraform.Core.TerraformProperty(name: "badge_url", @out: true, min: 0, max: 1)]
        public string @BadgeUrl { get; }

        [nterraform.Core.TerraformProperty(name: "build_timeout", @out: false, min: 0, max: 1)]
        public int? @BuildTimeout { get; }

        [nterraform.Core.TerraformProperty(name: "cache", @out: false, min: 0, max: 1)]
        public cache[] @Cache { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: true, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "encryption_key", @out: true, min: 0, max: 1)]
        public string @EncryptionKey { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "timeout", @out: false, min: 0, max: 1)]
        public int? @Timeout { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_config", @out: false, min: 0, max: 1)]
        public vpc_config[] @VpcConfig { get; }
    }

}
