using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_container_group : NTerraform.resource
    {
        public sealed class container
        {
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

                public string @MountPath { get; }
                public string @Name { get; }
                public string @ShareName { get; }
                public string @StorageAccountKey { get; }
                public string @StorageAccountName { get; }
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

            public int @Cpu { get; }
            public string @Image { get; }
            public int @Memory { get; }
            public string @Name { get; }
            public string @Command { get; }
            public Dictionary<string,string> @EnvironmentVariables { get; }
            public int? @Port { get; }
            public string @Protocol { get; }
            public volume[] @Volume { get; }
        }

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

            public string @Password { get; }
            public string @Server { get; }
            public string @Username { get; }
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

        public container[] @Container { get; }
        public string @Location { get; }
        public string @Name { get; }
        public string @OsType { get; }
        public string @ResourceGroupName { get; }
        public string @DnsNameLabel { get; }
        public string @Fqdn { get; }
        public image_registry_credential[] @ImageRegistryCredential { get; }
        public string @IpAddress { get; }
        public string @IpAddressType { get; }
        public string @RestartPolicy { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
