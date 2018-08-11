using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "consul_prepared_query")]
    public sealed class consul_prepared_query : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "template")]
        public sealed class template
        {
            public template(string @regexp,
                            string @type)
            {
                @Regexp = @regexp;
                @Type = @type;
            }

            [TerraformProperty(name: "regexp", @out: false, nested: false, min: 1, max: 1)]
            public string @Regexp { get; }

            [TerraformProperty(name: "type", @out: false, nested: false, min: 1, max: 1)]
            public string @Type { get; }
        }

        [TerraformStructure(category: "", typeName: "failover")]
        public sealed class failover
        {
            public failover(string[] @datacenters = null,
                            int? @nearestN = null)
            {
                @Datacenters = @datacenters;
                @NearestN = @nearestN;
            }

            [TerraformProperty(name: "datacenters", @out: false, nested: false, min: 0, max: 1)]
            public string[] @Datacenters { get; }

            [TerraformProperty(name: "nearest_n", @out: false, nested: false, min: 0, max: 1)]
            public int? @NearestN { get; }
        }

        [TerraformStructure(category: "", typeName: "dns")]
        public sealed class dns
        {
            public dns(string @ttl = null)
            {
                @Ttl = @ttl;
            }

            [TerraformProperty(name: "ttl", @out: false, nested: false, min: 0, max: 1)]
            public string @Ttl { get; }
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

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "service", @out: false, nested: true, min: 1, max: 1)]
        public string @Service { get; }

        [TerraformProperty(name: "datacenter", @out: false, nested: true, min: 0, max: 1)]
        public string @Datacenter { get; }

        [TerraformProperty(name: "dns", @out: false, nested: true, min: 0, max: 1)]
        public dns[] @Dns { get; }

        [TerraformProperty(name: "failover", @out: false, nested: true, min: 0, max: 1)]
        public failover[] @Failover { get; }

        [TerraformProperty(name: "near", @out: false, nested: true, min: 0, max: 1)]
        public string @Near { get; }

        [TerraformProperty(name: "only_passing", @out: false, nested: true, min: 0, max: 1)]
        public bool? @OnlyPassing { get; }

        [TerraformProperty(name: "session", @out: false, nested: true, min: 0, max: 1)]
        public string @Session { get; }

        [TerraformProperty(name: "stored_token", @out: false, nested: true, min: 0, max: 1)]
        public string @StoredToken { get; }

        [TerraformProperty(name: "tags", @out: false, nested: true, min: 0, max: 1)]
        public string[] @Tags { get; }

        [TerraformProperty(name: "template", @out: false, nested: true, min: 0, max: 1)]
        public template[] @Template { get; }

        [TerraformProperty(name: "token", @out: false, nested: true, min: 0, max: 1)]
        public string @Token { get; }
    }

}
