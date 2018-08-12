using System.Collections.Generic;

namespace nterraform.datas.consul
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "consul_catalog_services")]
    public sealed class consul_catalog_services : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "services")]
        public sealed class services : nterraform.Core.structure
        {
            public services()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
            public string[] @Tags { get; }
        }

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

        public consul_catalog_services(query_options[] @queryOptions = null,
                                       Dictionary<string,services> @services = null)
        {
            @QueryOptions = @queryOptions;
            @Services = @services;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "datacenter", @out: true, min: 0, max: 1)]
        public string @Datacenter { get; }

        [nterraform.Core.TerraformProperty(name: "names", @out: true, min: 0, max: 1)]
        public string[] @Names { get; }

        [nterraform.Core.TerraformProperty(name: "query_options", @out: false, min: 0, max: 0)]
        public query_options[] @QueryOptions { get; }

        [nterraform.Core.TerraformProperty(name: "services", @out: false, min: 0, max: 0)]
        public Dictionary<string,services> @Services { get; }
    }

}
