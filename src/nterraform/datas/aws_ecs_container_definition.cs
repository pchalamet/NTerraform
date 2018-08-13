using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_ecs_container_definition")]
    public sealed class aws_ecs_container_definition : nterraform.data
    {
        public aws_ecs_container_definition(string @containerName,
                                            string @taskDefinition)
        {
            @ContainerName = @containerName;
            @TaskDefinition = @taskDefinition;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "container_name", @out: false, min: 1, max: 1)]
        public string @ContainerName { get; }

        [nterraform.TerraformProperty(name: "task_definition", @out: false, min: 1, max: 1)]
        public string @TaskDefinition { get; }

        [nterraform.TerraformProperty(name: "cpu", @out: true, min: 0, max: 1)]
        public int? @Cpu { get; }

        [nterraform.TerraformProperty(name: "disable_networking", @out: true, min: 0, max: 1)]
        public bool? @DisableNetworking { get; }

        [nterraform.TerraformProperty(name: "docker_labels", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @DockerLabels { get; }

        [nterraform.TerraformProperty(name: "environment", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Environment { get; }

        [nterraform.TerraformProperty(name: "image", @out: true, min: 0, max: 1)]
        public string @Image { get; }

        [nterraform.TerraformProperty(name: "image_digest", @out: true, min: 0, max: 1)]
        public string @ImageDigest { get; }

        [nterraform.TerraformProperty(name: "memory", @out: true, min: 0, max: 1)]
        public int? @Memory { get; }

        [nterraform.TerraformProperty(name: "memory_reservation", @out: true, min: 0, max: 1)]
        public int? @MemoryReservation { get; }
    }

}
