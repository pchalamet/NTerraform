using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_log_analytics_solution")]
    public sealed class azurerm_log_analytics_solution : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "plan")]
        public sealed class plan
        {
            public plan(string @product,
                        string @publisher,
                        string @promotionCode = null)
            {
                @Product = @product;
                @Publisher = @publisher;
                @PromotionCode = @promotionCode;
            }

            [TerraformProperty(name: "product", @out: false, min: 1, max: 1)]
            public string @Product { get; }

            [TerraformProperty(name: "publisher", @out: false, min: 1, max: 1)]
            public string @Publisher { get; }

            [TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "promotion_code", @out: false, min: 0, max: 1)]
            public string @PromotionCode { get; }
        }

        public azurerm_log_analytics_solution(string @location,
                                              plan[] @plan,
                                              string @resourceGroupName,
                                              string @solutionName,
                                              string @workspaceName,
                                              string @workspaceResourceId)
        {
            @Location = @location;
            @Plan = @plan;
            @ResourceGroupName = @resourceGroupName;
            @SolutionName = @solutionName;
            @WorkspaceName = @workspaceName;
            @WorkspaceResourceId = @workspaceResourceId;
        }

        [TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "plan", @out: false, min: 1, max: 1)]
        public plan[] @Plan { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "solution_name", @out: false, min: 1, max: 1)]
        public string @SolutionName { get; }

        [TerraformProperty(name: "workspace_name", @out: false, min: 1, max: 1)]
        public string @WorkspaceName { get; }

        [TerraformProperty(name: "workspace_resource_id", @out: false, min: 1, max: 1)]
        public string @WorkspaceResourceId { get; }
    }

}
