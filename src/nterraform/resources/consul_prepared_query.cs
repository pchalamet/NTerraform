using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "consul_prepared_query")]
    public sealed class consul_prepared_query : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "dns")]
        public sealed class dns : nterraform.Core.structure
        {
            public dns(string @ttl = null)
            {
                @Ttl = @ttl;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "ttl", @out: false, min: 0, max: 1)]
            public string @Ttl { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "template")]
        public sealed class template : nterraform.Core.structure
        {
            public template(string @regexp,
                            string @type)
            {
                @Regexp = @regexp;
                @Type = @type;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "regexp", @out: false, min: 1, max: 1)]
            public string @Regexp { get; }

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "failover")]
        public sealed class failover : nterraform.Core.structure
        {
            public failover(string[] @datacenters = null,
                            int? @nearestN = null)
            {
                @Datacenters = @datacenters;
                @NearestN = @nearestN;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "datacenters", @out: false, min: 0, max: 1)]
            public string[] @Datacenters { get; }

            [nterraform.Core.TerraformProperty(name: "nearest_n", @out: false, min: 0, max: 1)]
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
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "service", @out: false, min: 1, max: 1)]
        public string @Service { get; }

        [nterraform.Core.TerraformProperty(name: "datacenter", @out: false, min: 0, max: 1)]
        public string @Datacenter { get; }

        [nterraform.Core.TerraformProperty(name: "dns", @out: false, min: 0, max: 1)]
        public dns[] @Dns { get; }

        [nterraform.Core.TerraformProperty(name: "failover", @out: false, min: 0, max: 1)]
        public failover[] @Failover { get; }

        [nterraform.Core.TerraformProperty(name: "near", @out: false, min: 0, max: 1)]
        public string @Near { get; }

        [nterraform.Core.TerraformProperty(name: "only_passing", @out: false, min: 0, max: 1)]
        public bool? @OnlyPassing { get; }

        [nterraform.Core.TerraformProperty(name: "session", @out: false, min: 0, max: 1)]
        public string @Session { get; }

        [nterraform.Core.TerraformProperty(name: "stored_token", @out: false, min: 0, max: 1)]
        public string @StoredToken { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public string[] @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "template", @out: false, min: 0, max: 1)]
        public template[] @Template { get; }

        [nterraform.Core.TerraformProperty(name: "token", @out: false, min: 0, max: 1)]
        public string @Token { get; }
    }

}
