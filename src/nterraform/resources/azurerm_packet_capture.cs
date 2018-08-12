using System.Collections.Generic;

namespace nterraform.resources.azurerm
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_packet_capture")]
    public sealed class azurerm_packet_capture : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "storage_location")]
        public sealed class storage_location : nterraform.Core.structure
        {
            public storage_location(string @filePath = null,
                                    string @storageAccountId = null)
            {
                @FilePath = @filePath;
                @StorageAccountId = @storageAccountId;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "file_path", @out: false, min: 0, max: 1)]
            public string @FilePath { get; }

            [nterraform.Core.TerraformProperty(name: "storage_account_id", @out: false, min: 0, max: 1)]
            public string @StorageAccountId { get; }

            [nterraform.Core.TerraformProperty(name: "storage_path", @out: true, min: 0, max: 1)]
            public string @StoragePath { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "filter")]
        public sealed class filter : nterraform.Core.structure
        {
            public filter(string @protocol,
                          string @localIpAddress = null,
                          string @localPort = null,
                          string @remoteIpAddress = null,
                          string @remotePort = null)
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
            public string @LocalIpAddress { get; }

            [nterraform.Core.TerraformProperty(name: "local_port", @out: false, min: 0, max: 1)]
            public string @LocalPort { get; }

            [nterraform.Core.TerraformProperty(name: "remote_ip_address", @out: false, min: 0, max: 1)]
            public string @RemoteIpAddress { get; }

            [nterraform.Core.TerraformProperty(name: "remote_port", @out: false, min: 0, max: 1)]
            public string @RemotePort { get; }
        }

        public azurerm_packet_capture(string @name,
                                      string @networkWatcherName,
                                      string @resourceGroupName,
                                      storage_location[] @storageLocation,
                                      string @targetResourceId,
                                      filter[] @filter = null,
                                      int? @maximumBytesPerPacket = null,
                                      int? @maximumBytesPerSession = null,
                                      int? @maximumCaptureDuration = null)
        {
            @Name = @name;
            @NetworkWatcherName = @networkWatcherName;
            @ResourceGroupName = @resourceGroupName;
            @StorageLocation = @storageLocation;
            @TargetResourceId = @targetResourceId;
            @Filter = @filter;
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
        public storage_location[] @StorageLocation { get; }

        [nterraform.Core.TerraformProperty(name: "target_resource_id", @out: false, min: 1, max: 1)]
        public string @TargetResourceId { get; }

        [nterraform.Core.TerraformProperty(name: "filter", @out: false, min: 0, max: 0)]
        public filter[] @Filter { get; }

        [nterraform.Core.TerraformProperty(name: "maximum_bytes_per_packet", @out: false, min: 0, max: 1)]
        public int? @MaximumBytesPerPacket { get; }

        [nterraform.Core.TerraformProperty(name: "maximum_bytes_per_session", @out: false, min: 0, max: 1)]
        public int? @MaximumBytesPerSession { get; }

        [nterraform.Core.TerraformProperty(name: "maximum_capture_duration", @out: false, min: 0, max: 1)]
        public int? @MaximumCaptureDuration { get; }
    }

}
