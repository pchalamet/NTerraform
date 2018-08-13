using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_media_store_container_policy")]
    public sealed class aws_media_store_container_policy : nterraform.resource
    {
        public aws_media_store_container_policy(string @containerName,
                                                string @policy)
        {
            @ContainerName = @containerName;
            @Policy = @policy;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "container_name", @out: false, min: 1, max: 1)]
        public string @ContainerName { get; }

        [nterraform.TerraformProperty(name: "policy", @out: false, min: 1, max: 1)]
        public string @Policy { get; }
    }

}
