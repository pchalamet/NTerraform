using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "consul_catalog_nodes")]
    public sealed class consul_catalog_nodes : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "query_options")]
        public sealed class query_options : nterraform.Core.structure
        {
            public query_options(FSharpOption<bool> @allowStale = null,
                                 FSharpOption<string> @datacenter = null,
                                 FSharpOption<string> @near = null,
                                 FSharpOption<FSharpMap<string,string>> @nodeMeta = null,
                                 FSharpOption<bool> @requireConsistent = null,
                                 FSharpOption<string> @token = null,
                                 FSharpOption<int> @waitIndex = null,
                                 FSharpOption<string> @waitTime = null)
            {
                @AllowStale = @allowStale;
                @Datacenter = @datacenter;
                @Near = @near;
                @NodeMeta = @nodeMeta ?? MapModule.Empty<string,string>();
                @RequireConsistent = @requireConsistent;
                @Token = @token;
                @WaitIndex = @waitIndex;
                @WaitTime = @waitTime;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "allow_stale", @out: false, min: 0, max: 1)]
            public FSharpOption<bool> @AllowStale { get; }

            [nterraform.Core.TerraformProperty(name: "datacenter", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @Datacenter { get; }

            [nterraform.Core.TerraformProperty(name: "near", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @Near { get; }

            [nterraform.Core.TerraformProperty(name: "node_meta", @out: false, min: 0, max: 1)]
            public FSharpOption<FSharpMap<string,string>> @NodeMeta { get; }

            [nterraform.Core.TerraformProperty(name: "require_consistent", @out: false, min: 0, max: 1)]
            public FSharpOption<bool> @RequireConsistent { get; }

            [nterraform.Core.TerraformProperty(name: "token", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @Token { get; }

            [nterraform.Core.TerraformProperty(name: "wait_index", @out: false, min: 0, max: 1)]
            public FSharpOption<int> @WaitIndex { get; }

            [nterraform.Core.TerraformProperty(name: "wait_time", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @WaitTime { get; }
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
                public FSharpOption<string> @Lan { get; }

                [nterraform.Core.TerraformProperty(name: "wan", @out: true, min: 0, max: 1)]
                public FSharpOption<string> @Wan { get; }
            }

            public nodes(FSharpOption<FSharpMap<string,tagged_addresses>> @taggedAddresses = null)
            {
                @TaggedAddresses = @taggedAddresses ?? MapModule.Empty<string,tagged_addresses>();
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "address", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Address { get; }

            [nterraform.Core.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Id { get; }

            [nterraform.Core.TerraformProperty(name: "meta", @out: true, min: 0, max: 1)]
            public FSharpOption<FSharpMap<string,string>> @Meta { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Name { get; }

            [nterraform.Core.TerraformProperty(name: "tagged_addresses", @out: false, min: 0, max: 0)]
            public FSharpOption<FSharpMap<string,tagged_addresses>> @TaggedAddresses { get; }
        }

        public consul_catalog_nodes(FSharpOption<FSharpList<nodes>> @nodes = null,
                                    FSharpOption<FSharpList<query_options>> @queryOptions = null)
        {
            @Nodes = @nodes ?? FSharpList<nodes>.Empty;
            @QueryOptions = @queryOptions ?? FSharpList<query_options>.Empty;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "datacenter", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Datacenter { get; }

        [nterraform.Core.TerraformProperty(name: "node_ids", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpList<string>> @NodeIds { get; }

        [nterraform.Core.TerraformProperty(name: "node_names", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpList<string>> @NodeNames { get; }

        [nterraform.Core.TerraformProperty(name: "nodes", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpList<nodes>> @Nodes { get; }

        [nterraform.Core.TerraformProperty(name: "query_options", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpList<query_options>> @QueryOptions { get; }
    }

}
