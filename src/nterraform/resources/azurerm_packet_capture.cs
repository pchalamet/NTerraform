using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_packet_capture")]
    public sealed class azurerm_packet_capture : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "storage_location")]
        public sealed class storage_location : nterraform.Core.structure
        {
            public storage_location(FSharpOption<string> @filePath = null,
                                    FSharpOption<string> @storageAccountId = null)
            {
                @FilePath = @filePath;
                @StorageAccountId = @storageAccountId;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "file_path", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @FilePath { get; }

            [nterraform.Core.TerraformProperty(name: "storage_account_id", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @StorageAccountId { get; }

            [nterraform.Core.TerraformProperty(name: "storage_path", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @StoragePath { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "filter")]
        public sealed class filter : nterraform.Core.structure
        {
            public filter(string @protocol,
                          FSharpOption<string> @localIpAddress = null,
                          FSharpOption<string> @localPort = null,
                          FSharpOption<string> @remoteIpAddress = null,
                          FSharpOption<string> @remotePort = null)
            {
                @Protocol = @protocol;
                @LocalIpAddress = @localIpAddress;
                @LocalPort = @localPort;
                @RemoteIpAddress = @remoteIpAddress;
                @RemotePort = @remotePort;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "protocol", @out: false, min: 1, max: 1)]
            public string @Protocol { get; }

            [nterraform.Core.TerraformProperty(name: "local_ip_address", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @LocalIpAddress { get; }

            [nterraform.Core.TerraformProperty(name: "local_port", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @LocalPort { get; }

            [nterraform.Core.TerraformProperty(name: "remote_ip_address", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @RemoteIpAddress { get; }

            [nterraform.Core.TerraformProperty(name: "remote_port", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @RemotePort { get; }
        }

        public azurerm_packet_capture(string @name,
                                      string @networkWatcherName,
                                      string @resourceGroupName,
                                      FSharpList<storage_location> @storageLocation,
                                      string @targetResourceId,
                                      FSharpOption<FSharpList<filter>> @filter = null,
                                      FSharpOption<int> @maximumBytesPerPacket = null,
                                      FSharpOption<int> @maximumBytesPerSession = null,
                                      FSharpOption<int> @maximumCaptureDuration = null)
        {
            @Name = @name;
            @NetworkWatcherName = @networkWatcherName;
            @ResourceGroupName = @resourceGroupName;
            @StorageLocation = @storageLocation;
            @TargetResourceId = @targetResourceId;
            @Filter = @filter ?? FSharpList<filter>.Empty;
            @MaximumBytesPerPacket = @maximumBytesPerPacket;
            @MaximumBytesPerSession = @maximumBytesPerSession;
            @MaximumCaptureDuration = @maximumCaptureDuration;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "network_watcher_name", @out: false, min: 1, max: 1)]
        public string @NetworkWatcherName { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "storage_location", @out: false, min: 1, max: 1)]
        public FSharpList<storage_location> @StorageLocation { get; }

        [nterraform.Core.TerraformProperty(name: "target_resource_id", @out: false, min: 1, max: 1)]
        public string @TargetResourceId { get; }

        [nterraform.Core.TerraformProperty(name: "filter", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpList<filter>> @Filter { get; }

        [nterraform.Core.TerraformProperty(name: "maximum_bytes_per_packet", @out: false, min: 0, max: 1)]
        public FSharpOption<int> @MaximumBytesPerPacket { get; }

        [nterraform.Core.TerraformProperty(name: "maximum_bytes_per_session", @out: false, min: 0, max: 1)]
        public FSharpOption<int> @MaximumBytesPerSession { get; }

        [nterraform.Core.TerraformProperty(name: "maximum_capture_duration", @out: false, min: 0, max: 1)]
        public FSharpOption<int> @MaximumCaptureDuration { get; }
    }

}
