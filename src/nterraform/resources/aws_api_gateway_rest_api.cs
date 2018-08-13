using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_api_gateway_rest_api")]
    public sealed class aws_api_gateway_rest_api : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "endpoint_configuration")]
        public sealed class endpoint_configuration : nterraform.Core.structure
        {
            public endpoint_configuration(string[] @types)
            {
                @Types = @types;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "types", @out: false, min: 1, max: 1)]
            public string[] @Types { get; }
        }

        public aws_api_gateway_rest_api(endpoint_configuration[] @endpointConfiguration,
                                        string @name,
                                        string @apiKeySource = null,
                                        string[] @binaryMediaTypes = null,
                                        string @body = null,
                                        string @description = null,
                                        int? @minimumCompressionSize = null,
                                        string @policy = null)
        {
            @EndpointConfiguration = @endpointConfiguration;
            @Name = @name;
            @ApiKeySource = @apiKeySource;
            @BinaryMediaTypes = @binaryMediaTypes;
            @Body = @body;
            @Description = @description;
            @MinimumCompressionSize = @minimumCompressionSize;
            @Policy = @policy;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "endpoint_configuration", @out: false, min: 1, max: 1)]
        public endpoint_configuration[] @EndpointConfiguration { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "api_key_source", @out: false, min: 0, max: 1)]
        public string @ApiKeySource { get; }

        [nterraform.Core.TerraformProperty(name: "binary_media_types", @out: false, min: 0, max: 1)]
        public string[] @BinaryMediaTypes { get; }

        [nterraform.Core.TerraformProperty(name: "body", @out: false, min: 0, max: 1)]
        public string @Body { get; }

        [nterraform.Core.TerraformProperty(name: "created_date", @out: true, min: 0, max: 1)]
        public string @CreatedDate { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "execution_arn", @out: true, min: 0, max: 1)]
        public string @ExecutionArn { get; }

        [nterraform.Core.TerraformProperty(name: "minimum_compression_size", @out: false, min: 0, max: 1)]
        public int? @MinimumCompressionSize { get; }

        [nterraform.Core.TerraformProperty(name: "policy", @out: false, min: 0, max: 1)]
        public string @Policy { get; }

        [nterraform.Core.TerraformProperty(name: "root_resource_id", @out: true, min: 0, max: 1)]
        public string @RootResourceId { get; }
    }

}
