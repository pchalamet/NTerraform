using Microsoft.FSharp.Collections;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "consul_service")]
    public sealed class consul_service : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "query_options")]
        public sealed class query_options : nterraform.Core.structure
        {
            public query_options(bool? @allowStale = null,
                                 string @datacenter = null,
                                 string @near = null,
                                 FSharpMap<string,string> @nodeMeta = null,
                                 bool? @requireConsistent = null,
                                 string @token = null,
                                 int? @waitIndex = null,
                                 string @waitTime = null)
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
            public bool? @AllowStale { get; }

            [nterraform.Core.TerraformProperty(name: "datacenter", @out: false, min: 0, max: 1)]
            public string @Datacenter { get; }

            [nterraform.Core.TerraformProperty(name: "near", @out: false, min: 0, max: 1)]
            public string @Near { get; }

            [nterraform.Core.TerraformProperty(name: "node_meta", @out: false, min: 0, max: 1)]
            public FSharpMap<string,string> @NodeMeta { get; }

            [nterraform.Core.TerraformProperty(name: "require_consistent", @out: false, min: 0, max: 1)]
            public bool? @RequireConsistent { get; }

            [nterraform.Core.TerraformProperty(name: "token", @out: false, min: 0, max: 1)]
            public string @Token { get; }

            [nterraform.Core.TerraformProperty(name: "wait_index", @out: false, min: 0, max: 1)]
            public int? @WaitIndex { get; }

            [nterraform.Core.TerraformProperty(name: "wait_time", @out: false, min: 0, max: 1)]
            public string @WaitTime { get; }
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
                public string @Lan { get; }

                [nterraform.Core.TerraformProperty(name: "wan", @out: true, min: 0, max: 1)]
                public string @Wan { get; }
            }

            public service(FSharpMap<string,tagged_addresses> @taggedAddresses = null)
            {
                @TaggedAddresses = @taggedAddresses ?? MapModule.Empty<string,tagged_addresses>();
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "address", @out: true, min: 0, max: 1)]
            public string @Address { get; }

            [nterraform.Core.TerraformProperty(name: "create_index", @out: true, min: 0, max: 1)]
            public string @CreateIndex { get; }

            [nterraform.Core.TerraformProperty(name: "enable_tag_override", @out: true, min: 0, max: 1)]
            public string @EnableTagOverride { get; }

            [nterraform.Core.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }

            [nterraform.Core.TerraformProperty(name: "modify_index", @out: true, min: 0, max: 1)]
            public string @ModifyIndex { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "node_address", @out: true, min: 0, max: 1)]
            public string @NodeAddress { get; }

            [nterraform.Core.TerraformProperty(name: "node_id", @out: true, min: 0, max: 1)]
            public string @NodeId { get; }

            [nterraform.Core.TerraformProperty(name: "node_meta", @out: true, min: 0, max: 1)]
            public FSharpMap<string,string> @NodeMeta { get; }

            [nterraform.Core.TerraformProperty(name: "node_name", @out: true, min: 0, max: 1)]
            public string @NodeName { get; }

            [nterraform.Core.TerraformProperty(name: "port", @out: true, min: 0, max: 1)]
            public string @Port { get; }

            [nterraform.Core.TerraformProperty(name: "tagged_addresses", @out: false, min: 0, max: 0)]
            public FSharpMap<string,tagged_addresses> @TaggedAddresses { get; }

            [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
            public FSharpList<string> @Tags { get; }
        }

        public consul_service(string @name,
                              string @datacenter = null,
                              FSharpList<query_options> @queryOptions = null,
                              FSharpList<service> @service = null,
                              string @tag = null)
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
        public string @Datacenter { get; }

        [nterraform.Core.TerraformProperty(name: "query_options", @out: false, min: 0, max: 0)]
        public FSharpList<query_options> @QueryOptions { get; }

        [nterraform.Core.TerraformProperty(name: "service", @out: false, min: 0, max: 0)]
        public FSharpList<service> @Service { get; }

        [nterraform.Core.TerraformProperty(name: "tag", @out: false, min: 0, max: 1)]
        public string @Tag { get; }
    }

}
