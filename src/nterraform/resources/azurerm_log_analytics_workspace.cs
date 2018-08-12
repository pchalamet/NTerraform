using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_log_analytics_workspace")]
    public sealed class azurerm_log_analytics_workspace : nterraform.Core.resource
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

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "sku", @out: false, min: 1, max: 1)]
        public string @Sku { get; }

        [nterraform.Core.TerraformProperty(name: "portal_url", @out: true, min: 0, max: 1)]
        public string @PortalUrl { get; }

        [nterraform.Core.TerraformProperty(name: "primary_shared_key", @out: true, min: 0, max: 1)]
        public string @PrimarySharedKey { get; }

        [nterraform.Core.TerraformProperty(name: "retention_in_days", @out: true, min: 0, max: 1)]
        public int? @RetentionInDays { get; }

        [nterraform.Core.TerraformProperty(name: "secondary_shared_key", @out: true, min: 0, max: 1)]
        public string @SecondarySharedKey { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpMap<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "workspace_id", @out: true, min: 0, max: 1)]
        public string @WorkspaceId { get; }
    }

}
