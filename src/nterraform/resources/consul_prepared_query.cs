using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "consul_prepared_query")]
    public sealed class consul_prepared_query : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "failover")]
        public sealed class failover : nterraform.structure
        {
            public failover(string[] @datacenters = null,
                            int? @nearestN = null)
            {
                @Datacenters = @datacenters;
                @NearestN = @nearestN;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "datacenters", @out: false, min: 0, max: 1)]
            public string[] @Datacenters { get; }

            [nterraform.TerraformProperty(name: "nearest_n", @out: false, min: 0, max: 1)]
            public int? @NearestN { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "template")]
        public sealed class template : nterraform.structure
        {
            public template(string @regexp,
                            string @type)
            {
                @Regexp = @regexp;
                @Type = @type;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "regexp", @out: false, min: 1, max: 1)]
            public string @Regexp { get; }

            [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "dns")]
        public sealed class dns : nterraform.structure
        {
            public dns(string @ttl = null)
            {
                @Ttl = @ttl;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "ttl", @out: false, min: 0, max: 1)]
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "service", @out: false, min: 1, max: 1)]
        public string @Service { get; }

        [nterraform.TerraformProperty(name: "datacenter", @out: false, min: 0, max: 1)]
        public string @Datacenter { get; }

        [nterraform.TerraformProperty(name: "dns", @out: false, min: 0, max: 1)]
        public dns[] @Dns { get; }

        [nterraform.TerraformProperty(name: "failover", @out: false, min: 0, max: 1)]
        public failover[] @Failover { get; }

        [nterraform.TerraformProperty(name: "near", @out: false, min: 0, max: 1)]
        public string @Near { get; }

        [nterraform.TerraformProperty(name: "only_passing", @out: false, min: 0, max: 1)]
        public bool? @OnlyPassing { get; }

        [nterraform.TerraformProperty(name: "session", @out: false, min: 0, max: 1)]
        public string @Session { get; }

        [nterraform.TerraformProperty(name: "stored_token", @out: false, min: 0, max: 1)]
        public string @StoredToken { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public string[] @Tags { get; }

        [nterraform.TerraformProperty(name: "template", @out: false, min: 0, max: 1)]
        public template[] @Template { get; }

        [nterraform.TerraformProperty(name: "token", @out: false, min: 0, max: 1)]
        public string @Token { get; }
    }

}
