using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_template_deployment : NTerraform.resource
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
        }

        public string @DeploymentMode { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public Dictionary<string,string> @Outputs { get; }
        public Dictionary<string,string> @Parameters { get; }
        public string @ParametersBody { get; }
        public string @TemplateBody { get; }
    }

}
