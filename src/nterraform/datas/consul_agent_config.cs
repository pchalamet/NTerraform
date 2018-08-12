using System.Collections.Generic;

namespace nterraform.datas.consul
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "consul_agent_config")]
    public sealed class consul_agent_config : nterraform.Core.data
    {
        public consul_agent_config()
        {
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "datacenter", @out: true, min: 0, max: 1)]
        public string @Datacenter { get; }

        [nterraform.Core.TerraformProperty(name: "node_id", @out: true, min: 0, max: 1)]
        public string @NodeId { get; }

        [nterraform.Core.TerraformProperty(name: "node_name", @out: true, min: 0, max: 1)]
        public string @NodeName { get; }

        [nterraform.Core.TerraformProperty(name: "revision", @out: true, min: 0, max: 1)]
        public string @Revision { get; }

        [nterraform.Core.TerraformProperty(name: "server", @out: true, min: 0, max: 1)]
        public bool? @Server { get; }

        [nterraform.Core.TerraformProperty(name: "version", @out: true, min: 0, max: 1)]
        public string @Version { get; }
    }

}
