using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_mq_configuration")]
    public sealed class aws_mq_configuration : nterraform.Core.resource
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

        [nterraform.Core.TerraformProperty(name: "data", @out: false, min: 1, max: 1)]
        public string @Data { get; }

        [nterraform.Core.TerraformProperty(name: "engine_type", @out: false, min: 1, max: 1)]
        public string @EngineType { get; }

        [nterraform.Core.TerraformProperty(name: "engine_version", @out: false, min: 1, max: 1)]
        public string @EngineVersion { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "latest_revision", @out: true, min: 0, max: 1)]
        public int? @LatestRevision { get; }
    }

}
