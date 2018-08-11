using System.Collections.Generic;

namespace NTerraform.Datas
{
    public class consul_agent_config : NTerraform.data
    {
        public consul_agent_config()
        {
        }

        public string @Datacenter { get; }
        public string @NodeId { get; }
        public string @NodeName { get; }
        public string @Revision { get; }
        public bool? @Server { get; }
        public string @Version { get; }
    }

}
