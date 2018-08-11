using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "consul_service")]
    public sealed class consul_service : NTerraform.data
    {
        [TerraformStructure(category: "", typeName: "query_options")]
        public sealed class query_options: NTerraform.structure
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

            [TerraformProperty(name: "allow_stale", @out: false, min: 0, max: 1)]
            public bool? @AllowStale { get; }

            [TerraformProperty(name: "datacenter", @out: false, min: 0, max: 1)]
            public string @Datacenter { get; }

            [TerraformProperty(name: "near", @out: false, min: 0, max: 1)]
            public string @Near { get; }

            [TerraformProperty(name: "node_meta", @out: false, min: 0, max: 1)]
            public Dictionary<string,string> @NodeMeta { get; }

            [TerraformProperty(name: "require_consistent", @out: false, min: 0, max: 1)]
            public bool? @RequireConsistent { get; }

            [TerraformProperty(name: "token", @out: false, min: 0, max: 1)]
            public string @Token { get; }

            [TerraformProperty(name: "wait_index", @out: false, min: 0, max: 1)]
            public int? @WaitIndex { get; }

            [TerraformProperty(name: "wait_time", @out: false, min: 0, max: 1)]
            public string @WaitTime { get; }
        }

        [TerraformStructure(category: "", typeName: "service")]
        public sealed class service: NTerraform.structure
        {
            [TerraformStructure(category: "", typeName: "tagged_addresses")]
            public sealed class tagged_addresses: NTerraform.structure
            {
                public tagged_addresses()
                {
                    base._validate_();
                }

                [TerraformProperty(name: "lan", @out: true, min: 0, max: 1)]
                public string @Lan { get; }

                [TerraformProperty(name: "wan", @out: true, min: 0, max: 1)]
                public string @Wan { get; }
            }

            public service(Dictionary<string,tagged_addresses> @taggedAddresses = null)
            {
                @TaggedAddresses = @taggedAddresses;
                base._validate_();
            }

            [TerraformProperty(name: "address", @out: true, min: 0, max: 1)]
            public string @Address { get; }

            [TerraformProperty(name: "create_index", @out: true, min: 0, max: 1)]
            public string @CreateIndex { get; }

            [TerraformProperty(name: "enable_tag_override", @out: true, min: 0, max: 1)]
            public string @EnableTagOverride { get; }

            [TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }

            [TerraformProperty(name: "modify_index", @out: true, min: 0, max: 1)]
            public string @ModifyIndex { get; }

            [TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "node_address", @out: true, min: 0, max: 1)]
            public string @NodeAddress { get; }

            [TerraformProperty(name: "node_id", @out: true, min: 0, max: 1)]
            public string @NodeId { get; }

            [TerraformProperty(name: "node_meta", @out: true, min: 0, max: 1)]
            public Dictionary<string,string> @NodeMeta { get; }

            [TerraformProperty(name: "node_name", @out: true, min: 0, max: 1)]
            public string @NodeName { get; }

            [TerraformProperty(name: "port", @out: true, min: 0, max: 1)]
            public string @Port { get; }

            [TerraformProperty(name: "tagged_addresses", @out: false, min: 0, max: 0)]
            public Dictionary<string,tagged_addresses> @TaggedAddresses { get; }

            [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
            public string[] @Tags { get; }
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

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "datacenter", @out: false, min: 0, max: 1)]
        public string @Datacenter { get; }

        [TerraformProperty(name: "query_options", @out: false, min: 0, max: 0)]
        public query_options[] @QueryOptions { get; }

        [TerraformProperty(name: "service", @out: false, min: 0, max: 0)]
        public service[] @Service { get; }

        [TerraformProperty(name: "tag", @out: false, min: 0, max: 1)]
        public string @Tag { get; }
    }

}
