using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "consul_catalog_services")]
    public sealed class consul_catalog_services : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "services")]
        public sealed class services : nterraform.structure
        {
            public services()
            {
                base._validate_();
            }

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

        public consul_catalog_services(query_options[] @queryOptions = null,
                                       Dictionary<string,services> @services = null)
        {
            @QueryOptions = @queryOptions;
            @Services = @services;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "datacenter", @out: true, min: 0, max: 1)]
        public string @Datacenter { get; }

        [nterraform.TerraformProperty(name: "names", @out: true, min: 0, max: 1)]
        public string[] @Names { get; }

        [nterraform.TerraformProperty(name: "query_options", @out: false, min: 0, max: 0)]
        public query_options[] @QueryOptions { get; }

        [nterraform.TerraformProperty(name: "services", @out: false, min: 0, max: 0)]
        public Dictionary<string,services> @Services { get; }
    }

}
