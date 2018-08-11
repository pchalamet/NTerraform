using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "consul_agent_self")]
    public sealed class consul_agent_self : NTerraform.data
    {
        [TerraformStructure(category: "", typeName: "tagged_addresses")]
        public sealed class tagged_addresses
        {
            public tagged_addresses()
            {
            }

            [TerraformProperty(name: "lan", @out: true, min: 0, max: 1)]
            public string @Lan { get; }

            [TerraformProperty(name: "wan", @out: true, min: 0, max: 1)]
            public string @Wan { get; }
        }

        [TerraformStructure(category: "", typeName: "dns")]
        public sealed class dns
        {
            public dns()
            {
            }

            [TerraformProperty(name: "allow_stale", @out: true, min: 0, max: 1)]
            public bool? @AllowStale { get; }

            [TerraformProperty(name: "enable_compression", @out: true, min: 0, max: 1)]
            public bool? @EnableCompression { get; }

            [TerraformProperty(name: "enable_truncate", @out: true, min: 0, max: 1)]
            public bool? @EnableTruncate { get; }

            [TerraformProperty(name: "max_stale", @out: true, min: 0, max: 1)]
            public string @MaxStale { get; }

            [TerraformProperty(name: "node_ttl", @out: true, min: 0, max: 1)]
            public string @NodeTtl { get; }

            [TerraformProperty(name: "only_passing", @out: true, min: 0, max: 1)]
            public bool? @OnlyPassing { get; }

            [TerraformProperty(name: "recursor_timeout", @out: true, min: 0, max: 1)]
            public string @RecursorTimeout { get; }

            [TerraformProperty(name: "service_ttl", @out: true, min: 0, max: 1)]
            public string @ServiceTtl { get; }

            [TerraformProperty(name: "udp_answer_limit", @out: true, min: 0, max: 1)]
            public int? @UdpAnswerLimit { get; }
        }

        [TerraformStructure(category: "", typeName: "addresses")]
        public sealed class addresses
        {
            public addresses()
            {
            }

            [TerraformProperty(name: "dns", @out: true, min: 0, max: 1)]
            public string @Dns { get; }

            [TerraformProperty(name: "http", @out: true, min: 0, max: 1)]
            public string @Http { get; }

            [TerraformProperty(name: "https", @out: true, min: 0, max: 1)]
            public string @Https { get; }

            [TerraformProperty(name: "rpc", @out: true, min: 0, max: 1)]
            public string @Rpc { get; }
        }

        [TerraformStructure(category: "", typeName: "retry_join_gce")]
        public sealed class retry_join_gce
        {
            public retry_join_gce()
            {
            }

            [TerraformProperty(name: "credentials_file", @out: true, min: 0, max: 1)]
            public string @CredentialsFile { get; }

            [TerraformProperty(name: "project_name", @out: true, min: 0, max: 1)]
            public string @ProjectName { get; }

            [TerraformProperty(name: "tag_value", @out: true, min: 0, max: 1)]
            public string @TagValue { get; }

            [TerraformProperty(name: "zone_pattern", @out: true, min: 0, max: 1)]
            public string @ZonePattern { get; }
        }

        [TerraformStructure(category: "", typeName: "performance")]
        public sealed class performance
        {
            public performance()
            {
            }

            [TerraformProperty(name: "raft_multiplier", @out: true, min: 0, max: 1)]
            public string @RaftMultiplier { get; }
        }

        [TerraformStructure(category: "", typeName: "advertise_addrs")]
        public sealed class advertise_addrs
        {
            public advertise_addrs()
            {
            }

            [TerraformProperty(name: "rpc", @out: true, min: 0, max: 1)]
            public string @Rpc { get; }

            [TerraformProperty(name: "serf_lan", @out: true, min: 0, max: 1)]
            public string @SerfLan { get; }

            [TerraformProperty(name: "serf_wan", @out: true, min: 0, max: 1)]
            public string @SerfWan { get; }
        }

        [TerraformStructure(category: "", typeName: "ports")]
        public sealed class ports
        {
            public ports()
            {
            }

            [TerraformProperty(name: "dns", @out: true, min: 0, max: 1)]
            public int? @Dns { get; }

            [TerraformProperty(name: "http", @out: true, min: 0, max: 1)]
            public int? @Http { get; }

            [TerraformProperty(name: "https", @out: true, min: 0, max: 1)]
            public int? @Https { get; }

            [TerraformProperty(name: "rpc", @out: true, min: 0, max: 1)]
            public int? @Rpc { get; }

            [TerraformProperty(name: "serf_lan", @out: true, min: 0, max: 1)]
            public int? @SerfLan { get; }

            [TerraformProperty(name: "serf_wan", @out: true, min: 0, max: 1)]
            public int? @SerfWan { get; }

            [TerraformProperty(name: "server", @out: true, min: 0, max: 1)]
            public int? @Server { get; }
        }

        [TerraformStructure(category: "", typeName: "unix_sockets")]
        public sealed class unix_sockets
        {
            public unix_sockets()
            {
            }

            [TerraformProperty(name: "group", @out: true, min: 0, max: 1)]
            public string @Group { get; }

            [TerraformProperty(name: "mode", @out: true, min: 0, max: 1)]
            public string @Mode { get; }

            [TerraformProperty(name: "user", @out: true, min: 0, max: 1)]
            public string @User { get; }
        }

        [TerraformStructure(category: "", typeName: "telemetry")]
        public sealed class telemetry
        {
            public telemetry()
            {
            }

            [TerraformProperty(name: "circonus_api_app", @out: true, min: 0, max: 1)]
            public string @CirconusApiApp { get; }

            [TerraformProperty(name: "circonus_api_token", @out: true, min: 0, max: 1)]
            public string @CirconusApiToken { get; }

            [TerraformProperty(name: "circonus_api_url", @out: true, min: 0, max: 1)]
            public string @CirconusApiUrl { get; }

            [TerraformProperty(name: "circonus_broker_id", @out: true, min: 0, max: 1)]
            public string @CirconusBrokerId { get; }

            [TerraformProperty(name: "circonus_check_id", @out: true, min: 0, max: 1)]
            public string @CirconusCheckId { get; }

            [TerraformProperty(name: "circonus_check_tags", @out: true, min: 0, max: 1)]
            public string @CirconusCheckTags { get; }

            [TerraformProperty(name: "circonus_display_name", @out: true, min: 0, max: 1)]
            public string @CirconusDisplayName { get; }

            [TerraformProperty(name: "circonus_force_metric_activation", @out: true, min: 0, max: 1)]
            public bool? @CirconusForceMetricActivation { get; }

            [TerraformProperty(name: "circonus_instance_id", @out: true, min: 0, max: 1)]
            public string @CirconusInstanceId { get; }

            [TerraformProperty(name: "circonus_search_tag", @out: true, min: 0, max: 1)]
            public string @CirconusSearchTag { get; }

            [TerraformProperty(name: "circonus_select_tag", @out: true, min: 0, max: 1)]
            public string @CirconusSelectTag { get; }

            [TerraformProperty(name: "circonus_submission_interval", @out: true, min: 0, max: 1)]
            public string @CirconusSubmissionInterval { get; }

            [TerraformProperty(name: "circonus_submission_url", @out: true, min: 0, max: 1)]
            public string @CirconusSubmissionUrl { get; }

            [TerraformProperty(name: "dogstatsd_addr", @out: true, min: 0, max: 1)]
            public string @DogstatsdAddr { get; }

            [TerraformProperty(name: "dogstatsd_tags", @out: true, min: 0, max: 1)]
            public string[] @DogstatsdTags { get; }

            [TerraformProperty(name: "enable_hostname", @out: true, min: 0, max: 1)]
            public string @EnableHostname { get; }

            [TerraformProperty(name: "statsd_addr", @out: true, min: 0, max: 1)]
            public string @StatsdAddr { get; }

            [TerraformProperty(name: "statsite_addr", @out: true, min: 0, max: 1)]
            public string @StatsiteAddr { get; }

            [TerraformProperty(name: "statsite_prefix", @out: true, min: 0, max: 1)]
            public string @StatsitePrefix { get; }
        }

        [TerraformStructure(category: "", typeName: "retry_join_ec2")]
        public sealed class retry_join_ec2
        {
            public retry_join_ec2()
            {
            }

            [TerraformProperty(name: "region", @out: true, min: 0, max: 1)]
            public string @Region { get; }

            [TerraformProperty(name: "tag_key", @out: true, min: 0, max: 1)]
            public string @TagKey { get; }

            [TerraformProperty(name: "tag_value", @out: true, min: 0, max: 1)]
            public string @TagValue { get; }
        }

        public consul_agent_self(Dictionary<string,addresses> @addresses = null,
                                 Dictionary<string,advertise_addrs> @advertiseAddrs = null,
                                 Dictionary<string,dns> @dns = null,
                                 Dictionary<string,performance> @performance = null,
                                 Dictionary<string,ports> @ports = null,
                                 Dictionary<string,retry_join_ec2> @retryJoinEc2 = null,
                                 Dictionary<string,retry_join_gce> @retryJoinGce = null,
                                 Dictionary<string,tagged_addresses> @taggedAddresses = null,
                                 Dictionary<string,telemetry> @telemetry = null,
                                 Dictionary<string,unix_sockets> @unixSockets = null)
        {
            @Addresses = @addresses;
            @AdvertiseAddrs = @advertiseAddrs;
            @Dns = @dns;
            @Performance = @performance;
            @Ports = @ports;
            @RetryJoinEc2 = @retryJoinEc2;
            @RetryJoinGce = @retryJoinGce;
            @TaggedAddresses = @taggedAddresses;
            @Telemetry = @telemetry;
            @UnixSockets = @unixSockets;
        }

        [TerraformProperty(name: "acl_datacenter", @out: true, min: 0, max: 1)]
        public string @AclDatacenter { get; }

        [TerraformProperty(name: "acl_default_policy", @out: true, min: 0, max: 1)]
        public string @AclDefaultPolicy { get; }

        [TerraformProperty(name: "acl_disabled_ttl", @out: true, min: 0, max: 1)]
        public string @AclDisabledTtl { get; }

        [TerraformProperty(name: "acl_down_policy", @out: true, min: 0, max: 1)]
        public string @AclDownPolicy { get; }

        [TerraformProperty(name: "acl_enforce_0_8_semantics", @out: true, min: 0, max: 1)]
        public bool? @AclEnforce08Semantics { get; }

        [TerraformProperty(name: "acl_ttl", @out: true, min: 0, max: 1)]
        public string @AclTtl { get; }

        [TerraformProperty(name: "addresses", @out: false, min: 0, max: 0)]
        public Dictionary<string,addresses> @Addresses { get; }

        [TerraformProperty(name: "advertise_addr", @out: true, min: 0, max: 1)]
        public string @AdvertiseAddr { get; }

        [TerraformProperty(name: "advertise_addr_wan", @out: true, min: 0, max: 1)]
        public string @AdvertiseAddrWan { get; }

        [TerraformProperty(name: "advertise_addrs", @out: false, min: 0, max: 0)]
        public Dictionary<string,advertise_addrs> @AdvertiseAddrs { get; }

        [TerraformProperty(name: "atlas_join", @out: true, min: 0, max: 1)]
        public bool? @AtlasJoin { get; }

        [TerraformProperty(name: "bind_addr", @out: true, min: 0, max: 1)]
        public string @BindAddr { get; }

        [TerraformProperty(name: "bootstrap_expect", @out: true, min: 0, max: 1)]
        public int? @BootstrapExpect { get; }

        [TerraformProperty(name: "bootstrap_mode", @out: true, min: 0, max: 1)]
        public bool? @BootstrapMode { get; }

        [TerraformProperty(name: "check_deregister_interval_min", @out: true, min: 0, max: 1)]
        public string @CheckDeregisterIntervalMin { get; }

        [TerraformProperty(name: "check_reap_interval", @out: true, min: 0, max: 1)]
        public string @CheckReapInterval { get; }

        [TerraformProperty(name: "check_update_interval", @out: true, min: 0, max: 1)]
        public string @CheckUpdateInterval { get; }

        [TerraformProperty(name: "client_addr", @out: true, min: 0, max: 1)]
        public string @ClientAddr { get; }

        [TerraformProperty(name: "data_dir", @out: true, min: 0, max: 1)]
        public string @DataDir { get; }

        [TerraformProperty(name: "datacenter", @out: true, min: 0, max: 1)]
        public string @Datacenter { get; }

        [TerraformProperty(name: "dev_mode", @out: true, min: 0, max: 1)]
        public bool? @DevMode { get; }

        [TerraformProperty(name: "dns", @out: false, min: 0, max: 0)]
        public Dictionary<string,dns> @Dns { get; }

        [TerraformProperty(name: "dns_recursors", @out: true, min: 0, max: 1)]
        public string[] @DnsRecursors { get; }

        [TerraformProperty(name: "domain", @out: true, min: 0, max: 1)]
        public string @Domain { get; }

        [TerraformProperty(name: "enable_anonymous_signature", @out: true, min: 0, max: 1)]
        public bool? @EnableAnonymousSignature { get; }

        [TerraformProperty(name: "enable_coordinates", @out: true, min: 0, max: 1)]
        public bool? @EnableCoordinates { get; }

        [TerraformProperty(name: "enable_debug", @out: true, min: 0, max: 1)]
        public bool? @EnableDebug { get; }

        [TerraformProperty(name: "enable_remote_exec", @out: true, min: 0, max: 1)]
        public bool? @EnableRemoteExec { get; }

        [TerraformProperty(name: "enable_syslog", @out: true, min: 0, max: 1)]
        public bool? @EnableSyslog { get; }

        [TerraformProperty(name: "enable_ui", @out: true, min: 0, max: 1)]
        public bool? @EnableUi { get; }

        [TerraformProperty(name: "enable_update_check", @out: true, min: 0, max: 1)]
        public bool? @EnableUpdateCheck { get; }

        [TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
        public string @Id { get; }

        [TerraformProperty(name: "leave_on_int", @out: true, min: 0, max: 1)]
        public bool? @LeaveOnInt { get; }

        [TerraformProperty(name: "leave_on_term", @out: true, min: 0, max: 1)]
        public bool? @LeaveOnTerm { get; }

        [TerraformProperty(name: "log_level", @out: true, min: 0, max: 1)]
        public string @LogLevel { get; }

        [TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "performance", @out: false, min: 0, max: 0)]
        public Dictionary<string,performance> @Performance { get; }

        [TerraformProperty(name: "pid_file", @out: true, min: 0, max: 1)]
        public string @PidFile { get; }

        [TerraformProperty(name: "ports", @out: false, min: 0, max: 0)]
        public Dictionary<string,ports> @Ports { get; }

        [TerraformProperty(name: "protocol_version", @out: true, min: 0, max: 1)]
        public int? @ProtocolVersion { get; }

        [TerraformProperty(name: "reconnect_timeout_lan", @out: true, min: 0, max: 1)]
        public string @ReconnectTimeoutLan { get; }

        [TerraformProperty(name: "reconnect_timeout_wan", @out: true, min: 0, max: 1)]
        public string @ReconnectTimeoutWan { get; }

        [TerraformProperty(name: "rejoin_after_leave", @out: true, min: 0, max: 1)]
        public bool? @RejoinAfterLeave { get; }

        [TerraformProperty(name: "retry_join", @out: true, min: 0, max: 1)]
        public string[] @RetryJoin { get; }

        [TerraformProperty(name: "retry_join_ec2", @out: false, min: 0, max: 0)]
        public Dictionary<string,retry_join_ec2> @RetryJoinEc2 { get; }

        [TerraformProperty(name: "retry_join_gce", @out: false, min: 0, max: 0)]
        public Dictionary<string,retry_join_gce> @RetryJoinGce { get; }

        [TerraformProperty(name: "retry_join_wan", @out: true, min: 0, max: 1)]
        public string[] @RetryJoinWan { get; }

        [TerraformProperty(name: "retry_max_attempts", @out: true, min: 0, max: 1)]
        public int? @RetryMaxAttempts { get; }

        [TerraformProperty(name: "retry_max_attempts_wan", @out: true, min: 0, max: 1)]
        public int? @RetryMaxAttemptsWan { get; }

        [TerraformProperty(name: "serf_lan_bind_addr", @out: true, min: 0, max: 1)]
        public string @SerfLanBindAddr { get; }

        [TerraformProperty(name: "serf_wan_bind_addr", @out: true, min: 0, max: 1)]
        public string @SerfWanBindAddr { get; }

        [TerraformProperty(name: "server_mode", @out: true, min: 0, max: 1)]
        public bool? @ServerMode { get; }

        [TerraformProperty(name: "server_name", @out: true, min: 0, max: 1)]
        public string @ServerName { get; }

        [TerraformProperty(name: "session_ttl_min", @out: true, min: 0, max: 1)]
        public string @SessionTtlMin { get; }

        [TerraformProperty(name: "start_join", @out: true, min: 0, max: 1)]
        public string[] @StartJoin { get; }

        [TerraformProperty(name: "start_join_wan", @out: true, min: 0, max: 1)]
        public string[] @StartJoinWan { get; }

        [TerraformProperty(name: "syslog_facility", @out: true, min: 0, max: 1)]
        public string @SyslogFacility { get; }

        [TerraformProperty(name: "tagged_addresses", @out: false, min: 0, max: 0)]
        public Dictionary<string,tagged_addresses> @TaggedAddresses { get; }

        [TerraformProperty(name: "telemetry", @out: false, min: 0, max: 0)]
        public Dictionary<string,telemetry> @Telemetry { get; }

        [TerraformProperty(name: "tls_ca_file", @out: true, min: 0, max: 1)]
        public string @TlsCaFile { get; }

        [TerraformProperty(name: "tls_cert_file", @out: true, min: 0, max: 1)]
        public string @TlsCertFile { get; }

        [TerraformProperty(name: "tls_key_file", @out: true, min: 0, max: 1)]
        public string @TlsKeyFile { get; }

        [TerraformProperty(name: "tls_min_version", @out: true, min: 0, max: 1)]
        public string @TlsMinVersion { get; }

        [TerraformProperty(name: "tls_verify_incoming", @out: true, min: 0, max: 1)]
        public bool? @TlsVerifyIncoming { get; }

        [TerraformProperty(name: "tls_verify_outgoing", @out: true, min: 0, max: 1)]
        public bool? @TlsVerifyOutgoing { get; }

        [TerraformProperty(name: "tls_verify_server_hostname", @out: true, min: 0, max: 1)]
        public bool? @TlsVerifyServerHostname { get; }

        [TerraformProperty(name: "translate_wan_addrs", @out: true, min: 0, max: 1)]
        public bool? @TranslateWanAddrs { get; }

        [TerraformProperty(name: "ui_dir", @out: true, min: 0, max: 1)]
        public string @UiDir { get; }

        [TerraformProperty(name: "unix_sockets", @out: false, min: 0, max: 0)]
        public Dictionary<string,unix_sockets> @UnixSockets { get; }

        [TerraformProperty(name: "version", @out: true, min: 0, max: 1)]
        public string @Version { get; }

        [TerraformProperty(name: "version_prerelease", @out: true, min: 0, max: 1)]
        public string @VersionPrerelease { get; }

        [TerraformProperty(name: "version_revision", @out: true, min: 0, max: 1)]
        public string @VersionRevision { get; }
    }

}
