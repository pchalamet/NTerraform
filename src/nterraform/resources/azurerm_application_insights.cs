using System.Collections.Generic;

namespace nterraform.resources.azurerm
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_application_insights")]
    public sealed class azurerm_application_insights : nterraform.Core.resource
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

        [nterraform.Core.TerraformProperty(name: "application_type", @out: false, min: 1, max: 1)]
        public string @ApplicationType { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "app_id", @out: true, min: 0, max: 1)]
        public string @AppId { get; }

        [nterraform.Core.TerraformProperty(name: "instrumentation_key", @out: true, min: 0, max: 1)]
        public string @InstrumentationKey { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
