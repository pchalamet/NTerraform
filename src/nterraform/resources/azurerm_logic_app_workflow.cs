using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_logic_app_workflow")]
    public sealed class azurerm_logic_app_workflow : nterraform.Core.resource
    {
        public azurerm_logic_app_workflow(string @location,
                                          string @name,
                                          string @resourceGroupName,
                                          FSharpMap<string,string> @parameters = null,
                                          string @workflowSchema = null,
                                          string @workflowVersion = null)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Parameters = @parameters ?? MapModule.Empty<string,string>();
            @WorkflowSchema = @workflowSchema;
            @WorkflowVersion = @workflowVersion;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "access_endpoint", @out: true, min: 0, max: 1)]
        public string @AccessEndpoint { get; }

        [nterraform.Core.TerraformProperty(name: "parameters", @out: false, min: 0, max: 1)]
        public FSharpMap<string,string> @Parameters { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpMap<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "workflow_schema", @out: false, min: 0, max: 1)]
        public string @WorkflowSchema { get; }

        [nterraform.Core.TerraformProperty(name: "workflow_version", @out: false, min: 0, max: 1)]
        public string @WorkflowVersion { get; }
    }

}
