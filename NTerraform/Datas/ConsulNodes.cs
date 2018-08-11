using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "consul_nodes")]
    public sealed class consul_nodes : NTerraform.data
    {
        [TerraformStructure(category: "", typeName: "nodes")]
        public sealed class nodes
        {
            [TerraformStructure(category: "", typeName: "tagged_addresses")]
            public sealed class tagged_addresses
            {
                public tagged_addresses()
                {
                }

                [TerraformProperty(name: "lan", @out: true, nested: false, min: 0, max: 1)]
                public string @Lan { get; }

                [TerraformProperty(name: "wan", @out: true, nested: false, min: 0, max: 1)]
                public string @Wan { get; }
            }

            public nodes(Dictionary<string,tagged_addresses> @taggedAddresses = null)
            {
                @TaggedAddresses = @taggedAddresses;
            }

            [TerraformProperty(name: "address", @out: true, nested: false, min: 0, max: 1)]
            public string @Address { get; }

            [TerraformProperty(name: "id", @out: true, nested: false, min: 0, max: 1)]
            public string @Id { get; }

            [TerraformProperty(name: "meta", @out: true, nested: false, min: 0, max: 1)]
            public Dictionary<string,string> @Meta { get; }

            [TerraformProperty(name: "name", @out: true, nested: false, min: 0, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "tagged_addresses", @out: false, nested: false, min: 0, max: 0)]
            public Dictionary<string,tagged_addresses> @TaggedAddresses { get; }
        }

        [TerraformStructure(category: "", typeName: "query_options")]
        public sealed class query_options
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
            }

            [TerraformProperty(name: "allow_stale", @out: false, nested: false, min: 0, max: 1)]
            public bool? @AllowStale { get; }

            [TerraformProperty(name: "datacenter", @out: false, nested: false, min: 0, max: 1)]
            public string @Datacenter { get; }

            [TerraformProperty(name: "near", @out: false, nested: false, min: 0, max: 1)]
            public string @Near { get; }

            [TerraformProperty(name: "node_meta", @out: false, nested: false, min: 0, max: 1)]
            public Dictionary<string,string> @NodeMeta { get; }

            [TerraformProperty(name: "require_consistent", @out: false, nested: false, min: 0, max: 1)]
            public bool? @RequireConsistent { get; }

            [TerraformProperty(name: "token", @out: false, nested: false, min: 0, max: 1)]
            public string @Token { get; }

            [TerraformProperty(name: "wait_index", @out: false, nested: false, min: 0, max: 1)]
            public int? @WaitIndex { get; }

            [TerraformProperty(name: "wait_time", @out: false, nested: false, min: 0, max: 1)]
            public string @WaitTime { get; }
        }

        public consul_nodes(nodes[] @nodes = null,
                            query_options[] @queryOptions = null)
        {
            @Nodes = @nodes;
            @QueryOptions = @queryOptions;
        }

        [TerraformProperty(name: "datacenter", @out: true, nested: true, min: 0, max: 1)]
        public string @Datacenter { get; }

        [TerraformProperty(name: "node_ids", @out: true, nested: true, min: 0, max: 1)]
        public string[] @NodeIds { get; }

        [TerraformProperty(name: "node_names", @out: true, nested: true, min: 0, max: 1)]
        public string[] @NodeNames { get; }

        [TerraformProperty(name: "nodes", @out: false, nested: true, min: 0, max: 0)]
        public nodes[] @Nodes { get; }

        [TerraformProperty(name: "query_options", @out: false, nested: true, min: 0, max: 0)]
        public query_options[] @QueryOptions { get; }
    }

}
