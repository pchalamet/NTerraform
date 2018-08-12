using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_template_deployment")]
    public sealed class azurerm_template_deployment : nterraform.Core.resource
    {
        public azurerm_template_deployment(string @deploymentMode,
                                           string @name,
                                           string @resourceGroupName,
                                           FSharpMap<string,string> @parameters = null,
                                           string @parametersBody = null)
        {
            @DeploymentMode = @deploymentMode;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Parameters = @parameters ?? MapModule.Empty<string,string>();
            @ParametersBody = @parametersBody;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "deployment_mode", @out: false, min: 1, max: 1)]
        public string @DeploymentMode { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "outputs", @out: true, min: 0, max: 1)]
        public FSharpMap<string,string> @Outputs { get; }

        [nterraform.Core.TerraformProperty(name: "parameters", @out: false, min: 0, max: 1)]
        public FSharpMap<string,string> @Parameters { get; }

        [nterraform.Core.TerraformProperty(name: "parameters_body", @out: false, min: 0, max: 1)]
        public string @ParametersBody { get; }

        [nterraform.Core.TerraformProperty(name: "template_body", @out: true, min: 0, max: 1)]
        public string @TemplateBody { get; }
    }

}
