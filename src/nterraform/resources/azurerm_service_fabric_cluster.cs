using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_service_fabric_cluster")]
    public sealed class azurerm_service_fabric_cluster : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "diagnostics_config")]
        public sealed class diagnostics_config : nterraform.structure
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

            [nterraform.TerraformProperty(name: "blob_endpoint", @out: false, min: 1, max: 1)]
            public string @BlobEndpoint { get; }

            [nterraform.TerraformProperty(name: "protected_account_key_name", @out: false, min: 1, max: 1)]
            public string @ProtectedAccountKeyName { get; }

            [nterraform.TerraformProperty(name: "queue_endpoint", @out: false, min: 1, max: 1)]
            public string @QueueEndpoint { get; }

            [nterraform.TerraformProperty(name: "storage_account_name", @out: false, min: 1, max: 1)]
            public string @StorageAccountName { get; }

            [nterraform.TerraformProperty(name: "table_endpoint", @out: false, min: 1, max: 1)]
            public string @TableEndpoint { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "client_certificate_thumbprint")]
        public sealed class client_certificate_thumbprint : nterraform.structure
        {
            public client_certificate_thumbprint(bool @isAdmin,
                                                 string @thumbprint)
            {
                @IsAdmin = @isAdmin;
                @Thumbprint = @thumbprint;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "is_admin", @out: false, min: 1, max: 1)]
            public bool @IsAdmin { get; }

            [nterraform.TerraformProperty(name: "thumbprint", @out: false, min: 1, max: 1)]
            public string @Thumbprint { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "fabric_settings")]
        public sealed class fabric_settings : nterraform.structure
        {
            public fabric_settings(string @name,
                                   Dictionary<string,string> @parameters = null)
            {
                @Name = @name;
                @Parameters = @parameters;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "parameters", @out: false, min: 0, max: 1)]
            public Dictionary<string,string> @Parameters { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "certificate")]
        public sealed class certificate : nterraform.structure
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

            [nterraform.TerraformProperty(name: "thumbprint", @out: false, min: 1, max: 1)]
            public string @Thumbprint { get; }

            [nterraform.TerraformProperty(name: "x509_store_name", @out: false, min: 1, max: 1)]
            public string @X509StoreName { get; }

            [nterraform.TerraformProperty(name: "thumbprint_secondary", @out: false, min: 0, max: 1)]
            public string @ThumbprintSecondary { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "node_type")]
        public sealed class node_type : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "application_ports")]
            public sealed class application_ports : nterraform.structure
            {
                public application_ports(int @endPort,
                                         int @startPort)
                {
                    @EndPort = @endPort;
                    @StartPort = @startPort;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "end_port", @out: false, min: 1, max: 1)]
                public int @EndPort { get; }

                [nterraform.TerraformProperty(name: "start_port", @out: false, min: 1, max: 1)]
                public int @StartPort { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "ephemeral_ports")]
            public sealed class ephemeral_ports : nterraform.structure
            {
                public ephemeral_ports(int @endPort,
                                       int @startPort)
                {
                    @EndPort = @endPort;
                    @StartPort = @startPort;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "end_port", @out: false, min: 1, max: 1)]
                public int @EndPort { get; }

                [nterraform.TerraformProperty(name: "start_port", @out: false, min: 1, max: 1)]
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

            [nterraform.TerraformProperty(name: "client_endpoint_port", @out: false, min: 1, max: 1)]
            public int @ClientEndpointPort { get; }

            [nterraform.TerraformProperty(name: "http_endpoint_port", @out: false, min: 1, max: 1)]
            public int @HttpEndpointPort { get; }

            [nterraform.TerraformProperty(name: "instance_count", @out: false, min: 1, max: 1)]
            public int @InstanceCount { get; }

            [nterraform.TerraformProperty(name: "is_primary", @out: false, min: 1, max: 1)]
            public bool @IsPrimary { get; }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "application_ports", @out: false, min: 0, max: 1)]
            public application_ports[] @ApplicationPorts { get; }

            [nterraform.TerraformProperty(name: "durability_level", @out: false, min: 0, max: 1)]
            public string @DurabilityLevel { get; }

            [nterraform.TerraformProperty(name: "ephemeral_ports", @out: false, min: 0, max: 1)]
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "management_endpoint", @out: false, min: 1, max: 1)]
        public string @ManagementEndpoint { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "node_type", @out: false, min: 1, max: 0)]
        public node_type[] @NodeType { get; }

        [nterraform.TerraformProperty(name: "reliability_level", @out: false, min: 1, max: 1)]
        public string @ReliabilityLevel { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "upgrade_mode", @out: false, min: 1, max: 1)]
        public string @UpgradeMode { get; }

        [nterraform.TerraformProperty(name: "vm_image", @out: false, min: 1, max: 1)]
        public string @VmImage { get; }

        [nterraform.TerraformProperty(name: "add_on_features", @out: false, min: 0, max: 1)]
        public string[] @AddOnFeatures { get; }

        [nterraform.TerraformProperty(name: "certificate", @out: false, min: 0, max: 1)]
        public certificate[] @Certificate { get; }

        [nterraform.TerraformProperty(name: "client_certificate_thumbprint", @out: false, min: 0, max: 1)]
        public client_certificate_thumbprint[] @ClientCertificateThumbprint { get; }

        [nterraform.TerraformProperty(name: "cluster_endpoint", @out: true, min: 0, max: 1)]
        public string @ClusterEndpoint { get; }

        [nterraform.TerraformProperty(name: "diagnostics_config", @out: false, min: 0, max: 1)]
        public diagnostics_config[] @DiagnosticsConfig { get; }

        [nterraform.TerraformProperty(name: "fabric_settings", @out: false, min: 0, max: 0)]
        public fabric_settings[] @FabricSettings { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
