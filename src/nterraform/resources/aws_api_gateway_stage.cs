using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_api_gateway_stage")]
    public sealed class aws_api_gateway_stage : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "access_log_settings")]
        public sealed class access_log_settings : nterraform.Core.structure
        {
            public access_log_settings(string @destinationArn,
                                       string @format)
            {
                @DestinationArn = @destinationArn;
                @Format = @format;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "destination_arn", @out: false, min: 1, max: 1)]
            public string @DestinationArn { get; }

            [nterraform.Core.TerraformProperty(name: "format", @out: false, min: 1, max: 1)]
            public string @Format { get; }
        }

        public aws_api_gateway_stage(string @deploymentId,
                                     string @restApiId,
                                     string @stageName,
                                     access_log_settings[] @accessLogSettings = null,
                                     bool? @cacheClusterEnabled = null,
                                     string @cacheClusterSize = null,
                                     string @clientCertificateId = null,
                                     string @description = null,
                                     string @documentationVersion = null,
                                     Dictionary<string,string> @tags = null,
                                     Dictionary<string,string> @variables = null)
        {
            @DeploymentId = @deploymentId;
            @RestApiId = @restApiId;
            @StageName = @stageName;
            @AccessLogSettings = @accessLogSettings;
            @CacheClusterEnabled = @cacheClusterEnabled;
            @CacheClusterSize = @cacheClusterSize;
            @ClientCertificateId = @clientCertificateId;
            @Description = @description;
            @DocumentationVersion = @documentationVersion;
            @Tags = @tags;
            @Variables = @variables;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "deployment_id", @out: false, min: 1, max: 1)]
        public string @DeploymentId { get; }

        [nterraform.Core.TerraformProperty(name: "rest_api_id", @out: false, min: 1, max: 1)]
        public string @RestApiId { get; }

        [nterraform.Core.TerraformProperty(name: "stage_name", @out: false, min: 1, max: 1)]
        public string @StageName { get; }

        [nterraform.Core.TerraformProperty(name: "access_log_settings", @out: false, min: 0, max: 1)]
        public access_log_settings[] @AccessLogSettings { get; }

        [nterraform.Core.TerraformProperty(name: "cache_cluster_enabled", @out: false, min: 0, max: 1)]
        public bool? @CacheClusterEnabled { get; }

        [nterraform.Core.TerraformProperty(name: "cache_cluster_size", @out: false, min: 0, max: 1)]
        public string @CacheClusterSize { get; }

        [nterraform.Core.TerraformProperty(name: "client_certificate_id", @out: false, min: 0, max: 1)]
        public string @ClientCertificateId { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "documentation_version", @out: false, min: 0, max: 1)]
        public string @DocumentationVersion { get; }

        [nterraform.Core.TerraformProperty(name: "execution_arn", @out: true, min: 0, max: 1)]
        public string @ExecutionArn { get; }

        [nterraform.Core.TerraformProperty(name: "invoke_url", @out: true, min: 0, max: 1)]
        public string @InvokeUrl { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "variables", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Variables { get; }
    }

}