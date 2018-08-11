using System.Collections.Generic;

namespace NTerraform.Datas
{
    public class azurerm_logic_app_workflow : NTerraform.data
    {
        public azurerm_logic_app_workflow(string @name,
                                          string @resourceGroupName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
        }

        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @AccessEndpoint { get; }
        public string @Location { get; }
        public Dictionary<string,string> @Parameters { get; }
        public Dictionary<string,string> @Tags { get; }
        public string @WorkflowSchema { get; }
        public string @WorkflowVersion { get; }
    }

}
