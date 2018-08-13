using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_logic_app_workflow")]
    public sealed class azurerm_logic_app_workflow : nterraform.resource
    {
        public azurerm_logic_app_workflow(string @location,
                                          string @name,
                                          string @resourceGroupName,
                                          Dictionary<string,string> @parameters = null,
                                          string @workflowSchema = null,
                                          string @workflowVersion = null)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Parameters = @parameters;
            @WorkflowSchema = @workflowSchema;
            @WorkflowVersion = @workflowVersion;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "access_endpoint", @out: true, min: 0, max: 1)]
        public string @AccessEndpoint { get; }

        [nterraform.TerraformProperty(name: "parameters", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Parameters { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "workflow_schema", @out: false, min: 0, max: 1)]
        public string @WorkflowSchema { get; }

        [nterraform.TerraformProperty(name: "workflow_version", @out: false, min: 0, max: 1)]
        public string @WorkflowVersion { get; }
    }

}
