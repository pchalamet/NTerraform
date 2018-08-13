using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_mq_configuration")]
    public sealed class aws_mq_configuration : nterraform.resource
    {
        public aws_mq_configuration(string @data,
                                    string @engineType,
                                    string @engineVersion,
                                    string @name,
                                    string @description = null)
        {
            @Data = @data;
            @EngineType = @engineType;
            @EngineVersion = @engineVersion;
            @Name = @name;
            @Description = @description;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "data", @out: false, min: 1, max: 1)]
        public string @Data { get; }

        [nterraform.TerraformProperty(name: "engine_type", @out: false, min: 1, max: 1)]
        public string @EngineType { get; }

        [nterraform.TerraformProperty(name: "engine_version", @out: false, min: 1, max: 1)]
        public string @EngineVersion { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "latest_revision", @out: true, min: 0, max: 1)]
        public int? @LatestRevision { get; }
    }

}
