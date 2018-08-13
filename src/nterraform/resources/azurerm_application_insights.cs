using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_application_insights")]
    public sealed class azurerm_application_insights : nterraform.resource
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "application_type", @out: false, min: 1, max: 1)]
        public string @ApplicationType { get; }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "app_id", @out: true, min: 0, max: 1)]
        public string @AppId { get; }

        [nterraform.TerraformProperty(name: "instrumentation_key", @out: true, min: 0, max: 1)]
        public string @InstrumentationKey { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
