using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_eventgrid_topic")]
    public sealed class azurerm_eventgrid_topic : nterraform.resource
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

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "endpoint", @out: true, min: 0, max: 1)]
        public string @Endpoint { get; }

        [nterraform.TerraformProperty(name: "primary_access_key", @out: true, min: 0, max: 1)]
        public string @PrimaryAccessKey { get; }

        [nterraform.TerraformProperty(name: "secondary_access_key", @out: true, min: 0, max: 1)]
        public string @SecondaryAccessKey { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
