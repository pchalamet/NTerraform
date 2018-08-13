using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_lambda_alias")]
    public sealed class aws_lambda_alias : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "routing_config")]
        public sealed class routing_config : nterraform.structure
        {
            public routing_config(Dictionary<string,int> @additionalVersionWeights = null)
            {
                @AdditionalVersionWeights = @additionalVersionWeights;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "additional_version_weights", @out: false, min: 0, max: 1)]
            public Dictionary<string,int> @AdditionalVersionWeights { get; }
        }

        public aws_lambda_alias(string @functionName,
                                string @functionVersion,
                                string @name,
                                string @description = null,
                                routing_config[] @routingConfig = null)
        {
            @FunctionName = @functionName;
            @FunctionVersion = @functionVersion;
            @Name = @name;
            @Description = @description;
            @RoutingConfig = @routingConfig;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "function_name", @out: false, min: 1, max: 1)]
        public string @FunctionName { get; }

        [nterraform.TerraformProperty(name: "function_version", @out: false, min: 1, max: 1)]
        public string @FunctionVersion { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "routing_config", @out: false, min: 0, max: 1)]
        public routing_config[] @RoutingConfig { get; }
    }

}
