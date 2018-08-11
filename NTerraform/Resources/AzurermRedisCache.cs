using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_redis_cache")]
    public sealed class azurerm_redis_cache : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "redis_configuration")]
        public sealed class redis_configuration: NTerraform.structure
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
                base._validate_();
            }

            [TerraformProperty(name: "maxclients", @out: true, min: 0, max: 1)]
            public int? @Maxclients { get; }

            [TerraformProperty(name: "maxmemory_delta", @out: true, min: 0, max: 1)]
            public int? @MaxmemoryDelta { get; }

            [TerraformProperty(name: "maxmemory_policy", @out: false, min: 0, max: 1)]
            public string @MaxmemoryPolicy { get; }

            [TerraformProperty(name: "maxmemory_reserved", @out: true, min: 0, max: 1)]
            public int? @MaxmemoryReserved { get; }

            [TerraformProperty(name: "notify_keyspace_events", @out: false, min: 0, max: 1)]
            public string @NotifyKeyspaceEvents { get; }

            [TerraformProperty(name: "rdb_backup_enabled", @out: false, min: 0, max: 1)]
            public bool? @RdbBackupEnabled { get; }

            [TerraformProperty(name: "rdb_backup_frequency", @out: false, min: 0, max: 1)]
            public int? @RdbBackupFrequency { get; }

            [TerraformProperty(name: "rdb_backup_max_snapshot_count", @out: false, min: 0, max: 1)]
            public int? @RdbBackupMaxSnapshotCount { get; }

            [TerraformProperty(name: "rdb_storage_connection_string", @out: false, min: 0, max: 1)]
            public string @RdbStorageConnectionString { get; }
        }

        [TerraformStructure(category: "", typeName: "patch_schedule")]
        public sealed class patch_schedule: NTerraform.structure
        {
            public patch_schedule(string @dayOfWeek,
                                  int? @startHourUtc = null)
            {
                @DayOfWeek = @dayOfWeek;
                @StartHourUtc = @startHourUtc;
                base._validate_();
            }

            [TerraformProperty(name: "day_of_week", @out: false, min: 1, max: 1)]
            public string @DayOfWeek { get; }

            [TerraformProperty(name: "start_hour_utc", @out: false, min: 0, max: 1)]
            public int? @StartHourUtc { get; }
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
            base._validate_();
        }

        [TerraformProperty(name: "capacity", @out: false, min: 1, max: 1)]
        public int @Capacity { get; }

        [TerraformProperty(name: "family", @out: false, min: 1, max: 1)]
        public string @Family { get; }

        [TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "redis_configuration", @out: false, min: 1, max: 1)]
        public redis_configuration[] @RedisConfiguration { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "sku_name", @out: false, min: 1, max: 1)]
        public string @SkuName { get; }

        [TerraformProperty(name: "enable_non_ssl_port", @out: false, min: 0, max: 1)]
        public bool? @EnableNonSslPort { get; }

        [TerraformProperty(name: "hostname", @out: true, min: 0, max: 1)]
        public string @Hostname { get; }

        [TerraformProperty(name: "patch_schedule", @out: false, min: 0, max: 0)]
        public patch_schedule[] @PatchSchedule { get; }

        [TerraformProperty(name: "port", @out: true, min: 0, max: 1)]
        public int? @Port { get; }

        [TerraformProperty(name: "primary_access_key", @out: true, min: 0, max: 1)]
        public string @PrimaryAccessKey { get; }

        [TerraformProperty(name: "private_static_ip_address", @out: true, min: 0, max: 1)]
        public string @PrivateStaticIpAddress { get; }

        [TerraformProperty(name: "secondary_access_key", @out: true, min: 0, max: 1)]
        public string @SecondaryAccessKey { get; }

        [TerraformProperty(name: "shard_count", @out: false, min: 0, max: 1)]
        public int? @ShardCount { get; }

        [TerraformProperty(name: "ssl_port", @out: true, min: 0, max: 1)]
        public int? @SslPort { get; }

        [TerraformProperty(name: "subnet_id", @out: false, min: 0, max: 1)]
        public string @SubnetId { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
