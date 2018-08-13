using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "consul_agent_config")]
    public sealed class consul_agent_config : nterraform.data
    {
        public consul_agent_config()
        {
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "datacenter", @out: true, min: 0, max: 1)]
        public string @Datacenter { get; }

        [nterraform.TerraformProperty(name: "node_id", @out: true, min: 0, max: 1)]
        public string @NodeId { get; }

        [nterraform.TerraformProperty(name: "node_name", @out: true, min: 0, max: 1)]
        public string @NodeName { get; }

        [nterraform.TerraformProperty(name: "revision", @out: true, min: 0, max: 1)]
        public string @Revision { get; }

        [nterraform.TerraformProperty(name: "server", @out: true, min: 0, max: 1)]
        public bool? @Server { get; }

        [nterraform.TerraformProperty(name: "version", @out: true, min: 0, max: 1)]
        public string @Version { get; }
    }

}
