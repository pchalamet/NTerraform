using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_service_fabric_cluster")]
    public sealed class azurerm_service_fabric_cluster : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "certificate")]
        public sealed class certificate: NTerraform.structure
        {
            public certificate(string @thumbprint,
                               string @x509StoreName,
                               string @thumbprintSecondary = null)
            {
                @Thumbprint = @thumbprint;
                @X509StoreName = @x509StoreName;
                @ThumbprintSecondary = @thumbprintSecondary;
                base._validate_();
            }

            [TerraformProperty(name: "thumbprint", @out: false, min: 1, max: 1)]
            public string @Thumbprint { get; }

            [TerraformProperty(name: "x509_store_name", @out: false, min: 1, max: 1)]
            public string @X509StoreName { get; }

            [TerraformProperty(name: "thumbprint_secondary", @out: false, min: 0, max: 1)]
            public string @ThumbprintSecondary { get; }
        }

        [TerraformStructure(category: "", typeName: "client_certificate_thumbprint")]
        public sealed class client_certificate_thumbprint: NTerraform.structure
        {
            public client_certificate_thumbprint(bool @isAdmin,
                                                 string @thumbprint)
            {
                @IsAdmin = @isAdmin;
                @Thumbprint = @thumbprint;
                base._validate_();
            }

            [TerraformProperty(name: "is_admin", @out: false, min: 1, max: 1)]
            public bool @IsAdmin { get; }

            [TerraformProperty(name: "thumbprint", @out: false, min: 1, max: 1)]
            public string @Thumbprint { get; }
        }

        [TerraformStructure(category: "", typeName: "node_type")]
        public sealed class node_type: NTerraform.structure
        {
            [TerraformStructure(category: "", typeName: "ephemeral_ports")]
            public sealed class ephemeral_ports: NTerraform.structure
            {
                public ephemeral_ports(int @endPort,
                                       int @startPort)
                {
                    @EndPort = @endPort;
                    @StartPort = @startPort;
                    base._validate_();
                }

                [TerraformProperty(name: "end_port", @out: false, min: 1, max: 1)]
                public int @EndPort { get; }

                [TerraformProperty(name: "start_port", @out: false, min: 1, max: 1)]
                public int @StartPort { get; }
            }

            [TerraformStructure(category: "", typeName: "application_ports")]
            public sealed class application_ports: NTerraform.structure
            {
                public application_ports(int @endPort,
                                         int @startPort)
                {
                    @EndPort = @endPort;
                    @StartPort = @startPort;
                    base._validate_();
                }

                [TerraformProperty(name: "end_port", @out: false, min: 1, max: 1)]
                public int @EndPort { get; }

                [TerraformProperty(name: "start_port", @out: false, min: 1, max: 1)]
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
                base._validate_();
            }

            [TerraformProperty(name: "client_endpoint_port", @out: false, min: 1, max: 1)]
            public int @ClientEndpointPort { get; }

            [TerraformProperty(name: "http_endpoint_port", @out: false, min: 1, max: 1)]
            public int @HttpEndpointPort { get; }

            [TerraformProperty(name: "instance_count", @out: false, min: 1, max: 1)]
            public int @InstanceCount { get; }

            [TerraformProperty(name: "is_primary", @out: false, min: 1, max: 1)]
            public bool @IsPrimary { get; }

            [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "application_ports", @out: false, min: 0, max: 1)]
            public application_ports[] @ApplicationPorts { get; }

            [TerraformProperty(name: "durability_level", @out: false, min: 0, max: 1)]
            public string @DurabilityLevel { get; }

            [TerraformProperty(name: "ephemeral_ports", @out: false, min: 0, max: 1)]
            public ephemeral_ports[] @EphemeralPorts { get; }
        }

        [TerraformStructure(category: "", typeName: "diagnostics_config")]
        public sealed class diagnostics_config: NTerraform.structure
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
                base._validate_();
            }

            [TerraformProperty(name: "blob_endpoint", @out: false, min: 1, max: 1)]
            public string @BlobEndpoint { get; }

            [TerraformProperty(name: "protected_account_key_name", @out: false, min: 1, max: 1)]
            public string @ProtectedAccountKeyName { get; }

            [TerraformProperty(name: "queue_endpoint", @out: false, min: 1, max: 1)]
            public string @QueueEndpoint { get; }

            [TerraformProperty(name: "storage_account_name", @out: false, min: 1, max: 1)]
            public string @StorageAccountName { get; }

            [TerraformProperty(name: "table_endpoint", @out: false, min: 1, max: 1)]
            public string @TableEndpoint { get; }
        }

        [TerraformStructure(category: "", typeName: "fabric_settings")]
        public sealed class fabric_settings: NTerraform.structure
        {
            public fabric_settings(string @name,
                                   Dictionary<string,string> @parameters = null)
            {
                @Name = @name;
                @Parameters = @parameters;
                base._validate_();
            }

            [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "parameters", @out: false, min: 0, max: 1)]
            public Dictionary<string,string> @Parameters { get; }
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
            base._validate_();
        }

        [TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "management_endpoint", @out: false, min: 1, max: 1)]
        public string @ManagementEndpoint { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "node_type", @out: false, min: 1, max: 0)]
        public node_type[] @NodeType { get; }

        [TerraformProperty(name: "reliability_level", @out: false, min: 1, max: 1)]
        public string @ReliabilityLevel { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "upgrade_mode", @out: false, min: 1, max: 1)]
        public string @UpgradeMode { get; }

        [TerraformProperty(name: "vm_image", @out: false, min: 1, max: 1)]
        public string @VmImage { get; }

        [TerraformProperty(name: "add_on_features", @out: false, min: 0, max: 1)]
        public string[] @AddOnFeatures { get; }

        [TerraformProperty(name: "certificate", @out: false, min: 0, max: 1)]
        public certificate[] @Certificate { get; }

        [TerraformProperty(name: "client_certificate_thumbprint", @out: false, min: 0, max: 1)]
        public client_certificate_thumbprint[] @ClientCertificateThumbprint { get; }

        [TerraformProperty(name: "cluster_endpoint", @out: true, min: 0, max: 1)]
        public string @ClusterEndpoint { get; }

        [TerraformProperty(name: "diagnostics_config", @out: false, min: 0, max: 1)]
        public diagnostics_config[] @DiagnosticsConfig { get; }

        [TerraformProperty(name: "fabric_settings", @out: false, min: 0, max: 0)]
        public fabric_settings[] @FabricSettings { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
