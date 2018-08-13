using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_opsworks_stack")]
    public sealed class aws_opsworks_stack : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "custom_cookbooks_source")]
        public sealed class custom_cookbooks_source : nterraform.Core.structure
        {
            public custom_cookbooks_source(string @type,
                                           string @url,
                                           string @password = null,
                                           string @revision = null,
                                           string @sshKey = null,
                                           string @username = null)
            {
                @Type = @type;
                @Url = @url;
                @Password = @password;
                @Revision = @revision;
                @SshKey = @sshKey;
                @Username = @username;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.Core.TerraformProperty(name: "url", @out: false, min: 1, max: 1)]
            public string @Url { get; }

            [nterraform.Core.TerraformProperty(name: "password", @out: false, min: 0, max: 1)]
            public string @Password { get; }

            [nterraform.Core.TerraformProperty(name: "revision", @out: false, min: 0, max: 1)]
            public string @Revision { get; }

            [nterraform.Core.TerraformProperty(name: "ssh_key", @out: false, min: 0, max: 1)]
            public string @SshKey { get; }

            [nterraform.Core.TerraformProperty(name: "username", @out: false, min: 0, max: 1)]
            public string @Username { get; }
        }

        public aws_opsworks_stack(string @defaultInstanceProfileArn,
                                  string @name,
                                  string @region,
                                  string @serviceRoleArn,
                                  string @berkshelfVersion = null,
                                  string @color = null,
                                  string @configurationManagerName = null,
                                  string @configurationManagerVersion = null,
                                  custom_cookbooks_source[] @customCookbooksSource = null,
                                  string @customJson = null,
                                  string @defaultOs = null,
                                  string @defaultRootDeviceType = null,
                                  string @defaultSshKeyName = null,
                                  string @hostnameTheme = null,
                                  bool? @manageBerkshelf = null,
                                  Dictionary<string,string> @tags = null,
                                  bool? @useCustomCookbooks = null,
                                  bool? @useOpsworksSecurityGroups = null)
        {
            @DefaultInstanceProfileArn = @defaultInstanceProfileArn;
            @Name = @name;
            @Region = @region;
            @ServiceRoleArn = @serviceRoleArn;
            @BerkshelfVersion = @berkshelfVersion;
            @Color = @color;
            @ConfigurationManagerName = @configurationManagerName;
            @ConfigurationManagerVersion = @configurationManagerVersion;
            @CustomCookbooksSource = @customCookbooksSource;
            @CustomJson = @customJson;
            @DefaultOs = @defaultOs;
            @DefaultRootDeviceType = @defaultRootDeviceType;
            @DefaultSshKeyName = @defaultSshKeyName;
            @HostnameTheme = @hostnameTheme;
            @ManageBerkshelf = @manageBerkshelf;
            @Tags = @tags;
            @UseCustomCookbooks = @useCustomCookbooks;
            @UseOpsworksSecurityGroups = @useOpsworksSecurityGroups;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "default_instance_profile_arn", @out: false, min: 1, max: 1)]
        public string @DefaultInstanceProfileArn { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "region", @out: false, min: 1, max: 1)]
        public string @Region { get; }

        [nterraform.Core.TerraformProperty(name: "service_role_arn", @out: false, min: 1, max: 1)]
        public string @ServiceRoleArn { get; }

        [nterraform.Core.TerraformProperty(name: "agent_version", @out: true, min: 0, max: 1)]
        public string @AgentVersion { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "berkshelf_version", @out: false, min: 0, max: 1)]
        public string @BerkshelfVersion { get; }

        [nterraform.Core.TerraformProperty(name: "color", @out: false, min: 0, max: 1)]
        public string @Color { get; }

        [nterraform.Core.TerraformProperty(name: "configuration_manager_name", @out: false, min: 0, max: 1)]
        public string @ConfigurationManagerName { get; }

        [nterraform.Core.TerraformProperty(name: "configuration_manager_version", @out: false, min: 0, max: 1)]
        public string @ConfigurationManagerVersion { get; }

        [nterraform.Core.TerraformProperty(name: "custom_cookbooks_source", @out: false, min: 0, max: 0)]
        public custom_cookbooks_source[] @CustomCookbooksSource { get; }

        [nterraform.Core.TerraformProperty(name: "custom_json", @out: false, min: 0, max: 1)]
        public string @CustomJson { get; }

        [nterraform.Core.TerraformProperty(name: "default_availability_zone", @out: true, min: 0, max: 1)]
        public string @DefaultAvailabilityZone { get; }

        [nterraform.Core.TerraformProperty(name: "default_os", @out: false, min: 0, max: 1)]
        public string @DefaultOs { get; }

        [nterraform.Core.TerraformProperty(name: "default_root_device_type", @out: false, min: 0, max: 1)]
        public string @DefaultRootDeviceType { get; }

        [nterraform.Core.TerraformProperty(name: "default_ssh_key_name", @out: false, min: 0, max: 1)]
        public string @DefaultSshKeyName { get; }

        [nterraform.Core.TerraformProperty(name: "default_subnet_id", @out: true, min: 0, max: 1)]
        public string @DefaultSubnetId { get; }

        [nterraform.Core.TerraformProperty(name: "hostname_theme", @out: false, min: 0, max: 1)]
        public string @HostnameTheme { get; }

        [nterraform.Core.TerraformProperty(name: "manage_berkshelf", @out: false, min: 0, max: 1)]
        public bool? @ManageBerkshelf { get; }

        [nterraform.Core.TerraformProperty(name: "stack_endpoint", @out: true, min: 0, max: 1)]
        public string @StackEndpoint { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "use_custom_cookbooks", @out: false, min: 0, max: 1)]
        public bool? @UseCustomCookbooks { get; }

        [nterraform.Core.TerraformProperty(name: "use_opsworks_security_groups", @out: false, min: 0, max: 1)]
        public bool? @UseOpsworksSecurityGroups { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
        public string @VpcId { get; }
    }

}
