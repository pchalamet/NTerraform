using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_eventgrid_topic")]
    public sealed class azurerm_eventgrid_topic : nterraform.Core.resource
    {
        public azurerm_eventgrid_topic(string @location,
                                       string @name,
                                       string @resourceGroupName)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "endpoint", @out: true, min: 0, max: 1)]
        public string @Endpoint { get; }

        [nterraform.Core.TerraformProperty(name: "primary_access_key", @out: true, min: 0, max: 1)]
        public string @PrimaryAccessKey { get; }

        [nterraform.Core.TerraformProperty(name: "secondary_access_key", @out: true, min: 0, max: 1)]
        public string @SecondaryAccessKey { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
