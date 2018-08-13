using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_db_option_group")]
    public sealed class aws_db_option_group : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "option")]
        public sealed class option : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "option_settings")]
            public sealed class option_settings : nterraform.Core.structure
            {
                public option_settings(string @name,
                                       string @value)
                {
                    @Name = @name;
                    @Value = @value;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
                public string @Name { get; }

                [nterraform.Core.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
                public string @Value { get; }
            }

            public option(string @optionName,
                          string[] @dbSecurityGroupMemberships = null,
                          option_settings[] @optionSettings = null,
                          int? @port = null,
                          string @version = null,
                          string[] @vpcSecurityGroupMemberships = null)
            {
                @OptionName = @optionName;
                @DbSecurityGroupMemberships = @dbSecurityGroupMemberships;
                @OptionSettings = @optionSettings;
                @Port = @port;
                @Version = @version;
                @VpcSecurityGroupMemberships = @vpcSecurityGroupMemberships;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "option_name", @out: false, min: 1, max: 1)]
            public string @OptionName { get; }

            [nterraform.Core.TerraformProperty(name: "db_security_group_memberships", @out: false, min: 0, max: 1)]
            public string[] @DbSecurityGroupMemberships { get; }

            [nterraform.Core.TerraformProperty(name: "option_settings", @out: false, min: 0, max: 0)]
            public option_settings[] @OptionSettings { get; }

            [nterraform.Core.TerraformProperty(name: "port", @out: false, min: 0, max: 1)]
            public int? @Port { get; }

            [nterraform.Core.TerraformProperty(name: "version", @out: false, min: 0, max: 1)]
            public string @Version { get; }

            [nterraform.Core.TerraformProperty(name: "vpc_security_group_memberships", @out: false, min: 0, max: 1)]
            public string[] @VpcSecurityGroupMemberships { get; }
        }

        public aws_db_option_group(string @engineName,
                                   string @majorEngineVersion,
                                   option[] @option = null,
                                   string @optionGroupDescription = null,
                                   Dictionary<string,string> @tags = null)
        {
            @EngineName = @engineName;
            @MajorEngineVersion = @majorEngineVersion;
            @Option = @option;
            @OptionGroupDescription = @optionGroupDescription;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "engine_name", @out: false, min: 1, max: 1)]
        public string @EngineName { get; }

        [nterraform.Core.TerraformProperty(name: "major_engine_version", @out: false, min: 1, max: 1)]
        public string @MajorEngineVersion { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "name_prefix", @out: true, min: 0, max: 1)]
        public string @NamePrefix { get; }

        [nterraform.Core.TerraformProperty(name: "option", @out: false, min: 0, max: 0)]
        public option[] @Option { get; }

        [nterraform.Core.TerraformProperty(name: "option_group_description", @out: false, min: 0, max: 1)]
        public string @OptionGroupDescription { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
