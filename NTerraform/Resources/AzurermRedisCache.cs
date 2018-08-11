using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_redis_cache : NTerraform.resource
    {
        public sealed class patch_schedule
        {
            public patch_schedule(string @dayOfWeek,
                                  int? @startHourUtc = null)
            {
                @DayOfWeek = @dayOfWeek;
                @StartHourUtc = @startHourUtc;
            }

            public string @DayOfWeek { get; }
            public int? @StartHourUtc { get; }
        }

        public sealed class redis_configuration
        {
            public redis_configuration(string @maxmemoryPolicy = null,
                                       string @notifyKeyspaceEvents = null,
                                       bool? @rdbBackupEnabled = null,
                                       int? @rdbBackupFrequency = null,
                                       int? @rdbBackupMaxSnapshotCount = null,
                                       string @rdbStorageConnectionString = null)
            {
                @MaxmemoryPolicy = @maxmemoryPolicy;
                @NotifyKeyspaceEvents = @notifyKeyspaceEvents;
                @RdbBackupEnabled = @rdbBackupEnabled;
                @RdbBackupFrequency = @rdbBackupFrequency;
                @RdbBackupMaxSnapshotCount = @rdbBackupMaxSnapshotCount;
                @RdbStorageConnectionString = @rdbStorageConnectionString;
            }

            public int? @Maxclients { get; }
            public int? @MaxmemoryDelta { get; }
            public string @MaxmemoryPolicy { get; }
            public int? @MaxmemoryReserved { get; }
            public string @NotifyKeyspaceEvents { get; }
            public bool? @RdbBackupEnabled { get; }
            public int? @RdbBackupFrequency { get; }
            public int? @RdbBackupMaxSnapshotCount { get; }
            public string @RdbStorageConnectionString { get; }
        }

        public azurerm_redis_cache(int @capacity,
                                   string @family,
                                   string @location,
                                   string @name,
                                   redis_configuration[] @redisConfiguration,
                                   string @resourceGroupName,
                                   string @skuName,
                                   bool? @enableNonSslPort = null,
                                   patch_schedule[] @patchSchedule = null,
                                   int? @shardCount = null,
                                   string @subnetId = null)
        {
            @Capacity = @capacity;
            @Family = @family;
            @Location = @location;
            @Name = @name;
            @RedisConfiguration = @redisConfiguration;
            @ResourceGroupName = @resourceGroupName;
            @SkuName = @skuName;
            @EnableNonSslPort = @enableNonSslPort;
            @PatchSchedule = @patchSchedule;
            @ShardCount = @shardCount;
            @SubnetId = @subnetId;
        }

        public int @Capacity { get; }
        public string @Family { get; }
        public string @Location { get; }
        public string @Name { get; }
        public redis_configuration[] @RedisConfiguration { get; }
        public string @ResourceGroupName { get; }
        public string @SkuName { get; }
        public bool? @EnableNonSslPort { get; }
        public string @Hostname { get; }
        public patch_schedule[] @PatchSchedule { get; }
        public int? @Port { get; }
        public string @PrimaryAccessKey { get; }
        public string @PrivateStaticIpAddress { get; }
        public string @SecondaryAccessKey { get; }
        public int? @ShardCount { get; }
        public int? @SslPort { get; }
        public string @SubnetId { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
