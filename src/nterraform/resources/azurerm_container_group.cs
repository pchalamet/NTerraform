using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_container_group")]
    public sealed class azurerm_container_group : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "image_registry_credential")]
        public sealed class image_registry_credential : nterraform.Core.structure
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

            [nterraform.Core.TerraformProperty(name: "password", @out: false, min: 1, max: 1)]
            public string @Password { get; }

            [nterraform.Core.TerraformProperty(name: "server", @out: false, min: 1, max: 1)]
            public string @Server { get; }

            [nterraform.Core.TerraformProperty(name: "username", @out: false, min: 1, max: 1)]
            public string @Username { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "container")]
        public sealed class container : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "volume")]
            public sealed class volume : nterraform.Core.structure
            {
                public volume(string @mountPath,
                              string @name,
                              string @shareName,
                              string @storageAccountKey,
                              string @storageAccountName,
                              FSharpOption<bool> @readOnly = null)
                {
                    @MountPath = @mountPath;
                    @Name = @name;
                    @ShareName = @shareName;
                    @StorageAccountKey = @storageAccountKey;
                    @StorageAccountName = @storageAccountName;
                    @ReadOnly = @readOnly;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "mount_path", @out: false, min: 1, max: 1)]
                public string @MountPath { get; }

                [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
                public string @Name { get; }

                [nterraform.Core.TerraformProperty(name: "share_name", @out: false, min: 1, max: 1)]
                public string @ShareName { get; }

                [nterraform.Core.TerraformProperty(name: "storage_account_key", @out: false, min: 1, max: 1)]
                public string @StorageAccountKey { get; }

                [nterraform.Core.TerraformProperty(name: "storage_account_name", @out: false, min: 1, max: 1)]
                public string @StorageAccountName { get; }

                [nterraform.Core.TerraformProperty(name: "read_only", @out: false, min: 0, max: 1)]
                public FSharpOption<bool> @ReadOnly { get; }
            }

            public container(int @cpu,
                             string @image,
                             int @memory,
                             string @name,
                             FSharpOption<string> @command = null,
                             FSharpOption<FSharpMap<string,string>> @environmentVariables = null,
                             FSharpOption<int> @port = null,
                             FSharpOption<string> @protocol = null,
                             FSharpOption<FSharpList<volume>> @volume = null)
            {
                @Cpu = @cpu;
                @Image = @image;
                @Memory = @memory;
                @Name = @name;
                @Command = @command;
                @EnvironmentVariables = @environmentVariables ?? MapModule.Empty<string,string>();
                @Port = @port;
                @Protocol = @protocol;
                @Volume = @volume ?? FSharpList<volume>.Empty;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "cpu", @out: false, min: 1, max: 1)]
            public int @Cpu { get; }

            [nterraform.Core.TerraformProperty(name: "image", @out: false, min: 1, max: 1)]
            public string @Image { get; }

            [nterraform.Core.TerraformProperty(name: "memory", @out: false, min: 1, max: 1)]
            public int @Memory { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "command", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @Command { get; }

            [nterraform.Core.TerraformProperty(name: "environment_variables", @out: false, min: 0, max: 1)]
            public FSharpOption<FSharpMap<string,string>> @EnvironmentVariables { get; }

            [nterraform.Core.TerraformProperty(name: "port", @out: false, min: 0, max: 1)]
            public FSharpOption<int> @Port { get; }

            [nterraform.Core.TerraformProperty(name: "protocol", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @Protocol { get; }

            [nterraform.Core.TerraformProperty(name: "volume", @out: false, min: 0, max: 0)]
            public FSharpOption<FSharpList<volume>> @Volume { get; }
        }

        public azurerm_container_group(FSharpList<container> @container,
                                       string @location,
                                       string @name,
                                       string @osType,
                                       string @resourceGroupName,
                                       FSharpOption<string> @dnsNameLabel = null,
                                       FSharpOption<FSharpList<image_registry_credential>> @imageRegistryCredential = null,
                                       FSharpOption<string> @ipAddressType = null,
                                       FSharpOption<string> @restartPolicy = null)
        {
            @Container = @container;
            @Location = @location;
            @Name = @name;
            @OsType = @osType;
            @ResourceGroupName = @resourceGroupName;
            @DnsNameLabel = @dnsNameLabel;
            @ImageRegistryCredential = @imageRegistryCredential ?? FSharpList<image_registry_credential>.Empty;
            @IpAddressType = @ipAddressType;
            @RestartPolicy = @restartPolicy;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "container", @out: false, min: 1, max: 0)]
        public FSharpList<container> @Container { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "os_type", @out: false, min: 1, max: 1)]
        public string @OsType { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "dns_name_label", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @DnsNameLabel { get; }

        [nterraform.Core.TerraformProperty(name: "fqdn", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Fqdn { get; }

        [nterraform.Core.TerraformProperty(name: "image_registry_credential", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpList<image_registry_credential>> @ImageRegistryCredential { get; }

        [nterraform.Core.TerraformProperty(name: "ip_address", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @IpAddress { get; }

        [nterraform.Core.TerraformProperty(name: "ip_address_type", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @IpAddressType { get; }

        [nterraform.Core.TerraformProperty(name: "restart_policy", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @RestartPolicy { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpMap<string,string>> @Tags { get; }
    }

}
