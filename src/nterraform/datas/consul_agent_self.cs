using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "consul_agent_self")]
    public sealed class consul_agent_self : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "telemetry")]
        public sealed class telemetry : nterraform.Core.structure
        {
            public telemetry()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "circonus_api_app", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @CirconusApiApp { get; }

            [nterraform.Core.TerraformProperty(name: "circonus_api_token", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @CirconusApiToken { get; }

            [nterraform.Core.TerraformProperty(name: "circonus_api_url", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @CirconusApiUrl { get; }

            [nterraform.Core.TerraformProperty(name: "circonus_broker_id", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @CirconusBrokerId { get; }

            [nterraform.Core.TerraformProperty(name: "circonus_check_id", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @CirconusCheckId { get; }

            [nterraform.Core.TerraformProperty(name: "circonus_check_tags", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @CirconusCheckTags { get; }

            [nterraform.Core.TerraformProperty(name: "circonus_display_name", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @CirconusDisplayName { get; }

            [nterraform.Core.TerraformProperty(name: "circonus_force_metric_activation", @out: true, min: 0, max: 1)]
            public FSharpOption<bool> @CirconusForceMetricActivation { get; }

            [nterraform.Core.TerraformProperty(name: "circonus_instance_id", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @CirconusInstanceId { get; }

            [nterraform.Core.TerraformProperty(name: "circonus_search_tag", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @CirconusSearchTag { get; }

            [nterraform.Core.TerraformProperty(name: "circonus_select_tag", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @CirconusSelectTag { get; }

            [nterraform.Core.TerraformProperty(name: "circonus_submission_interval", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @CirconusSubmissionInterval { get; }

            [nterraform.Core.TerraformProperty(name: "circonus_submission_url", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @CirconusSubmissionUrl { get; }

            [nterraform.Core.TerraformProperty(name: "dogstatsd_addr", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @DogstatsdAddr { get; }

            [nterraform.Core.TerraformProperty(name: "dogstatsd_tags", @out: true, min: 0, max: 1)]
            public FSharpOption<FSharpList<string>> @DogstatsdTags { get; }

            [nterraform.Core.TerraformProperty(name: "enable_hostname", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @EnableHostname { get; }

            [nterraform.Core.TerraformProperty(name: "statsd_addr", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @StatsdAddr { get; }

            [nterraform.Core.TerraformProperty(name: "statsite_addr", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @StatsiteAddr { get; }

            [nterraform.Core.TerraformProperty(name: "statsite_prefix", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @StatsitePrefix { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "unix_sockets")]
        public sealed class unix_sockets : nterraform.Core.structure
        {
            public unix_sockets()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "group", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Group { get; }

            [nterraform.Core.TerraformProperty(name: "mode", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Mode { get; }

            [nterraform.Core.TerraformProperty(name: "user", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @User { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "tagged_addresses")]
        public sealed class tagged_addresses : nterraform.Core.structure
        {
            public tagged_addresses()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "lan", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Lan { get; }

            [nterraform.Core.TerraformProperty(name: "wan", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Wan { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "performance")]
        public sealed class performance : nterraform.Core.structure
        {
            public performance()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "raft_multiplier", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @RaftMultiplier { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "advertise_addrs")]
        public sealed class advertise_addrs : nterraform.Core.structure
        {
            public advertise_addrs()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "rpc", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Rpc { get; }

            [nterraform.Core.TerraformProperty(name: "serf_lan", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @SerfLan { get; }

            [nterraform.Core.TerraformProperty(name: "serf_wan", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @SerfWan { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "retry_join_ec2")]
        public sealed class retry_join_ec2 : nterraform.Core.structure
        {
            public retry_join_ec2()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "region", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Region { get; }

            [nterraform.Core.TerraformProperty(name: "tag_key", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @TagKey { get; }

            [nterraform.Core.TerraformProperty(name: "tag_value", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @TagValue { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "retry_join_gce")]
        public sealed class retry_join_gce : nterraform.Core.structure
        {
            public retry_join_gce()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "credentials_file", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @CredentialsFile { get; }

            [nterraform.Core.TerraformProperty(name: "project_name", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @ProjectName { get; }

            [nterraform.Core.TerraformProperty(name: "tag_value", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @TagValue { get; }

            [nterraform.Core.TerraformProperty(name: "zone_pattern", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @ZonePattern { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "ports")]
        public sealed class ports : nterraform.Core.structure
        {
            public ports()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "dns", @out: true, min: 0, max: 1)]
            public FSharpOption<int> @Dns { get; }

            [nterraform.Core.TerraformProperty(name: "http", @out: true, min: 0, max: 1)]
            public FSharpOption<int> @Http { get; }

            [nterraform.Core.TerraformProperty(name: "https", @out: true, min: 0, max: 1)]
            public FSharpOption<int> @Https { get; }

            [nterraform.Core.TerraformProperty(name: "rpc", @out: true, min: 0, max: 1)]
            public FSharpOption<int> @Rpc { get; }

            [nterraform.Core.TerraformProperty(name: "serf_lan", @out: true, min: 0, max: 1)]
            public FSharpOption<int> @SerfLan { get; }

            [nterraform.Core.TerraformProperty(name: "serf_wan", @out: true, min: 0, max: 1)]
            public FSharpOption<int> @SerfWan { get; }

            [nterraform.Core.TerraformProperty(name: "server", @out: true, min: 0, max: 1)]
            public FSharpOption<int> @Server { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "dns")]
        public sealed class dns : nterraform.Core.structure
        {
            public dns()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "allow_stale", @out: true, min: 0, max: 1)]
            public FSharpOption<bool> @AllowStale { get; }

            [nterraform.Core.TerraformProperty(name: "enable_compression", @out: true, min: 0, max: 1)]
            public FSharpOption<bool> @EnableCompression { get; }

            [nterraform.Core.TerraformProperty(name: "enable_truncate", @out: true, min: 0, max: 1)]
            public FSharpOption<bool> @EnableTruncate { get; }

            [nterraform.Core.TerraformProperty(name: "max_stale", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @MaxStale { get; }

            [nterraform.Core.TerraformProperty(name: "node_ttl", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @NodeTtl { get; }

            [nterraform.Core.TerraformProperty(name: "only_passing", @out: true, min: 0, max: 1)]
            public FSharpOption<bool> @OnlyPassing { get; }

            [nterraform.Core.TerraformProperty(name: "recursor_timeout", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @RecursorTimeout { get; }

            [nterraform.Core.TerraformProperty(name: "service_ttl", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @ServiceTtl { get; }

            [nterraform.Core.TerraformProperty(name: "udp_answer_limit", @out: true, min: 0, max: 1)]
            public FSharpOption<int> @UdpAnswerLimit { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "addresses")]
        public sealed class addresses : nterraform.Core.structure
        {
            public addresses()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "dns", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Dns { get; }

            [nterraform.Core.TerraformProperty(name: "http", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Http { get; }

            [nterraform.Core.TerraformProperty(name: "https", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Https { get; }

            [nterraform.Core.TerraformProperty(name: "rpc", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Rpc { get; }
        }

        public consul_agent_self(FSharpOption<FSharpMap<string,addresses>> @addresses = null,
                                 FSharpOption<FSharpMap<string,advertise_addrs>> @advertiseAddrs = null,
                                 FSharpOption<FSharpMap<string,dns>> @dns = null,
                                 FSharpOption<FSharpMap<string,performance>> @performance = null,
                                 FSharpOption<FSharpMap<string,ports>> @ports = null,
                                 FSharpOption<FSharpMap<string,retry_join_ec2>> @retryJoinEc2 = null,
                                 FSharpOption<FSharpMap<string,retry_join_gce>> @retryJoinGce = null,
                                 FSharpOption<FSharpMap<string,tagged_addresses>> @taggedAddresses = null,
                                 FSharpOption<FSharpMap<string,telemetry>> @telemetry = null,
                                 FSharpOption<FSharpMap<string,unix_sockets>> @unixSockets = null)
        {
            @Addresses = @addresses ?? MapModule.Empty<string,addresses>();
            @AdvertiseAddrs = @advertiseAddrs ?? MapModule.Empty<string,advertise_addrs>();
            @Dns = @dns ?? MapModule.Empty<string,dns>();
            @Performance = @performance ?? MapModule.Empty<string,performance>();
            @Ports = @ports ?? MapModule.Empty<string,ports>();
            @RetryJoinEc2 = @retryJoinEc2 ?? MapModule.Empty<string,retry_join_ec2>();
            @RetryJoinGce = @retryJoinGce ?? MapModule.Empty<string,retry_join_gce>();
            @TaggedAddresses = @taggedAddresses ?? MapModule.Empty<string,tagged_addresses>();
            @Telemetry = @telemetry ?? MapModule.Empty<string,telemetry>();
            @UnixSockets = @unixSockets ?? MapModule.Empty<string,unix_sockets>();
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "acl_datacenter", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @AclDatacenter { get; }

        [nterraform.Core.TerraformProperty(name: "acl_default_policy", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @AclDefaultPolicy { get; }

        [nterraform.Core.TerraformProperty(name: "acl_disabled_ttl", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @AclDisabledTtl { get; }

        [nterraform.Core.TerraformProperty(name: "acl_down_policy", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @AclDownPolicy { get; }

        [nterraform.Core.TerraformProperty(name: "acl_enforce_0_8_semantics", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @AclEnforce08Semantics { get; }

        [nterraform.Core.TerraformProperty(name: "acl_ttl", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @AclTtl { get; }

        [nterraform.Core.TerraformProperty(name: "addresses", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpMap<string,addresses>> @Addresses { get; }

        [nterraform.Core.TerraformProperty(name: "advertise_addr", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @AdvertiseAddr { get; }

        [nterraform.Core.TerraformProperty(name: "advertise_addr_wan", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @AdvertiseAddrWan { get; }

        [nterraform.Core.TerraformProperty(name: "advertise_addrs", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpMap<string,advertise_addrs>> @AdvertiseAddrs { get; }

        [nterraform.Core.TerraformProperty(name: "atlas_join", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @AtlasJoin { get; }

        [nterraform.Core.TerraformProperty(name: "bind_addr", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @BindAddr { get; }

        [nterraform.Core.TerraformProperty(name: "bootstrap_expect", @out: true, min: 0, max: 1)]
        public FSharpOption<int> @BootstrapExpect { get; }

        [nterraform.Core.TerraformProperty(name: "bootstrap_mode", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @BootstrapMode { get; }

        [nterraform.Core.TerraformProperty(name: "check_deregister_interval_min", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @CheckDeregisterIntervalMin { get; }

        [nterraform.Core.TerraformProperty(name: "check_reap_interval", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @CheckReapInterval { get; }

        [nterraform.Core.TerraformProperty(name: "check_update_interval", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @CheckUpdateInterval { get; }

        [nterraform.Core.TerraformProperty(name: "client_addr", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @ClientAddr { get; }

        [nterraform.Core.TerraformProperty(name: "data_dir", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @DataDir { get; }

        [nterraform.Core.TerraformProperty(name: "datacenter", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Datacenter { get; }

        [nterraform.Core.TerraformProperty(name: "dev_mode", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @DevMode { get; }

        [nterraform.Core.TerraformProperty(name: "dns", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpMap<string,dns>> @Dns { get; }

        [nterraform.Core.TerraformProperty(name: "dns_recursors", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpList<string>> @DnsRecursors { get; }

        [nterraform.Core.TerraformProperty(name: "domain", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Domain { get; }

        [nterraform.Core.TerraformProperty(name: "enable_anonymous_signature", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @EnableAnonymousSignature { get; }

        [nterraform.Core.TerraformProperty(name: "enable_coordinates", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @EnableCoordinates { get; }

        [nterraform.Core.TerraformProperty(name: "enable_debug", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @EnableDebug { get; }

        [nterraform.Core.TerraformProperty(name: "enable_remote_exec", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @EnableRemoteExec { get; }

        [nterraform.Core.TerraformProperty(name: "enable_syslog", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @EnableSyslog { get; }

        [nterraform.Core.TerraformProperty(name: "enable_ui", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @EnableUi { get; }

        [nterraform.Core.TerraformProperty(name: "enable_update_check", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @EnableUpdateCheck { get; }

        [nterraform.Core.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Id { get; }

        [nterraform.Core.TerraformProperty(name: "leave_on_int", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @LeaveOnInt { get; }

        [nterraform.Core.TerraformProperty(name: "leave_on_term", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @LeaveOnTerm { get; }

        [nterraform.Core.TerraformProperty(name: "log_level", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @LogLevel { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Name { get; }

        [nterraform.Core.TerraformProperty(name: "performance", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpMap<string,performance>> @Performance { get; }

        [nterraform.Core.TerraformProperty(name: "pid_file", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @PidFile { get; }

        [nterraform.Core.TerraformProperty(name: "ports", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpMap<string,ports>> @Ports { get; }

        [nterraform.Core.TerraformProperty(name: "protocol_version", @out: true, min: 0, max: 1)]
        public FSharpOption<int> @ProtocolVersion { get; }

        [nterraform.Core.TerraformProperty(name: "reconnect_timeout_lan", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @ReconnectTimeoutLan { get; }

        [nterraform.Core.TerraformProperty(name: "reconnect_timeout_wan", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @ReconnectTimeoutWan { get; }

        [nterraform.Core.TerraformProperty(name: "rejoin_after_leave", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @RejoinAfterLeave { get; }

        [nterraform.Core.TerraformProperty(name: "retry_join", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpList<string>> @RetryJoin { get; }

        [nterraform.Core.TerraformProperty(name: "retry_join_ec2", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpMap<string,retry_join_ec2>> @RetryJoinEc2 { get; }

        [nterraform.Core.TerraformProperty(name: "retry_join_gce", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpMap<string,retry_join_gce>> @RetryJoinGce { get; }

        [nterraform.Core.TerraformProperty(name: "retry_join_wan", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpList<string>> @RetryJoinWan { get; }

        [nterraform.Core.TerraformProperty(name: "retry_max_attempts", @out: true, min: 0, max: 1)]
        public FSharpOption<int> @RetryMaxAttempts { get; }

        [nterraform.Core.TerraformProperty(name: "retry_max_attempts_wan", @out: true, min: 0, max: 1)]
        public FSharpOption<int> @RetryMaxAttemptsWan { get; }

        [nterraform.Core.TerraformProperty(name: "serf_lan_bind_addr", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @SerfLanBindAddr { get; }

        [nterraform.Core.TerraformProperty(name: "serf_wan_bind_addr", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @SerfWanBindAddr { get; }

        [nterraform.Core.TerraformProperty(name: "server_mode", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @ServerMode { get; }

        [nterraform.Core.TerraformProperty(name: "server_name", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @ServerName { get; }

        [nterraform.Core.TerraformProperty(name: "session_ttl_min", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @SessionTtlMin { get; }

        [nterraform.Core.TerraformProperty(name: "start_join", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpList<string>> @StartJoin { get; }

        [nterraform.Core.TerraformProperty(name: "start_join_wan", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpList<string>> @StartJoinWan { get; }

        [nterraform.Core.TerraformProperty(name: "syslog_facility", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @SyslogFacility { get; }

        [nterraform.Core.TerraformProperty(name: "tagged_addresses", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpMap<string,tagged_addresses>> @TaggedAddresses { get; }

        [nterraform.Core.TerraformProperty(name: "telemetry", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpMap<string,telemetry>> @Telemetry { get; }

        [nterraform.Core.TerraformProperty(name: "tls_ca_file", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @TlsCaFile { get; }

        [nterraform.Core.TerraformProperty(name: "tls_cert_file", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @TlsCertFile { get; }

        [nterraform.Core.TerraformProperty(name: "tls_key_file", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @TlsKeyFile { get; }

        [nterraform.Core.TerraformProperty(name: "tls_min_version", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @TlsMinVersion { get; }

        [nterraform.Core.TerraformProperty(name: "tls_verify_incoming", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @TlsVerifyIncoming { get; }

        [nterraform.Core.TerraformProperty(name: "tls_verify_outgoing", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @TlsVerifyOutgoing { get; }

        [nterraform.Core.TerraformProperty(name: "tls_verify_server_hostname", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @TlsVerifyServerHostname { get; }

        [nterraform.Core.TerraformProperty(name: "translate_wan_addrs", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @TranslateWanAddrs { get; }

        [nterraform.Core.TerraformProperty(name: "ui_dir", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @UiDir { get; }

        [nterraform.Core.TerraformProperty(name: "unix_sockets", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpMap<string,unix_sockets>> @UnixSockets { get; }

        [nterraform.Core.TerraformProperty(name: "version", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Version { get; }

        [nterraform.Core.TerraformProperty(name: "version_prerelease", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @VersionPrerelease { get; }

        [nterraform.Core.TerraformProperty(name: "version_revision", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @VersionRevision { get; }
    }

}
