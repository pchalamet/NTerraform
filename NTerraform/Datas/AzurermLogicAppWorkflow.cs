using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "azurerm_logic_app_workflow")]
    public sealed class azurerm_logic_app_workflow : NTerraform.data
    {
        public azurerm_logic_app_workflow(string @name,
                                          string @resourceGroupName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
        }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "access_endpoint", @out: true, nested: true, min: 0, max: 1)]
        public string @AccessEndpoint { get; }

        [TerraformProperty(name: "location", @out: true, nested: true, min: 0, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "parameters", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Parameters { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [TerraformProperty(name: "workflow_schema", @out: true, nested: true, min: 0, max: 1)]
        public string @WorkflowSchema { get; }

        [TerraformProperty(name: "workflow_version", @out: true, nested: true, min: 0, max: 1)]
        public string @WorkflowVersion { get; }
    }

}
