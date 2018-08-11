using System.Collections.Generic;

namespace NTerraform.Datas
{
    public class consul_catalog_service : NTerraform.data
    {
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

        public class service
        {
            public class tagged_addresses
            {
                public tagged_addresses()
                {
                }

                public string @Lan { get; }
                public string @Wan { get; }
            }

            public service(Dictionary<string,tagged_addresses> @taggedAddresses = null)
            {
                @TaggedAddresses = @taggedAddresses;
            }

            public string @Address { get; }
            public string @CreateIndex { get; }
            public string @EnableTagOverride { get; }
            public string @Id { get; }
            public string @ModifyIndex { get; }
            public string @Name { get; }
            public string @NodeAddress { get; }
            public string @NodeId { get; }
            public Dictionary<string,string> @NodeMeta { get; }
            public string @NodeName { get; }
            public string @Port { get; }
            public Dictionary<string,tagged_addresses> @TaggedAddresses { get; }
            public string[] @Tags { get; }
        }

        public consul_catalog_service(string @name,
                                      string @datacenter = null,
                                      query_options[] @queryOptions = null,
                                      service[] @service = null,
                                      string @tag = null)
        {
            @Name = @name;
            @Datacenter = @datacenter;
            @QueryOptions = @queryOptions;
            @Service = @service;
            @Tag = @tag;
        }

        public string @Name { get; }
        public string @Datacenter { get; }
        public query_options[] @QueryOptions { get; }
        public service[] @Service { get; }
        public string @Tag { get; }
    }

}
