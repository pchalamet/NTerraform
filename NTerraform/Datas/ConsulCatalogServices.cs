using System.Collections.Generic;

namespace NTerraform.Datas
{
    public sealed class consul_catalog_services : NTerraform.data
    {
        public sealed class services
        {
            public services()
            {
            }

            public string[] @Tags { get; }
        }

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

            public bool? @AllowStale { get; }
            public string @Datacenter { get; }
            public string @Near { get; }
            public Dictionary<string,string> @NodeMeta { get; }
            public bool? @RequireConsistent { get; }
            public string @Token { get; }
            public int? @WaitIndex { get; }
            public string @WaitTime { get; }
        }

        public consul_catalog_services(query_options[] @queryOptions = null,
                                       Dictionary<string,services> @services = null)
        {
            @QueryOptions = @queryOptions;
            @Services = @services;
        }

        public string @Datacenter { get; }
        public string[] @Names { get; }
        public query_options[] @QueryOptions { get; }
        public Dictionary<string,services> @Services { get; }
    }

}
