using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_config_configuration_recorder_status")]
    public sealed class aws_config_configuration_recorder_status : nterraform.Core.resource
    {
        public aws_config_configuration_recorder_status(bool @isEnabled,
                                                        string @name)
        {
            @IsEnabled = @isEnabled;
            @Name = @name;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "is_enabled", @out: false, min: 1, max: 1)]
        public bool @IsEnabled { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }
    }

}
