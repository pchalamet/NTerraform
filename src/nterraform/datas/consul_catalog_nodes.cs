using System.Collections.Generic;

namespace nterraform.datas.consul
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "consul_catalog_nodes")]
    public sealed class consul_catalog_nodes : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "query_options")]
        public sealed class query_options : nterraform.Core.structure
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

            [nterraform.Core.TerraformProperty(name: "allow_stale", @out: false, min: 0, max: 1)]
            public bool? @AllowStale { get; }

            [nterraform.Core.TerraformProperty(name: "datacenter", @out: false, min: 0, max: 1)]
            public string @Datacenter { get; }

            [nterraform.Core.TerraformProperty(name: "near", @out: false, min: 0, max: 1)]
            public string @Near { get; }

            [nterraform.Core.TerraformProperty(name: "node_meta", @out: false, min: 0, max: 1)]
            public Dictionary<string,string> @NodeMeta { get; }

            [nterraform.Core.TerraformProperty(name: "require_consistent", @out: false, min: 0, max: 1)]
            public bool? @RequireConsistent { get; }

            [nterraform.Core.TerraformProperty(name: "token", @out: false, min: 0, max: 1)]
            public string @Token { get; }

            [nterraform.Core.TerraformProperty(name: "wait_index", @out: false, min: 0, max: 1)]
            public int? @WaitIndex { get; }

            [nterraform.Core.TerraformProperty(name: "wait_time", @out: false, min: 0, max: 1)]
            public string @WaitTime { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "nodes")]
        public sealed class nodes : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "data", typeName: "tagged_addresses")]
            public sealed class tagged_addresses : nterraform.Core.structure
            {
                public tagged_addresses()
                {
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "lan", @out: true, min: 0, max: 1)]
                public string @Lan { get; }

                [nterraform.Core.TerraformProperty(name: "wan", @out: true, min: 0, max: 1)]
                public string @Wan { get; }
            }

            public nodes(Dictionary<string,tagged_addresses> @taggedAddresses = null)
            {
                @TaggedAddresses = @taggedAddresses;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "address", @out: true, min: 0, max: 1)]
            public string @Address { get; }

            [nterraform.Core.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }

            [nterraform.Core.TerraformProperty(name: "meta", @out: true, min: 0, max: 1)]
            public Dictionary<string,string> @Meta { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "tagged_addresses", @out: false, min: 0, max: 0)]
            public Dictionary<string,tagged_addresses> @TaggedAddresses { get; }
        }

        public consul_catalog_nodes(nodes[] @nodes = null,
                                    query_options[] @queryOptions = null)
        {
            @Nodes = @nodes;
            @QueryOptions = @queryOptions;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "datacenter", @out: true, min: 0, max: 1)]
        public string @Datacenter { get; }

        [nterraform.Core.TerraformProperty(name: "node_ids", @out: true, min: 0, max: 1)]
        public string[] @NodeIds { get; }

        [nterraform.Core.TerraformProperty(name: "node_names", @out: true, min: 0, max: 1)]
        public string[] @NodeNames { get; }

        [nterraform.Core.TerraformProperty(name: "nodes", @out: false, min: 0, max: 0)]
        public nodes[] @Nodes { get; }

        [nterraform.Core.TerraformProperty(name: "query_options", @out: false, min: 0, max: 0)]
        public query_options[] @QueryOptions { get; }
    }

}
