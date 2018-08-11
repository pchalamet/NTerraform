using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "consul_services")]
    public sealed class consul_services : NTerraform.data
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

        [TerraformStructure(category: "", typeName: "services")]
        public sealed class services: NTerraform.structure
        {
            public services()
            {
                base._validate_();
            }

            [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
            public string[] @Tags { get; }
        }

        public consul_services(query_options[] @queryOptions = null,
                               Dictionary<string,services> @services = null)
        {
            @QueryOptions = @queryOptions;
            @Services = @services;
            base._validate_();
        }

        [TerraformProperty(name: "datacenter", @out: true, min: 0, max: 1)]
        public string @Datacenter { get; }

        [TerraformProperty(name: "names", @out: true, min: 0, max: 1)]
        public string[] @Names { get; }

        [TerraformProperty(name: "query_options", @out: false, min: 0, max: 0)]
        public query_options[] @QueryOptions { get; }

        [TerraformProperty(name: "services", @out: false, min: 0, max: 0)]
        public Dictionary<string,services> @Services { get; }
    }

}
