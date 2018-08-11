using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_log_analytics_solution : NTerraform.resource
    {
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

            public string @Product { get; }
            public string @Publisher { get; }
            public string @Name { get; }
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

        public string @Location { get; }
        public plan[] @Plan { get; }
        public string @ResourceGroupName { get; }
        public string @SolutionName { get; }
        public string @WorkspaceName { get; }
        public string @WorkspaceResourceId { get; }
    }

}
