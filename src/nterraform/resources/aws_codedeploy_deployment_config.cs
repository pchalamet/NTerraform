using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_codedeploy_deployment_config")]
    public sealed class aws_codedeploy_deployment_config : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "minimum_healthy_hosts")]
        public sealed class minimum_healthy_hosts : nterraform.structure
        {
            public minimum_healthy_hosts(string @type,
                                         int? @value = null)
            {
                @Type = @type;
                @Value = @value;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.TerraformProperty(name: "value", @out: false, min: 0, max: 1)]
            public int? @Value { get; }
        }

        public aws_codedeploy_deployment_config(string @deploymentConfigName,
                                                minimum_healthy_hosts[] @minimumHealthyHosts)
        {
            @DeploymentConfigName = @deploymentConfigName;
            @MinimumHealthyHosts = @minimumHealthyHosts;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "deployment_config_name", @out: false, min: 1, max: 1)]
        public string @DeploymentConfigName { get; }

        [nterraform.TerraformProperty(name: "minimum_healthy_hosts", @out: false, min: 1, max: 1)]
        public minimum_healthy_hosts[] @MinimumHealthyHosts { get; }

        [nterraform.TerraformProperty(name: "deployment_config_id", @out: true, min: 0, max: 1)]
        public string @DeploymentConfigId { get; }
    }

}
