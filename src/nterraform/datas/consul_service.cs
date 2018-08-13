using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "consul_service")]
    public sealed class consul_service : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "service")]
        public sealed class service : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "data", typeName: "tagged_addresses")]
            public sealed class tagged_addresses : nterraform.structure
            {
                public tagged_addresses()
                {
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "lan", @out: true, min: 0, max: 1)]
                public string @Lan { get; }

                [nterraform.TerraformProperty(name: "wan", @out: true, min: 0, max: 1)]
                public string @Wan { get; }
            }

            public service(Dictionary<string,tagged_addresses> @taggedAddresses = null)
            {
                @TaggedAddresses = @taggedAddresses;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "address", @out: true, min: 0, max: 1)]
            public string @Address { get; }

            [nterraform.TerraformProperty(name: "create_index", @out: true, min: 0, max: 1)]
            public string @CreateIndex { get; }

            [nterraform.TerraformProperty(name: "enable_tag_override", @out: true, min: 0, max: 1)]
            public string @EnableTagOverride { get; }

            [nterraform.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }

            [nterraform.TerraformProperty(name: "modify_index", @out: true, min: 0, max: 1)]
            public string @ModifyIndex { get; }

            [nterraform.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "node_address", @out: true, min: 0, max: 1)]
            public string @NodeAddress { get; }

            [nterraform.TerraformProperty(name: "node_id", @out: true, min: 0, max: 1)]
            public string @NodeId { get; }

            [nterraform.TerraformProperty(name: "node_meta", @out: true, min: 0, max: 1)]
            public Dictionary<string,string> @NodeMeta { get; }

            [nterraform.TerraformProperty(name: "node_name", @out: true, min: 0, max: 1)]
            public string @NodeName { get; }

            [nterraform.TerraformProperty(name: "port", @out: true, min: 0, max: 1)]
            public string @Port { get; }

            [nterraform.TerraformProperty(name: "tagged_addresses", @out: false, min: 0, max: 0)]
            public Dictionary<string,tagged_addresses> @TaggedAddresses { get; }

            [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
            public string[] @Tags { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "query_options")]
        public sealed class query_options : nterraform.structure
        {
            public query_options(bool? @allowStale = null,
                                 string @datacenter = null,
                                 string @near = null,
                                 Dictionary<string,string> @nodeMeta = null,
                                 bool? @requireConsistent = null,
                                 string @token = null,
                                 int? @waitIndex = null,
                                 string @waitTime = null)
            {
                @AllowStale = @allowStale;
                @Datacenter = @datacenter;
                @Near = @near;
                @NodeMeta = @nodeMeta;
                @RequireConsistent = @requireConsistent;
                @Token = @token;
                @WaitIndex = @waitIndex;
                @WaitTime = @waitTime;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "allow_stale", @out: false, min: 0, max: 1)]
            public bool? @AllowStale { get; }

            [nterraform.TerraformProperty(name: "datacenter", @out: false, min: 0, max: 1)]
            public string @Datacenter { get; }

            [nterraform.TerraformProperty(name: "near", @out: false, min: 0, max: 1)]
            public string @Near { get; }

            [nterraform.TerraformProperty(name: "node_meta", @out: false, min: 0, max: 1)]
            public Dictionary<string,string> @NodeMeta { get; }

            [nterraform.TerraformProperty(name: "require_consistent", @out: false, min: 0, max: 1)]
            public bool? @RequireConsistent { get; }

            [nterraform.TerraformProperty(name: "token", @out: false, min: 0, max: 1)]
            public string @Token { get; }

            [nterraform.TerraformProperty(name: "wait_index", @out: false, min: 0, max: 1)]
            public int? @WaitIndex { get; }

            [nterraform.TerraformProperty(name: "wait_time", @out: false, min: 0, max: 1)]
            public string @WaitTime { get; }
        }

        public consul_service(string @name,
                              string @datacenter = null,
                              query_options[] @queryOptions = null,
                              service[] @service = null,
                              string @tag = null)
        {
            @Name = @name;
            @Datacenter = @datacenter;
            @QueryOptions = @queryOptions;
            @Service = @service;
            @Tag = @tag;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "datacenter", @out: false, min: 0, max: 1)]
        public string @Datacenter { get; }

        [nterraform.TerraformProperty(name: "query_options", @out: false, min: 0, max: 0)]
        public query_options[] @QueryOptions { get; }

        [nterraform.TerraformProperty(name: "service", @out: false, min: 0, max: 0)]
        public service[] @Service { get; }

        [nterraform.TerraformProperty(name: "tag", @out: false, min: 0, max: 1)]
        public string @Tag { get; }
    }

}
