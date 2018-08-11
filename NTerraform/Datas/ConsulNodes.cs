using System.Collections.Generic;

namespace NTerraform.Datas
{
    public class consul_nodes : NTerraform.data
    {
        public class nodes
        {
            public class tagged_addresses
            {
                public tagged_addresses()
                {
                }

                public string @Lan { get; }
                public string @Wan { get; }
            }

            public nodes(Dictionary<string,tagged_addresses> @taggedAddresses = null)
            {
                @TaggedAddresses = @taggedAddresses;
            }

            public string @Address { get; }
            public string @Id { get; }
            public Dictionary<string,string> @Meta { get; }
            public string @Name { get; }
            public Dictionary<string,tagged_addresses> @TaggedAddresses { get; }
        }

        public class query_options
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

        public consul_nodes(nodes[] @nodes = null,
                            query_options[] @queryOptions = null)
        {
            @Nodes = @nodes;
            @QueryOptions = @queryOptions;
        }

        public string @Datacenter { get; }
        public string[] @NodeIds { get; }
        public string[] @NodeNames { get; }
        public nodes[] @Nodes { get; }
        public query_options[] @QueryOptions { get; }
    }

}
