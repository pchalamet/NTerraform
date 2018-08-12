using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_logic_app_workflow")]
    public sealed class azurerm_logic_app_workflow : nterraform.Core.data
    {
        public azurerm_logic_app_workflow(string @name,
                                          string @resourceGroupName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "access_endpoint", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @AccessEndpoint { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Location { get; }

        [nterraform.Core.TerraformProperty(name: "parameters", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpMap<string,string>> @Parameters { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpMap<string,string>> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "workflow_schema", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @WorkflowSchema { get; }

        [nterraform.Core.TerraformProperty(name: "workflow_version", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @WorkflowVersion { get; }
    }

}
