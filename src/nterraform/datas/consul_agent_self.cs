using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "consul_agent_self")]
    public sealed class consul_agent_self : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "dns")]
        public sealed class dns : nterraform.structure
        {
            public dns()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "allow_stale", @out: true, min: 0, max: 1)]
            public bool? @AllowStale { get; }

            [nterraform.TerraformProperty(name: "enable_compression", @out: true, min: 0, max: 1)]
            public bool? @EnableCompression { get; }

            [nterraform.TerraformProperty(name: "enable_truncate", @out: true, min: 0, max: 1)]
            public bool? @EnableTruncate { get; }

            [nterraform.TerraformProperty(name: "max_stale", @out: true, min: 0, max: 1)]
            public string @MaxStale { get; }

            [nterraform.TerraformProperty(name: "node_ttl", @out: true, min: 0, max: 1)]
            public string @NodeTtl { get; }

            [nterraform.TerraformProperty(name: "only_passing", @out: true, min: 0, max: 1)]
            public bool? @OnlyPassing { get; }

            [nterraform.TerraformProperty(name: "recursor_timeout", @out: true, min: 0, max: 1)]
            public string @RecursorTimeout { get; }

            [nterraform.TerraformProperty(name: "service_ttl", @out: true, min: 0, max: 1)]
            public string @ServiceTtl { get; }

            [nterraform.TerraformProperty(name: "udp_answer_limit", @out: true, min: 0, max: 1)]
            public int? @UdpAnswerLimit { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "retry_join_gce")]
        public sealed class retry_join_gce : nterraform.structure
        {
            public retry_join_gce()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "credentials_file", @out: true, min: 0, max: 1)]
            public string @CredentialsFile { get; }

            [nterraform.TerraformProperty(name: "project_name", @out: true, min: 0, max: 1)]
            public string @ProjectName { get; }

            [nterraform.TerraformProperty(name: "tag_value", @out: true, min: 0, max: 1)]
            public string @TagValue { get; }

            [nterraform.TerraformProperty(name: "zone_pattern", @out: true, min: 0, max: 1)]
            public string @ZonePattern { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "advertise_addrs")]
        public sealed class advertise_addrs : nterraform.structure
        {
            public advertise_addrs()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "rpc", @out: true, min: 0, max: 1)]
            public string @Rpc { get; }

            [nterraform.TerraformProperty(name: "serf_lan", @out: true, min: 0, max: 1)]
            public string @SerfLan { get; }

            [nterraform.TerraformProperty(name: "serf_wan", @out: true, min: 0, max: 1)]
            public string @SerfWan { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "addresses")]
        public sealed class addresses : nterraform.structure
        {
            public addresses()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "dns", @out: true, min: 0, max: 1)]
            public string @Dns { get; }

            [nterraform.TerraformProperty(name: "http", @out: true, min: 0, max: 1)]
            public string @Http { get; }

            [nterraform.TerraformProperty(name: "https", @out: true, min: 0, max: 1)]
            public string @Https { get; }

            [nterraform.TerraformProperty(name: "rpc", @out: true, min: 0, max: 1)]
            public string @Rpc { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "performance")]
        public sealed class performance : nterraform.structure
        {
            public performance()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "raft_multiplier", @out: true, min: 0, max: 1)]
            public string @RaftMultiplier { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "unix_sockets")]
        public sealed class unix_sockets : nterraform.structure
        {
            public unix_sockets()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "group", @out: true, min: 0, max: 1)]
            public string @Group { get; }

            [nterraform.TerraformProperty(name: "mode", @out: true, min: 0, max: 1)]
            public string @Mode { get; }

            [nterraform.TerraformProperty(name: "user", @out: true, min: 0, max: 1)]
            public string @User { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "ports")]
        public sealed class ports : nterraform.structure
        {
            public ports()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "dns", @out: true, min: 0, max: 1)]
            public int? @Dns { get; }

            [nterraform.TerraformProperty(name: "http", @out: true, min: 0, max: 1)]
            public int? @Http { get; }

            [nterraform.TerraformProperty(name: "https", @out: true, min: 0, max: 1)]
            public int? @Https { get; }

            [nterraform.TerraformProperty(name: "rpc", @out: true, min: 0, max: 1)]
            public int? @Rpc { get; }

            [nterraform.TerraformProperty(name: "serf_lan", @out: true, min: 0, max: 1)]
            public int? @SerfLan { get; }

            [nterraform.TerraformProperty(name: "serf_wan", @out: true, min: 0, max: 1)]
            public int? @SerfWan { get; }

            [nterraform.TerraformProperty(name: "server", @out: true, min: 0, max: 1)]
            public int? @Server { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "retry_join_ec2")]
        public sealed class retry_join_ec2 : nterraform.structure
        {
            public retry_join_ec2()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "region", @out: true, min: 0, max: 1)]
            public string @Region { get; }

            [nterraform.TerraformProperty(name: "tag_key", @out: true, min: 0, max: 1)]
            public string @TagKey { get; }

            [nterraform.TerraformProperty(name: "tag_value", @out: true, min: 0, max: 1)]
            public string @TagValue { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "telemetry")]
        public sealed class telemetry : nterraform.structure
        {
            public telemetry()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "circonus_api_app", @out: true, min: 0, max: 1)]
            public string @CirconusApiApp { get; }

            [nterraform.TerraformProperty(name: "circonus_api_token", @out: true, min: 0, max: 1)]
            public string @CirconusApiToken { get; }

            [nterraform.TerraformProperty(name: "circonus_api_url", @out: true, min: 0, max: 1)]
            public string @CirconusApiUrl { get; }

            [nterraform.TerraformProperty(name: "circonus_broker_id", @out: true, min: 0, max: 1)]
            public string @CirconusBrokerId { get; }

            [nterraform.TerraformProperty(name: "circonus_check_id", @out: true, min: 0, max: 1)]
            public string @CirconusCheckId { get; }

            [nterraform.TerraformProperty(name: "circonus_check_tags", @out: true, min: 0, max: 1)]
            public string @CirconusCheckTags { get; }

            [nterraform.TerraformProperty(name: "circonus_display_name", @out: true, min: 0, max: 1)]
            public string @CirconusDisplayName { get; }

            [nterraform.TerraformProperty(name: "circonus_force_metric_activation", @out: true, min: 0, max: 1)]
            public bool? @CirconusForceMetricActivation { get; }

            [nterraform.TerraformProperty(name: "circonus_instance_id", @out: true, min: 0, max: 1)]
            public string @CirconusInstanceId { get; }

            [nterraform.TerraformProperty(name: "circonus_search_tag", @out: true, min: 0, max: 1)]
            public string @CirconusSearchTag { get; }

            [nterraform.TerraformProperty(name: "circonus_select_tag", @out: true, min: 0, max: 1)]
            public string @CirconusSelectTag { get; }

            [nterraform.TerraformProperty(name: "circonus_submission_interval", @out: true, min: 0, max: 1)]
            public string @CirconusSubmissionInterval { get; }

            [nterraform.TerraformProperty(name: "circonus_submission_url", @out: true, min: 0, max: 1)]
            public string @CirconusSubmissionUrl { get; }

            [nterraform.TerraformProperty(name: "dogstatsd_addr", @out: true, min: 0, max: 1)]
            public string @DogstatsdAddr { get; }

            [nterraform.TerraformProperty(name: "dogstatsd_tags", @out: true, min: 0, max: 1)]
            public string[] @DogstatsdTags { get; }

            [nterraform.TerraformProperty(name: "enable_hostname", @out: true, min: 0, max: 1)]
            public string @EnableHostname { get; }

            [nterraform.TerraformProperty(name: "statsd_addr", @out: true, min: 0, max: 1)]
            public string @StatsdAddr { get; }

            [nterraform.TerraformProperty(name: "statsite_addr", @out: true, min: 0, max: 1)]
            public string @StatsiteAddr { get; }

            [nterraform.TerraformProperty(name: "statsite_prefix", @out: true, min: 0, max: 1)]
            public string @StatsitePrefix { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "tagged_addresses")]
        public sealed class tagged_addresses : nterraform.structure
        {
            public tagged_addresses()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "lan", @out: true, min: 0, max: 1)]
            public string @Lan { get; }

            [nterraform.TerraformProperty(name: "wan", @out: true, min: 0, max: 1)]
            public string @Wan { get; }
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "acl_datacenter", @out: true, min: 0, max: 1)]
        public string @AclDatacenter { get; }

        [nterraform.TerraformProperty(name: "acl_default_policy", @out: true, min: 0, max: 1)]
        public string @AclDefaultPolicy { get; }

        [nterraform.TerraformProperty(name: "acl_disabled_ttl", @out: true, min: 0, max: 1)]
        public string @AclDisabledTtl { get; }

        [nterraform.TerraformProperty(name: "acl_down_policy", @out: true, min: 0, max: 1)]
        public string @AclDownPolicy { get; }

        [nterraform.TerraformProperty(name: "acl_enforce_0_8_semantics", @out: true, min: 0, max: 1)]
        public bool? @AclEnforce08Semantics { get; }

        [nterraform.TerraformProperty(name: "acl_ttl", @out: true, min: 0, max: 1)]
        public string @AclTtl { get; }

        [nterraform.TerraformProperty(name: "addresses", @out: false, min: 0, max: 0)]
        public Dictionary<string,addresses> @Addresses { get; }

        [nterraform.TerraformProperty(name: "advertise_addr", @out: true, min: 0, max: 1)]
        public string @AdvertiseAddr { get; }

        [nterraform.TerraformProperty(name: "advertise_addr_wan", @out: true, min: 0, max: 1)]
        public string @AdvertiseAddrWan { get; }

        [nterraform.TerraformProperty(name: "advertise_addrs", @out: false, min: 0, max: 0)]
        public Dictionary<string,advertise_addrs> @AdvertiseAddrs { get; }

        [nterraform.TerraformProperty(name: "atlas_join", @out: true, min: 0, max: 1)]
        public bool? @AtlasJoin { get; }

        [nterraform.TerraformProperty(name: "bind_addr", @out: true, min: 0, max: 1)]
        public string @BindAddr { get; }

        [nterraform.TerraformProperty(name: "bootstrap_expect", @out: true, min: 0, max: 1)]
        public int? @BootstrapExpect { get; }

        [nterraform.TerraformProperty(name: "bootstrap_mode", @out: true, min: 0, max: 1)]
        public bool? @BootstrapMode { get; }

        [nterraform.TerraformProperty(name: "check_deregister_interval_min", @out: true, min: 0, max: 1)]
        public string @CheckDeregisterIntervalMin { get; }

        [nterraform.TerraformProperty(name: "check_reap_interval", @out: true, min: 0, max: 1)]
        public string @CheckReapInterval { get; }

        [nterraform.TerraformProperty(name: "check_update_interval", @out: true, min: 0, max: 1)]
        public string @CheckUpdateInterval { get; }

        [nterraform.TerraformProperty(name: "client_addr", @out: true, min: 0, max: 1)]
        public string @ClientAddr { get; }

        [nterraform.TerraformProperty(name: "data_dir", @out: true, min: 0, max: 1)]
        public string @DataDir { get; }

        [nterraform.TerraformProperty(name: "datacenter", @out: true, min: 0, max: 1)]
        public string @Datacenter { get; }

        [nterraform.TerraformProperty(name: "dev_mode", @out: true, min: 0, max: 1)]
        public bool? @DevMode { get; }

        [nterraform.TerraformProperty(name: "dns", @out: false, min: 0, max: 0)]
        public Dictionary<string,dns> @Dns { get; }

        [nterraform.TerraformProperty(name: "dns_recursors", @out: true, min: 0, max: 1)]
        public string[] @DnsRecursors { get; }

        [nterraform.TerraformProperty(name: "domain", @out: true, min: 0, max: 1)]
        public string @Domain { get; }

        [nterraform.TerraformProperty(name: "enable_anonymous_signature", @out: true, min: 0, max: 1)]
        public bool? @EnableAnonymousSignature { get; }

        [nterraform.TerraformProperty(name: "enable_coordinates", @out: true, min: 0, max: 1)]
        public bool? @EnableCoordinates { get; }

        [nterraform.TerraformProperty(name: "enable_debug", @out: true, min: 0, max: 1)]
        public bool? @EnableDebug { get; }

        [nterraform.TerraformProperty(name: "enable_remote_exec", @out: true, min: 0, max: 1)]
        public bool? @EnableRemoteExec { get; }

        [nterraform.TerraformProperty(name: "enable_syslog", @out: true, min: 0, max: 1)]
        public bool? @EnableSyslog { get; }

        [nterraform.TerraformProperty(name: "enable_ui", @out: true, min: 0, max: 1)]
        public bool? @EnableUi { get; }

        [nterraform.TerraformProperty(name: "enable_update_check", @out: true, min: 0, max: 1)]
        public bool? @EnableUpdateCheck { get; }

        [nterraform.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
        public string @Id { get; }

        [nterraform.TerraformProperty(name: "leave_on_int", @out: true, min: 0, max: 1)]
        public bool? @LeaveOnInt { get; }

        [nterraform.TerraformProperty(name: "leave_on_term", @out: true, min: 0, max: 1)]
        public bool? @LeaveOnTerm { get; }

        [nterraform.TerraformProperty(name: "log_level", @out: true, min: 0, max: 1)]
        public string @LogLevel { get; }

        [nterraform.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "performance", @out: false, min: 0, max: 0)]
        public Dictionary<string,performance> @Performance { get; }

        [nterraform.TerraformProperty(name: "pid_file", @out: true, min: 0, max: 1)]
        public string @PidFile { get; }

        [nterraform.TerraformProperty(name: "ports", @out: false, min: 0, max: 0)]
        public Dictionary<string,ports> @Ports { get; }

        [nterraform.TerraformProperty(name: "protocol_version", @out: true, min: 0, max: 1)]
        public int? @ProtocolVersion { get; }

        [nterraform.TerraformProperty(name: "reconnect_timeout_lan", @out: true, min: 0, max: 1)]
        public string @ReconnectTimeoutLan { get; }

        [nterraform.TerraformProperty(name: "reconnect_timeout_wan", @out: true, min: 0, max: 1)]
        public string @ReconnectTimeoutWan { get; }

        [nterraform.TerraformProperty(name: "rejoin_after_leave", @out: true, min: 0, max: 1)]
        public bool? @RejoinAfterLeave { get; }

        [nterraform.TerraformProperty(name: "retry_join", @out: true, min: 0, max: 1)]
        public string[] @RetryJoin { get; }

        [nterraform.TerraformProperty(name: "retry_join_ec2", @out: false, min: 0, max: 0)]
        public Dictionary<string,retry_join_ec2> @RetryJoinEc2 { get; }

        [nterraform.TerraformProperty(name: "retry_join_gce", @out: false, min: 0, max: 0)]
        public Dictionary<string,retry_join_gce> @RetryJoinGce { get; }

        [nterraform.TerraformProperty(name: "retry_join_wan", @out: true, min: 0, max: 1)]
        public string[] @RetryJoinWan { get; }

        [nterraform.TerraformProperty(name: "retry_max_attempts", @out: true, min: 0, max: 1)]
        public int? @RetryMaxAttempts { get; }

        [nterraform.TerraformProperty(name: "retry_max_attempts_wan", @out: true, min: 0, max: 1)]
        public int? @RetryMaxAttemptsWan { get; }

        [nterraform.TerraformProperty(name: "serf_lan_bind_addr", @out: true, min: 0, max: 1)]
        public string @SerfLanBindAddr { get; }

        [nterraform.TerraformProperty(name: "serf_wan_bind_addr", @out: true, min: 0, max: 1)]
        public string @SerfWanBindAddr { get; }

        [nterraform.TerraformProperty(name: "server_mode", @out: true, min: 0, max: 1)]
        public bool? @ServerMode { get; }

        [nterraform.TerraformProperty(name: "server_name", @out: true, min: 0, max: 1)]
        public string @ServerName { get; }

        [nterraform.TerraformProperty(name: "session_ttl_min", @out: true, min: 0, max: 1)]
        public string @SessionTtlMin { get; }

        [nterraform.TerraformProperty(name: "start_join", @out: true, min: 0, max: 1)]
        public string[] @StartJoin { get; }

        [nterraform.TerraformProperty(name: "start_join_wan", @out: true, min: 0, max: 1)]
        public string[] @StartJoinWan { get; }

        [nterraform.TerraformProperty(name: "syslog_facility", @out: true, min: 0, max: 1)]
        public string @SyslogFacility { get; }

        [nterraform.TerraformProperty(name: "tagged_addresses", @out: false, min: 0, max: 0)]
        public Dictionary<string,tagged_addresses> @TaggedAddresses { get; }

        [nterraform.TerraformProperty(name: "telemetry", @out: false, min: 0, max: 0)]
        public Dictionary<string,telemetry> @Telemetry { get; }

        [nterraform.TerraformProperty(name: "tls_ca_file", @out: true, min: 0, max: 1)]
        public string @TlsCaFile { get; }

        [nterraform.TerraformProperty(name: "tls_cert_file", @out: true, min: 0, max: 1)]
        public string @TlsCertFile { get; }

        [nterraform.TerraformProperty(name: "tls_key_file", @out: true, min: 0, max: 1)]
        public string @TlsKeyFile { get; }

        [nterraform.TerraformProperty(name: "tls_min_version", @out: true, min: 0, max: 1)]
        public string @TlsMinVersion { get; }

        [nterraform.TerraformProperty(name: "tls_verify_incoming", @out: true, min: 0, max: 1)]
        public bool? @TlsVerifyIncoming { get; }

        [nterraform.TerraformProperty(name: "tls_verify_outgoing", @out: true, min: 0, max: 1)]
        public bool? @TlsVerifyOutgoing { get; }

        [nterraform.TerraformProperty(name: "tls_verify_server_hostname", @out: true, min: 0, max: 1)]
        public bool? @TlsVerifyServerHostname { get; }

        [nterraform.TerraformProperty(name: "translate_wan_addrs", @out: true, min: 0, max: 1)]
        public bool? @TranslateWanAddrs { get; }

        [nterraform.TerraformProperty(name: "ui_dir", @out: true, min: 0, max: 1)]
        public string @UiDir { get; }

        [nterraform.TerraformProperty(name: "unix_sockets", @out: false, min: 0, max: 0)]
        public Dictionary<string,unix_sockets> @UnixSockets { get; }

        [nterraform.TerraformProperty(name: "version", @out: true, min: 0, max: 1)]
        public string @Version { get; }

        [nterraform.TerraformProperty(name: "version_prerelease", @out: true, min: 0, max: 1)]
        public string @VersionPrerelease { get; }

        [nterraform.TerraformProperty(name: "version_revision", @out: true, min: 0, max: 1)]
        public string @VersionRevision { get; }
    }

}
