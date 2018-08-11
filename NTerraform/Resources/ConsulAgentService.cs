using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class consul_agent_service : NTerraform.resource
    {
        public consul_agent_service(string @name,
                                    int? @port = null,
                                    string[] @tags = null)
        {
            @Name = @name;
            @Port = @port;
            @Tags = @tags;
        }

        public string @Name { get; }
        public string @Address { get; }
        public int? @Port { get; }
        public string[] @Tags { get; }
    }

}
