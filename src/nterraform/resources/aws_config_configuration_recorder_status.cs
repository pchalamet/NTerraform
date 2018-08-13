using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_config_configuration_recorder_status")]
    public sealed class aws_config_configuration_recorder_status : nterraform.resource
    {
        public aws_config_configuration_recorder_status(bool @isEnabled,
                                                        string @name)
        {
            @IsEnabled = @isEnabled;
            @Name = @name;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "is_enabled", @out: false, min: 1, max: 1)]
        public bool @IsEnabled { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }
    }

}
