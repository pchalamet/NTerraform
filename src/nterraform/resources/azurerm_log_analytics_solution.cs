using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_log_analytics_solution")]
    public sealed class azurerm_log_analytics_solution : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "plan")]
        public sealed class plan : nterraform.structure
        {
            public plan(string @product,
                        string @publisher,
                        string @promotionCode = null)
            {
                @Product = @product;
                @Publisher = @publisher;
                @PromotionCode = @promotionCode;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "product", @out: false, min: 1, max: 1)]
            public string @Product { get; }

            [nterraform.TerraformProperty(name: "publisher", @out: false, min: 1, max: 1)]
            public string @Publisher { get; }

            [nterraform.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "promotion_code", @out: false, min: 0, max: 1)]
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "plan", @out: false, min: 1, max: 1)]
        public plan[] @Plan { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "solution_name", @out: false, min: 1, max: 1)]
        public string @SolutionName { get; }

        [nterraform.TerraformProperty(name: "workspace_name", @out: false, min: 1, max: 1)]
        public string @WorkspaceName { get; }

        [nterraform.TerraformProperty(name: "workspace_resource_id", @out: false, min: 1, max: 1)]
        public string @WorkspaceResourceId { get; }
    }

}
