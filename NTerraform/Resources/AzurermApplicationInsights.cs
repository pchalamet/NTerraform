using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_application_insights")]
    public sealed class azurerm_application_insights : NTerraform.resource
    {
        public azurerm_application_insights(string @applicationType,
                                            string @location,
                                            string @name,
                                            string @resourceGroupName)
        {
            @ApplicationType = @applicationType;
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
        }

        [TerraformProperty(name: "application_type", @out: false, nested: true, min: 1, max: 1)]
        public string @ApplicationType { get; }

        [TerraformProperty(name: "location", @out: false, nested: true, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "app_id", @out: true, nested: true, min: 0, max: 1)]
        public string @AppId { get; }

        [TerraformProperty(name: "instrumentation_key", @out: true, nested: true, min: 0, max: 1)]
        public string @InstrumentationKey { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
