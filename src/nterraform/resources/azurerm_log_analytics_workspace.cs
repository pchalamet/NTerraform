using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_log_analytics_workspace")]
    public sealed class azurerm_log_analytics_workspace : nterraform.resource
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "sku", @out: false, min: 1, max: 1)]
        public string @Sku { get; }

        [nterraform.TerraformProperty(name: "portal_url", @out: true, min: 0, max: 1)]
        public string @PortalUrl { get; }

        [nterraform.TerraformProperty(name: "primary_shared_key", @out: true, min: 0, max: 1)]
        public string @PrimarySharedKey { get; }

        [nterraform.TerraformProperty(name: "retention_in_days", @out: true, min: 0, max: 1)]
        public int? @RetentionInDays { get; }

        [nterraform.TerraformProperty(name: "secondary_shared_key", @out: true, min: 0, max: 1)]
        public string @SecondarySharedKey { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "workspace_id", @out: true, min: 0, max: 1)]
        public string @WorkspaceId { get; }
    }

}
