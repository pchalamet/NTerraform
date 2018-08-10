using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_logic_app_workflow : NTerraform.resource
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

        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @AccessEndpoint { get; }
        public Dictionary<string,string> @Parameters { get; }
        public Dictionary<string,string> @Tags { get; }
        public string @WorkflowSchema { get; }
        public string @WorkflowVersion { get; }
    }

}
