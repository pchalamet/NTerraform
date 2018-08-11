using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "github_organization_webhook")]
    public sealed class github_organization_webhook : NTerraform.resource
    {
        public github_organization_webhook(string[] @events,
                                           string @name,
                                           bool? @active = null,
                                           Dictionary<string,string> @configuration = null)
        {
            @Events = @events;
            @Name = @name;
            @Active = @active;
            @Configuration = @configuration;
            base._validate_();
        }

        [TerraformProperty(name: "events", @out: false, min: 1, max: 1)]
        public string[] @Events { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "active", @out: false, min: 0, max: 1)]
        public bool? @Active { get; }

        [TerraformProperty(name: "configuration", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Configuration { get; }

        [TerraformProperty(name: "url", @out: true, min: 0, max: 1)]
        public string @Url { get; }
    }

}
