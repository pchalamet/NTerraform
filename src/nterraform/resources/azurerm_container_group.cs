using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_container_group")]
    public sealed class azurerm_container_group : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "image_registry_credential")]
        public sealed class image_registry_credential : nterraform.structure
        {
            public image_registry_credential(string @password,
                                             string @server,
                                             string @username)
            {
                @Password = @password;
                @Server = @server;
                @Username = @username;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "password", @out: false, min: 1, max: 1)]
            public string @Password { get; }

            [nterraform.TerraformProperty(name: "server", @out: false, min: 1, max: 1)]
            public string @Server { get; }

            [nterraform.TerraformProperty(name: "username", @out: false, min: 1, max: 1)]
            public string @Username { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "container")]
        public sealed class container : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "volume")]
            public sealed class volume : nterraform.structure
            {
                public volume(string @mountPath,
                              string @name,
                              string @shareName,
                              string @storageAccountKey,
                              string @storageAccountName,
                              bool? @readOnly = null)
                {
                    @MountPath = @mountPath;
                    @Name = @name;
                    @ShareName = @shareName;
                    @StorageAccountKey = @storageAccountKey;
                    @StorageAccountName = @storageAccountName;
                    @ReadOnly = @readOnly;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "mount_path", @out: false, min: 1, max: 1)]
                public string @MountPath { get; }

                [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
                public string @Name { get; }

                [nterraform.TerraformProperty(name: "share_name", @out: false, min: 1, max: 1)]
                public string @ShareName { get; }

                [nterraform.TerraformProperty(name: "storage_account_key", @out: false, min: 1, max: 1)]
                public string @StorageAccountKey { get; }

                [nterraform.TerraformProperty(name: "storage_account_name", @out: false, min: 1, max: 1)]
                public string @StorageAccountName { get; }

                [nterraform.TerraformProperty(name: "read_only", @out: false, min: 0, max: 1)]
                public bool? @ReadOnly { get; }
            }

            public container(int @cpu,
                             string @image,
                             int @memory,
                             string @name,
                             string @command = null,
                             Dictionary<string,string> @environmentVariables = null,
                             int? @port = null,
                             string @protocol = null,
                             volume[] @volume = null)
            {
                @Cpu = @cpu;
                @Image = @image;
                @Memory = @memory;
                @Name = @name;
                @Command = @command;
                @EnvironmentVariables = @environmentVariables;
                @Port = @port;
                @Protocol = @protocol;
                @Volume = @volume;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "cpu", @out: false, min: 1, max: 1)]
            public int @Cpu { get; }

            [nterraform.TerraformProperty(name: "image", @out: false, min: 1, max: 1)]
            public string @Image { get; }

            [nterraform.TerraformProperty(name: "memory", @out: false, min: 1, max: 1)]
            public int @Memory { get; }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "command", @out: false, min: 0, max: 1)]
            public string @Command { get; }

            [nterraform.TerraformProperty(name: "environment_variables", @out: false, min: 0, max: 1)]
            public Dictionary<string,string> @EnvironmentVariables { get; }

            [nterraform.TerraformProperty(name: "port", @out: false, min: 0, max: 1)]
            public int? @Port { get; }

            [nterraform.TerraformProperty(name: "protocol", @out: false, min: 0, max: 1)]
            public string @Protocol { get; }

            [nterraform.TerraformProperty(name: "volume", @out: false, min: 0, max: 0)]
            public volume[] @Volume { get; }
        }

        public azurerm_container_group(container[] @container,
                                       string @location,
                                       string @name,
                                       string @osType,
                                       string @resourceGroupName,
                                       string @dnsNameLabel = null,
                                       image_registry_credential[] @imageRegistryCredential = null,
                                       string @ipAddressType = null,
                                       string @restartPolicy = null)
        {
            @Container = @container;
            @Location = @location;
            @Name = @name;
            @OsType = @osType;
            @ResourceGroupName = @resourceGroupName;
            @DnsNameLabel = @dnsNameLabel;
            @ImageRegistryCredential = @imageRegistryCredential;
            @IpAddressType = @ipAddressType;
            @RestartPolicy = @restartPolicy;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "container", @out: false, min: 1, max: 0)]
        public container[] @Container { get; }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "os_type", @out: false, min: 1, max: 1)]
        public string @OsType { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "dns_name_label", @out: false, min: 0, max: 1)]
        public string @DnsNameLabel { get; }

        [nterraform.TerraformProperty(name: "fqdn", @out: true, min: 0, max: 1)]
        public string @Fqdn { get; }

        [nterraform.TerraformProperty(name: "image_registry_credential", @out: false, min: 0, max: 0)]
        public image_registry_credential[] @ImageRegistryCredential { get; }

        [nterraform.TerraformProperty(name: "ip_address", @out: true, min: 0, max: 1)]
        public string @IpAddress { get; }

        [nterraform.TerraformProperty(name: "ip_address_type", @out: false, min: 0, max: 1)]
        public string @IpAddressType { get; }

        [nterraform.TerraformProperty(name: "restart_policy", @out: false, min: 0, max: 1)]
        public string @RestartPolicy { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
