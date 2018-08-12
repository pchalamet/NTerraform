using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "consul_service")]
    public sealed class consul_service : nterraform.Core.data
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

        [nterraform.Core.TerraformStructure(category: "data", typeName: "service")]
        public sealed class service : nterraform.Core.structure
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

            public service(FSharpOption<FSharpMap<string,tagged_addresses>> @taggedAddresses = null)
            {
                @TaggedAddresses = @taggedAddresses ?? MapModule.Empty<string,tagged_addresses>();
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "address", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Address { get; }

            [nterraform.Core.TerraformProperty(name: "create_index", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @CreateIndex { get; }

            [nterraform.Core.TerraformProperty(name: "enable_tag_override", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @EnableTagOverride { get; }

            [nterraform.Core.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Id { get; }

            [nterraform.Core.TerraformProperty(name: "modify_index", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @ModifyIndex { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Name { get; }

            [nterraform.Core.TerraformProperty(name: "node_address", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @NodeAddress { get; }

            [nterraform.Core.TerraformProperty(name: "node_id", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @NodeId { get; }

            [nterraform.Core.TerraformProperty(name: "node_meta", @out: true, min: 0, max: 1)]
            public FSharpOption<FSharpMap<string,string>> @NodeMeta { get; }

            [nterraform.Core.TerraformProperty(name: "node_name", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @NodeName { get; }

            [nterraform.Core.TerraformProperty(name: "port", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Port { get; }

            [nterraform.Core.TerraformProperty(name: "tagged_addresses", @out: false, min: 0, max: 0)]
            public FSharpOption<FSharpMap<string,tagged_addresses>> @TaggedAddresses { get; }

            [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
            public FSharpOption<FSharpList<string>> @Tags { get; }
        }

        public consul_service(string @name,
                              FSharpOption<string> @datacenter = null,
                              FSharpOption<FSharpList<query_options>> @queryOptions = null,
                              FSharpOption<FSharpList<service>> @service = null,
                              FSharpOption<string> @tag = null)
        {
            @Name = @name;
            @Datacenter = @datacenter;
            @QueryOptions = @queryOptions ?? FSharpList<query_options>.Empty;
            @Service = @service ?? FSharpList<service>.Empty;
            @Tag = @tag;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "datacenter", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @Datacenter { get; }

        [nterraform.Core.TerraformProperty(name: "query_options", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpList<query_options>> @QueryOptions { get; }

        [nterraform.Core.TerraformProperty(name: "service", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpList<service>> @Service { get; }

        [nterraform.Core.TerraformProperty(name: "tag", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @Tag { get; }
    }

}
