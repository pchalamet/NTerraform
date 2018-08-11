using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class consul_service : NTerraform.resource
    {
        public consul_service(string @name,
                              string @node,
                              int? @port = null,
                              string[] @tags = null)
        {
            @Name = @name;
            @Node = @node;
            @Port = @port;
            @Tags = @tags;
        }

        public string @Name { get; }
        public string @Node { get; }
        public string @Address { get; }
        public string @Datacenter { get; }
        public int? @Port { get; }
        public string @ServiceId { get; }
        public string[] @Tags { get; }
    }

}
