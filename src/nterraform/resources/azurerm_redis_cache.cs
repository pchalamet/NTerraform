using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_redis_cache")]
    public sealed class azurerm_redis_cache : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "patch_schedule")]
        public sealed class patch_schedule : nterraform.Core.structure
        {
            public patch_schedule(string @dayOfWeek,
                                  FSharpOption<int> @startHourUtc = null)
            {
                @DayOfWeek = @dayOfWeek;
                @StartHourUtc = @startHourUtc;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "day_of_week", @out: false, min: 1, max: 1)]
            public string @DayOfWeek { get; }

            [nterraform.Core.TerraformProperty(name: "start_hour_utc", @out: false, min: 0, max: 1)]
            public FSharpOption<int> @StartHourUtc { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "redis_configuration")]
        public sealed class redis_configuration : nterraform.Core.structure
        {
            public redis_configuration(FSharpOption<string> @maxmemoryPolicy = null,
                                       FSharpOption<string> @notifyKeyspaceEvents = null,
                                       FSharpOption<bool> @rdbBackupEnabled = null,
                                       FSharpOption<int> @rdbBackupFrequency = null,
                                       FSharpOption<int> @rdbBackupMaxSnapshotCount = null,
                                       FSharpOption<string> @rdbStorageConnectionString = null)
            {
                @MaxmemoryPolicy = @maxmemoryPolicy;
                @NotifyKeyspaceEvents = @notifyKeyspaceEvents;
                @RdbBackupEnabled = @rdbBackupEnabled;
                @RdbBackupFrequency = @rdbBackupFrequency;
                @RdbBackupMaxSnapshotCount = @rdbBackupMaxSnapshotCount;
                @RdbStorageConnectionString = @rdbStorageConnectionString;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "maxclients", @out: true, min: 0, max: 1)]
            public FSharpOption<int> @Maxclients { get; }

            [nterraform.Core.TerraformProperty(name: "maxmemory_delta", @out: true, min: 0, max: 1)]
            public FSharpOption<int> @MaxmemoryDelta { get; }

            [nterraform.Core.TerraformProperty(name: "maxmemory_policy", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @MaxmemoryPolicy { get; }

            [nterraform.Core.TerraformProperty(name: "maxmemory_reserved", @out: true, min: 0, max: 1)]
            public FSharpOption<int> @MaxmemoryReserved { get; }

            [nterraform.Core.TerraformProperty(name: "notify_keyspace_events", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @NotifyKeyspaceEvents { get; }

            [nterraform.Core.TerraformProperty(name: "rdb_backup_enabled", @out: false, min: 0, max: 1)]
            public FSharpOption<bool> @RdbBackupEnabled { get; }

            [nterraform.Core.TerraformProperty(name: "rdb_backup_frequency", @out: false, min: 0, max: 1)]
            public FSharpOption<int> @RdbBackupFrequency { get; }

            [nterraform.Core.TerraformProperty(name: "rdb_backup_max_snapshot_count", @out: false, min: 0, max: 1)]
            public FSharpOption<int> @RdbBackupMaxSnapshotCount { get; }

            [nterraform.Core.TerraformProperty(name: "rdb_storage_connection_string", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @RdbStorageConnectionString { get; }
        }

        public azurerm_redis_cache(int @capacity,
                                   string @family,
                                   string @location,
                                   string @name,
                                   FSharpList<redis_configuration> @redisConfiguration,
                                   string @resourceGroupName,
                                   string @skuName,
                                   FSharpOption<bool> @enableNonSslPort = null,
                                   FSharpOption<FSharpList<patch_schedule>> @patchSchedule = null,
                                   FSharpOption<int> @shardCount = null,
                                   FSharpOption<string> @subnetId = null)
        {
            @Capacity = @capacity;
            @Family = @family;
            @Location = @location;
            @Name = @name;
            @RedisConfiguration = @redisConfiguration;
            @ResourceGroupName = @resourceGroupName;
            @SkuName = @skuName;
            @EnableNonSslPort = @enableNonSslPort;
            @PatchSchedule = @patchSchedule ?? FSharpList<patch_schedule>.Empty;
            @ShardCount = @shardCount;
            @SubnetId = @subnetId;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "capacity", @out: false, min: 1, max: 1)]
        public int @Capacity { get; }

        [nterraform.Core.TerraformProperty(name: "family", @out: false, min: 1, max: 1)]
        public string @Family { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "redis_configuration", @out: false, min: 1, max: 1)]
        public FSharpList<redis_configuration> @RedisConfiguration { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "sku_name", @out: false, min: 1, max: 1)]
        public string @SkuName { get; }

        [nterraform.Core.TerraformProperty(name: "enable_non_ssl_port", @out: false, min: 0, max: 1)]
        public FSharpOption<bool> @EnableNonSslPort { get; }

        [nterraform.Core.TerraformProperty(name: "hostname", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Hostname { get; }

        [nterraform.Core.TerraformProperty(name: "patch_schedule", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpList<patch_schedule>> @PatchSchedule { get; }

        [nterraform.Core.TerraformProperty(name: "port", @out: true, min: 0, max: 1)]
        public FSharpOption<int> @Port { get; }

        [nterraform.Core.TerraformProperty(name: "primary_access_key", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @PrimaryAccessKey { get; }

        [nterraform.Core.TerraformProperty(name: "private_static_ip_address", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @PrivateStaticIpAddress { get; }

        [nterraform.Core.TerraformProperty(name: "secondary_access_key", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @SecondaryAccessKey { get; }

        [nterraform.Core.TerraformProperty(name: "shard_count", @out: false, min: 0, max: 1)]
        public FSharpOption<int> @ShardCount { get; }

        [nterraform.Core.TerraformProperty(name: "ssl_port", @out: true, min: 0, max: 1)]
        public FSharpOption<int> @SslPort { get; }

        [nterraform.Core.TerraformProperty(name: "subnet_id", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @SubnetId { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpMap<string,string>> @Tags { get; }
    }

}
