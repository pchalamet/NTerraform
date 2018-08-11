using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_service_fabric_cluster : NTerraform.resource
    {
        public class certificate
        {
            public certificate(string @thumbprint,
                               string @x509StoreName,
                               string @thumbprintSecondary = null)
            {
                @Thumbprint = @thumbprint;
                @X509StoreName = @x509StoreName;
                @ThumbprintSecondary = @thumbprintSecondary;
            }

            public string @Thumbprint { get; }
            public string @X509StoreName { get; }
            public string @ThumbprintSecondary { get; }
        }

        public class diagnostics_config
        {
            public diagnostics_config(string @blobEndpoint,
                                      string @protectedAccountKeyName,
                                      string @queueEndpoint,
                                      string @storageAccountName,
                                      string @tableEndpoint)
            {
                @BlobEndpoint = @blobEndpoint;
                @ProtectedAccountKeyName = @protectedAccountKeyName;
                @QueueEndpoint = @queueEndpoint;
                @StorageAccountName = @storageAccountName;
                @TableEndpoint = @tableEndpoint;
            }

            public string @BlobEndpoint { get; }
            public string @ProtectedAccountKeyName { get; }
            public string @QueueEndpoint { get; }
            public string @StorageAccountName { get; }
            public string @TableEndpoint { get; }
        }

        public class fabric_settings
        {
            public fabric_settings(string @name,
                                   Dictionary<string,string> @parameters = null)
            {
                @Name = @name;
                @Parameters = @parameters;
            }

            public string @Name { get; }
            public Dictionary<string,string> @Parameters { get; }
        }

        public class client_certificate_thumbprint
        {
            public client_certificate_thumbprint(bool @isAdmin,
                                                 string @thumbprint)
            {
                @IsAdmin = @isAdmin;
                @Thumbprint = @thumbprint;
            }

            public bool @IsAdmin { get; }
            public string @Thumbprint { get; }
        }

        public class node_type
        {
            public class ephemeral_ports
            {
                public ephemeral_ports(int @endPort,
                                       int @startPort)
                {
                    @EndPort = @endPort;
                    @StartPort = @startPort;
                }

                public int @EndPort { get; }
                public int @StartPort { get; }
            }

            public class application_ports
            {
                public application_ports(int @endPort,
                                         int @startPort)
                {
                    @EndPort = @endPort;
                    @StartPort = @startPort;
                }

                public int @EndPort { get; }
                public int @StartPort { get; }
            }

            public node_type(int @clientEndpointPort,
                             int @httpEndpointPort,
                             int @instanceCount,
                             bool @isPrimary,
                             string @name,
                             application_ports[] @applicationPorts = null,
                             string @durabilityLevel = null,
                             ephemeral_ports[] @ephemeralPorts = null)
            {
                @ClientEndpointPort = @clientEndpointPort;
                @HttpEndpointPort = @httpEndpointPort;
                @InstanceCount = @instanceCount;
                @IsPrimary = @isPrimary;
                @Name = @name;
                @ApplicationPorts = @applicationPorts;
                @DurabilityLevel = @durabilityLevel;
                @EphemeralPorts = @ephemeralPorts;
            }

            public int @ClientEndpointPort { get; }
            public int @HttpEndpointPort { get; }
            public int @InstanceCount { get; }
            public bool @IsPrimary { get; }
            public string @Name { get; }
            public application_ports[] @ApplicationPorts { get; }
            public string @DurabilityLevel { get; }
            public ephemeral_ports[] @EphemeralPorts { get; }
        }

        public azurerm_service_fabric_cluster(string @location,
                                              string @managementEndpoint,
                                              string @name,
                                              node_type[] @nodeType,
                                              string @reliabilityLevel,
                                              string @resourceGroupName,
                                              string @upgradeMode,
                                              string @vmImage,
                                              string[] @addOnFeatures = null,
                                              certificate[] @certificate = null,
                                              client_certificate_thumbprint[] @clientCertificateThumbprint = null,
                                              diagnostics_config[] @diagnosticsConfig = null,
                                              fabric_settings[] @fabricSettings = null)
        {
            @Location = @location;
            @ManagementEndpoint = @managementEndpoint;
            @Name = @name;
            @NodeType = @nodeType;
            @ReliabilityLevel = @reliabilityLevel;
            @ResourceGroupName = @resourceGroupName;
            @UpgradeMode = @upgradeMode;
            @VmImage = @vmImage;
            @AddOnFeatures = @addOnFeatures;
            @Certificate = @certificate;
            @ClientCertificateThumbprint = @clientCertificateThumbprint;
            @DiagnosticsConfig = @diagnosticsConfig;
            @FabricSettings = @fabricSettings;
        }

        public string @Location { get; }
        public string @ManagementEndpoint { get; }
        public string @Name { get; }
        public node_type[] @NodeType { get; }
        public string @ReliabilityLevel { get; }
        public string @ResourceGroupName { get; }
        public string @UpgradeMode { get; }
        public string @VmImage { get; }
        public string[] @AddOnFeatures { get; }
        public certificate[] @Certificate { get; }
        public client_certificate_thumbprint[] @ClientCertificateThumbprint { get; }
        public string @ClusterEndpoint { get; }
        public diagnostics_config[] @DiagnosticsConfig { get; }
        public fabric_settings[] @FabricSettings { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
