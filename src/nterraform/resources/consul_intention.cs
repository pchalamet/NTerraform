using System.Collections.Generic;

namespace nterraform.resources.consul
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "consul_intention")]
    public sealed class consul_intention : nterraform.Core.resource
    {
        public consul_intention(string @action,
                                string @destinationName,
                                string @sourceName,
                                string @description = null,
                                Dictionary<string,string> @meta = null)
        {
            @Action = @action;
            @DestinationName = @destinationName;
            @SourceName = @sourceName;
            @Description = @description;
            @Meta = @meta;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "action", @out: false, min: 1, max: 1)]
        public string @Action { get; }

        [nterraform.Core.TerraformProperty(name: "destination_name", @out: false, min: 1, max: 1)]
        public string @DestinationName { get; }

        [nterraform.Core.TerraformProperty(name: "source_name", @out: false, min: 1, max: 1)]
        public string @SourceName { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "meta", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Meta { get; }
    }

}