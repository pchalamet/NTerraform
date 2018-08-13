using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_config_configuration_recorder")]
    public sealed class aws_config_configuration_recorder : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "recording_group")]
        public sealed class recording_group : nterraform.structure
        {
            public recording_group(bool? @allSupported = null,
                                   bool? @includeGlobalResourceTypes = null,
                                   string[] @resourceTypes = null)
            {
                @AllSupported = @allSupported;
                @IncludeGlobalResourceTypes = @includeGlobalResourceTypes;
                @ResourceTypes = @resourceTypes;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "all_supported", @out: false, min: 0, max: 1)]
            public bool? @AllSupported { get; }

            [nterraform.TerraformProperty(name: "include_global_resource_types", @out: false, min: 0, max: 1)]
            public bool? @IncludeGlobalResourceTypes { get; }

            [nterraform.TerraformProperty(name: "resource_types", @out: false, min: 0, max: 1)]
            public string[] @ResourceTypes { get; }
        }

        public aws_config_configuration_recorder(string @roleArn,
                                                 string @name = null,
                                                 recording_group[] @recordingGroup = null)
        {
            @RoleArn = @roleArn;
            @Name = @name;
            @RecordingGroup = @recordingGroup;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
        public string @RoleArn { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "recording_group", @out: false, min: 0, max: 1)]
        public recording_group[] @RecordingGroup { get; }
    }

}
