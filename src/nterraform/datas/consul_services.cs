using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "consul_services")]
    public sealed class consul_services : nterraform.Core.data
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

        [nterraform.Core.TerraformStructure(category: "data", typeName: "services")]
        public sealed class services : nterraform.Core.structure
        {
            public services()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
            public FSharpOption<FSharpList<string>> @Tags { get; }
        }

        public consul_services(FSharpOption<FSharpList<query_options>> @queryOptions = null,
                               FSharpOption<FSharpMap<string,services>> @services = null)
        {
            @QueryOptions = @queryOptions ?? FSharpList<query_options>.Empty;
            @Services = @services ?? MapModule.Empty<string,services>();
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "datacenter", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Datacenter { get; }

        [nterraform.Core.TerraformProperty(name: "names", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpList<string>> @Names { get; }

        [nterraform.Core.TerraformProperty(name: "query_options", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpList<query_options>> @QueryOptions { get; }

        [nterraform.Core.TerraformProperty(name: "services", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpMap<string,services>> @Services { get; }
    }

}
