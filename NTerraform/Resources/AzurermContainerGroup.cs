using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_container_group")]
    public sealed class azurerm_container_group : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "image_registry_credential")]
        public sealed class image_registry_credential
        {
            public image_registry_credential(string @password,
                                             string @server,
                                             string @username)
            {
                @Password = @password;
                @Server = @server;
                @Username = @username;
            }

            [TerraformProperty(name: "password", @out: false, nested: false, min: 1, max: 1)]
            public string @Password { get; }

            [TerraformProperty(name: "server", @out: false, nested: false, min: 1, max: 1)]
            public string @Server { get; }

            [TerraformProperty(name: "username", @out: false, nested: false, min: 1, max: 1)]
            public string @Username { get; }
        }

        [TerraformStructure(category: "", typeName: "container")]
        public sealed class container
        {
            [TerraformStructure(category: "", typeName: "volume")]
            public sealed class volume
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
                }

                [TerraformProperty(name: "mount_path", @out: false, nested: false, min: 1, max: 1)]
                public string @MountPath { get; }

                [TerraformProperty(name: "name", @out: false, nested: false, min: 1, max: 1)]
                public string @Name { get; }

                [TerraformProperty(name: "share_name", @out: false, nested: false, min: 1, max: 1)]
                public string @ShareName { get; }

                [TerraformProperty(name: "storage_account_key", @out: false, nested: false, min: 1, max: 1)]
                public string @StorageAccountKey { get; }

                [TerraformProperty(name: "storage_account_name", @out: false, nested: false, min: 1, max: 1)]
                public string @StorageAccountName { get; }

                [TerraformProperty(name: "read_only", @out: false, nested: false, min: 0, max: 1)]
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
            }

            [TerraformProperty(name: "cpu", @out: false, nested: false, min: 1, max: 1)]
            public int @Cpu { get; }

            [TerraformProperty(name: "image", @out: false, nested: false, min: 1, max: 1)]
            public string @Image { get; }

            [TerraformProperty(name: "memory", @out: false, nested: false, min: 1, max: 1)]
            public int @Memory { get; }

            [TerraformProperty(name: "name", @out: false, nested: false, min: 1, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "command", @out: false, nested: false, min: 0, max: 1)]
            public string @Command { get; }

            [TerraformProperty(name: "environment_variables", @out: false, nested: false, min: 0, max: 1)]
            public Dictionary<string,string> @EnvironmentVariables { get; }

            [TerraformProperty(name: "port", @out: false, nested: false, min: 0, max: 1)]
            public int? @Port { get; }

            [TerraformProperty(name: "protocol", @out: false, nested: false, min: 0, max: 1)]
            public string @Protocol { get; }

            [TerraformProperty(name: "volume", @out: false, nested: false, min: 0, max: 0)]
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
        }

        [TerraformProperty(name: "container", @out: false, nested: true, min: 1, max: 0)]
        public container[] @Container { get; }

        [TerraformProperty(name: "location", @out: false, nested: true, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "os_type", @out: false, nested: true, min: 1, max: 1)]
        public string @OsType { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "dns_name_label", @out: false, nested: true, min: 0, max: 1)]
        public string @DnsNameLabel { get; }

        [TerraformProperty(name: "fqdn", @out: true, nested: true, min: 0, max: 1)]
        public string @Fqdn { get; }

        [TerraformProperty(name: "image_registry_credential", @out: false, nested: true, min: 0, max: 0)]
        public image_registry_credential[] @ImageRegistryCredential { get; }

        [TerraformProperty(name: "ip_address", @out: true, nested: true, min: 0, max: 1)]
        public string @IpAddress { get; }

        [TerraformProperty(name: "ip_address_type", @out: false, nested: true, min: 0, max: 1)]
        public string @IpAddressType { get; }

        [TerraformProperty(name: "restart_policy", @out: false, nested: true, min: 0, max: 1)]
        public string @RestartPolicy { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
