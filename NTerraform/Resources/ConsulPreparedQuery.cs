using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class consul_prepared_query : NTerraform.resource
    {
        public sealed class dns
        {
            public dns(string @ttl = null)
            {
                @Ttl = @ttl;
            }

            public string @Ttl { get; }
        }

        public sealed class template
        {
            public template(string @regexp,
                            string @type)
            {
                @Regexp = @regexp;
                @Type = @type;
            }

            public string @Regexp { get; }
            public string @Type { get; }
        }

        public sealed class failover
        {
            public failover(string[] @datacenters = null,
                            int? @nearestN = null)
            {
                @Datacenters = @datacenters;
                @NearestN = @nearestN;
            }

            public string[] @Datacenters { get; }
            public int? @NearestN { get; }
        }

        public consul_prepared_query(string @name,
                                     string @service,
                                     string @datacenter = null,
                                     dns[] @dns = null,
                                     failover[] @failover = null,
                                     string @near = null,
                                     bool? @onlyPassing = null,
                                     string @session = null,
                                     string @storedToken = null,
                                     string[] @tags = null,
                                     template[] @template = null,
                                     string @token = null)
        {
            @Name = @name;
            @Service = @service;
            @Datacenter = @datacenter;
            @Dns = @dns;
            @Failover = @failover;
            @Near = @near;
            @OnlyPassing = @onlyPassing;
            @Session = @session;
            @StoredToken = @storedToken;
            @Tags = @tags;
            @Template = @template;
            @Token = @token;
        }

        public string @Name { get; }
        public string @Service { get; }
        public string @Datacenter { get; }
        public dns[] @Dns { get; }
        public failover[] @Failover { get; }
        public string @Near { get; }
        public bool? @OnlyPassing { get; }
        public string @Session { get; }
        public string @StoredToken { get; }
        public string[] @Tags { get; }
        public template[] @Template { get; }
        public string @Token { get; }
    }

}
