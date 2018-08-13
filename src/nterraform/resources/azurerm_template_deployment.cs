using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_template_deployment")]
    public sealed class azurerm_template_deployment : nterraform.resource
    {
        public azurerm_template_deployment(string @deploymentMode,
                                           string @name,
                                           string @resourceGroupName,
                                           Dictionary<string,string> @parameters = null,
                                           string @parametersBody = null)
        {
            @DeploymentMode = @deploymentMode;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Parameters = @parameters;
            @ParametersBody = @parametersBody;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "deployment_mode", @out: false, min: 1, max: 1)]
        public string @DeploymentMode { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "outputs", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Outputs { get; }

        [nterraform.TerraformProperty(name: "parameters", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Parameters { get; }

        [nterraform.TerraformProperty(name: "parameters_body", @out: false, min: 0, max: 1)]
        public string @ParametersBody { get; }

        [nterraform.TerraformProperty(name: "template_body", @out: true, min: 0, max: 1)]
        public string @TemplateBody { get; }
    }

}
