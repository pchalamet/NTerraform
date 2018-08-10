using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_log_analytics_workspace : NTerraform.resource
    {
        public azurerm_log_analytics_workspace(string @location,
                                               string @name,
                                               string @resourceGroupName,
                                               string @sku)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Sku = @sku;
        }

        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @Sku { get; }
        public string @PortalUrl { get; }
        public string @PrimarySharedKey { get; }
        public int? @RetentionInDays { get; }
        public string @SecondarySharedKey { get; }
        public Dictionary<string,string> @Tags { get; }
        public string @WorkspaceId { get; }
    }

}
