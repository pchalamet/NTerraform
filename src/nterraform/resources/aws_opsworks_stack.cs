using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_opsworks_stack")]
    public sealed class aws_opsworks_stack : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "custom_cookbooks_source")]
        public sealed class custom_cookbooks_source : nterraform.structure
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

            [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.TerraformProperty(name: "url", @out: false, min: 1, max: 1)]
            public string @Url { get; }

            [nterraform.TerraformProperty(name: "password", @out: false, min: 0, max: 1)]
            public string @Password { get; }

            [nterraform.TerraformProperty(name: "revision", @out: false, min: 0, max: 1)]
            public string @Revision { get; }

            [nterraform.TerraformProperty(name: "ssh_key", @out: false, min: 0, max: 1)]
            public string @SshKey { get; }

            [nterraform.TerraformProperty(name: "username", @out: false, min: 0, max: 1)]
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

        [nterraform.TerraformProperty(name: "default_instance_profile_arn", @out: false, min: 1, max: 1)]
        public string @DefaultInstanceProfileArn { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "region", @out: false, min: 1, max: 1)]
        public string @Region { get; }

        [nterraform.TerraformProperty(name: "service_role_arn", @out: false, min: 1, max: 1)]
        public string @ServiceRoleArn { get; }

        [nterraform.TerraformProperty(name: "agent_version", @out: true, min: 0, max: 1)]
        public string @AgentVersion { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "berkshelf_version", @out: false, min: 0, max: 1)]
        public string @BerkshelfVersion { get; }

        [nterraform.TerraformProperty(name: "color", @out: false, min: 0, max: 1)]
        public string @Color { get; }

        [nterraform.TerraformProperty(name: "configuration_manager_name", @out: false, min: 0, max: 1)]
        public string @ConfigurationManagerName { get; }

        [nterraform.TerraformProperty(name: "configuration_manager_version", @out: false, min: 0, max: 1)]
        public string @ConfigurationManagerVersion { get; }

        [nterraform.TerraformProperty(name: "custom_cookbooks_source", @out: false, min: 0, max: 0)]
        public custom_cookbooks_source[] @CustomCookbooksSource { get; }

        [nterraform.TerraformProperty(name: "custom_json", @out: false, min: 0, max: 1)]
        public string @CustomJson { get; }

        [nterraform.TerraformProperty(name: "default_availability_zone", @out: true, min: 0, max: 1)]
        public string @DefaultAvailabilityZone { get; }

        [nterraform.TerraformProperty(name: "default_os", @out: false, min: 0, max: 1)]
        public string @DefaultOs { get; }

        [nterraform.TerraformProperty(name: "default_root_device_type", @out: false, min: 0, max: 1)]
        public string @DefaultRootDeviceType { get; }

        [nterraform.TerraformProperty(name: "default_ssh_key_name", @out: false, min: 0, max: 1)]
        public string @DefaultSshKeyName { get; }

        [nterraform.TerraformProperty(name: "default_subnet_id", @out: true, min: 0, max: 1)]
        public string @DefaultSubnetId { get; }

        [nterraform.TerraformProperty(name: "hostname_theme", @out: false, min: 0, max: 1)]
        public string @HostnameTheme { get; }

        [nterraform.TerraformProperty(name: "manage_berkshelf", @out: false, min: 0, max: 1)]
        public bool? @ManageBerkshelf { get; }

        [nterraform.TerraformProperty(name: "stack_endpoint", @out: true, min: 0, max: 1)]
        public string @StackEndpoint { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "use_custom_cookbooks", @out: false, min: 0, max: 1)]
        public bool? @UseCustomCookbooks { get; }

        [nterraform.TerraformProperty(name: "use_opsworks_security_groups", @out: false, min: 0, max: 1)]
        public bool? @UseOpsworksSecurityGroups { get; }

        [nterraform.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
        public string @VpcId { get; }
    }

}
