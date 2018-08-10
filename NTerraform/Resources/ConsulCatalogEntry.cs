using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class consul_catalog_entry : NTerraform.resource
    {
        public class service
        {
            public service(string @name,
                           string @address = null,
                           int? @port = null,
                           HashSet<string> @tags = null)
            {
                @Name = @name;
                @Address = @address;
                @Port = @port;
                @Tags = @tags;
            }

            public string @Name { get; }
            public string @Address { get; }
            public string @Id { get; }
            public int? @Port { get; }
            public HashSet<string> @Tags { get; }
        }

        public consul_catalog_entry(string @address,
                                    string @node,
                                    HashSet<service> @service = null,
                                    string @token = null)
        {
            @Address = @address;
            @Node = @node;
            @Service = @service;
            @Token = @token;
        }

        public string @Address { get; }
        public string @Node { get; }
        public string @Datacenter { get; }
        public HashSet<service> @Service { get; }
        public string @Token { get; }
    }

}
