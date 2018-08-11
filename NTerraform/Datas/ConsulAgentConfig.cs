using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "consul_agent_config")]
    public sealed class consul_agent_config : NTerraform.data
    {
        public consul_agent_config()
        {
        }

        [TerraformProperty(name: "datacenter", @out: true, min: 0, max: 1)]
        public string @Datacenter { get; }

        [TerraformProperty(name: "node_id", @out: true, min: 0, max: 1)]
        public string @NodeId { get; }

        [TerraformProperty(name: "node_name", @out: true, min: 0, max: 1)]
        public string @NodeName { get; }

        [TerraformProperty(name: "revision", @out: true, min: 0, max: 1)]
        public string @Revision { get; }

        [TerraformProperty(name: "server", @out: true, min: 0, max: 1)]
        public bool? @Server { get; }

        [TerraformProperty(name: "version", @out: true, min: 0, max: 1)]
        public string @Version { get; }
    }

}
