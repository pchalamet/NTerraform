using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_log_analytics_workspace")]
    public sealed class azurerm_log_analytics_workspace : NTerraform.resource
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

        [TerraformProperty(name: "location", @out: false, nested: true, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "sku", @out: false, nested: true, min: 1, max: 1)]
        public string @Sku { get; }

        [TerraformProperty(name: "portal_url", @out: true, nested: true, min: 0, max: 1)]
        public string @PortalUrl { get; }

        [TerraformProperty(name: "primary_shared_key", @out: true, nested: true, min: 0, max: 1)]
        public string @PrimarySharedKey { get; }

        [TerraformProperty(name: "retention_in_days", @out: true, nested: true, min: 0, max: 1)]
        public int? @RetentionInDays { get; }

        [TerraformProperty(name: "secondary_shared_key", @out: true, nested: true, min: 0, max: 1)]
        public string @SecondarySharedKey { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [TerraformProperty(name: "workspace_id", @out: true, nested: true, min: 0, max: 1)]
        public string @WorkspaceId { get; }
    }

}
