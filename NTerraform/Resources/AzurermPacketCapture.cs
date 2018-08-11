using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_packet_capture : NTerraform.resource
    {
        public sealed class storage_location
        {
            public storage_location(string @filePath = null,
                                    string @storageAccountId = null)
            {
                @FilePath = @filePath;
                @StorageAccountId = @storageAccountId;
            }

            public string @FilePath { get; }
            public string @StorageAccountId { get; }
            public string @StoragePath { get; }
        }

        public sealed class filter
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
            }

            public string @Protocol { get; }
            public string @LocalIpAddress { get; }
            public string @LocalPort { get; }
            public string @RemoteIpAddress { get; }
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
        }

        public string @Name { get; }
        public string @NetworkWatcherName { get; }
        public string @ResourceGroupName { get; }
        public storage_location[] @StorageLocation { get; }
        public string @TargetResourceId { get; }
        public filter[] @Filter { get; }
        public int? @MaximumBytesPerPacket { get; }
        public int? @MaximumBytesPerSession { get; }
        public int? @MaximumCaptureDuration { get; }
    }

}
