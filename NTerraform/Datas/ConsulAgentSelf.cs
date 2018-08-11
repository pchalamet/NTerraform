using System.Collections.Generic;

namespace NTerraform.Datas
{
    public class consul_agent_self : NTerraform.data
    {
        public class performance
        {
            public performance()
            {
            }

            public string @RaftMultiplier { get; }
        }

        public class telemetry
        {
            public telemetry()
            {
            }

            public string @CirconusApiApp { get; }
            public string @CirconusApiToken { get; }
            public string @CirconusApiUrl { get; }
            public string @CirconusBrokerId { get; }
            public string @CirconusCheckId { get; }
            public string @CirconusCheckTags { get; }
            public string @CirconusDisplayName { get; }
            public bool? @CirconusForceMetricActivation { get; }
            public string @CirconusInstanceId { get; }
            public string @CirconusSearchTag { get; }
            public string @CirconusSelectTag { get; }
            public string @CirconusSubmissionInterval { get; }
            public string @CirconusSubmissionUrl { get; }
            public string @DogstatsdAddr { get; }
            public string[] @DogstatsdTags { get; }
            public string @EnableHostname { get; }
            public string @StatsdAddr { get; }
            public string @StatsiteAddr { get; }
            public string @StatsitePrefix { get; }
        }

        public class advertise_addrs
        {
            public advertise_addrs()
            {
            }

            public string @Rpc { get; }
            public string @SerfLan { get; }
            public string @SerfWan { get; }
        }

        public class dns
        {
            public dns()
            {
            }

            public bool? @AllowStale { get; }
            public bool? @EnableCompression { get; }
            public bool? @EnableTruncate { get; }
            public string @MaxStale { get; }
            public string @NodeTtl { get; }
            public bool? @OnlyPassing { get; }
            public string @RecursorTimeout { get; }
            public string @ServiceTtl { get; }
            public int? @UdpAnswerLimit { get; }
        }

        public class retry_join_ec2
        {
            public retry_join_ec2()
            {
            }

            public string @Region { get; }
            public string @TagKey { get; }
            public string @TagValue { get; }
        }

        public class ports
        {
            public ports()
            {
            }

            public int? @Dns { get; }
            public int? @Http { get; }
            public int? @Https { get; }
            public int? @Rpc { get; }
            public int? @SerfLan { get; }
            public int? @SerfWan { get; }
            public int? @Server { get; }
        }

        public class tagged_addresses
        {
            public tagged_addresses()
            {
            }

            public string @Lan { get; }
            public string @Wan { get; }
        }

        public class addresses
        {
            public addresses()
            {
            }

            public string @Dns { get; }
            public string @Http { get; }
            public string @Https { get; }
            public string @Rpc { get; }
        }

        public class retry_join_gce
        {
            public retry_join_gce()
            {
            }

            public string @CredentialsFile { get; }
            public string @ProjectName { get; }
            public string @TagValue { get; }
            public string @ZonePattern { get; }
        }

        public class unix_sockets
        {
            public unix_sockets()
            {
            }

            public string @Group { get; }
            public string @Mode { get; }
            public string @User { get; }
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

        public string @AclDatacenter { get; }
        public string @AclDefaultPolicy { get; }
        public string @AclDisabledTtl { get; }
        public string @AclDownPolicy { get; }
        public bool? @AclEnforce08Semantics { get; }
        public string @AclTtl { get; }
        public Dictionary<string,addresses> @Addresses { get; }
        public string @AdvertiseAddr { get; }
        public string @AdvertiseAddrWan { get; }
        public Dictionary<string,advertise_addrs> @AdvertiseAddrs { get; }
        public bool? @AtlasJoin { get; }
        public string @BindAddr { get; }
        public int? @BootstrapExpect { get; }
        public bool? @BootstrapMode { get; }
        public string @CheckDeregisterIntervalMin { get; }
        public string @CheckReapInterval { get; }
        public string @CheckUpdateInterval { get; }
        public string @ClientAddr { get; }
        public string @DataDir { get; }
        public string @Datacenter { get; }
        public bool? @DevMode { get; }
        public Dictionary<string,dns> @Dns { get; }
        public string[] @DnsRecursors { get; }
        public string @Domain { get; }
        public bool? @EnableAnonymousSignature { get; }
        public bool? @EnableCoordinates { get; }
        public bool? @EnableDebug { get; }
        public bool? @EnableRemoteExec { get; }
        public bool? @EnableSyslog { get; }
        public bool? @EnableUi { get; }
        public bool? @EnableUpdateCheck { get; }
        public string @Id { get; }
        public bool? @LeaveOnInt { get; }
        public bool? @LeaveOnTerm { get; }
        public string @LogLevel { get; }
        public string @Name { get; }
        public Dictionary<string,performance> @Performance { get; }
        public string @PidFile { get; }
        public Dictionary<string,ports> @Ports { get; }
        public int? @ProtocolVersion { get; }
        public string @ReconnectTimeoutLan { get; }
        public string @ReconnectTimeoutWan { get; }
        public bool? @RejoinAfterLeave { get; }
        public string[] @RetryJoin { get; }
        public Dictionary<string,retry_join_ec2> @RetryJoinEc2 { get; }
        public Dictionary<string,retry_join_gce> @RetryJoinGce { get; }
        public string[] @RetryJoinWan { get; }
        public int? @RetryMaxAttempts { get; }
        public int? @RetryMaxAttemptsWan { get; }
        public string @SerfLanBindAddr { get; }
        public string @SerfWanBindAddr { get; }
        public bool? @ServerMode { get; }
        public string @ServerName { get; }
        public string @SessionTtlMin { get; }
        public string[] @StartJoin { get; }
        public string[] @StartJoinWan { get; }
        public string @SyslogFacility { get; }
        public Dictionary<string,tagged_addresses> @TaggedAddresses { get; }
        public Dictionary<string,telemetry> @Telemetry { get; }
        public string @TlsCaFile { get; }
        public string @TlsCertFile { get; }
        public string @TlsKeyFile { get; }
        public string @TlsMinVersion { get; }
        public bool? @TlsVerifyIncoming { get; }
        public bool? @TlsVerifyOutgoing { get; }
        public bool? @TlsVerifyServerHostname { get; }
        public bool? @TranslateWanAddrs { get; }
        public string @UiDir { get; }
        public Dictionary<string,unix_sockets> @UnixSockets { get; }
        public string @Version { get; }
        public string @VersionPrerelease { get; }
        public string @VersionRevision { get; }
    }

}
