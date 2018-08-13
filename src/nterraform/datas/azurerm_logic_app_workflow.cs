using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "azurerm_logic_app_workflow")]
    public sealed class azurerm_logic_app_workflow : nterraform.data
    {
        public azurerm_logic_app_workflow(string @name,
                                          string @resourceGroupName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "access_endpoint", @out: true, min: 0, max: 1)]
        public string @AccessEndpoint { get; }

        [nterraform.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "parameters", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Parameters { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "workflow_schema", @out: true, min: 0, max: 1)]
        public string @WorkflowSchema { get; }

        [nterraform.TerraformProperty(name: "workflow_version", @out: true, min: 0, max: 1)]
        public string @WorkflowVersion { get; }
    }

}
