using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_logic_app_workflow")]
    public sealed class azurerm_logic_app_workflow : NTerraform.resource
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
        }

        [TerraformProperty(name: "location", @out: false, nested: true, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "access_endpoint", @out: true, nested: true, min: 0, max: 1)]
        public string @AccessEndpoint { get; }

        [TerraformProperty(name: "parameters", @out: false, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Parameters { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [TerraformProperty(name: "workflow_schema", @out: false, nested: true, min: 0, max: 1)]
        public string @WorkflowSchema { get; }

        [TerraformProperty(name: "workflow_version", @out: false, nested: true, min: 0, max: 1)]
        public string @WorkflowVersion { get; }
    }

}
