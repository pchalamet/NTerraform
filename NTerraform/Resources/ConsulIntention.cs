using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class consul_intention : NTerraform.resource
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
        }

        public string @Action { get; }
        public string @DestinationName { get; }
        public string @SourceName { get; }
        public string @Description { get; }
        public Dictionary<string,string> @Meta { get; }
    }

}
