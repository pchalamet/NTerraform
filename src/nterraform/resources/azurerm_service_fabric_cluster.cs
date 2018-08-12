using System.Collections.Generic;

namespace nterraform.resources.azurerm
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_service_fabric_cluster")]
    public sealed class azurerm_service_fabric_cluster : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "diagnostics_config")]
        public sealed class diagnostics_config : nterraform.Core.structure
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

            [nterraform.Core.TerraformProperty(name: "blob_endpoint", @out: false, min: 1, max: 1)]
            public string @BlobEndpoint { get; }

            [nterraform.Core.TerraformProperty(name: "protected_account_key_name", @out: false, min: 1, max: 1)]
            public string @ProtectedAccountKeyName { get; }

            [nterraform.Core.TerraformProperty(name: "queue_endpoint", @out: false, min: 1, max: 1)]
            public string @QueueEndpoint { get; }

            [nterraform.Core.TerraformProperty(name: "storage_account_name", @out: false, min: 1, max: 1)]
            public string @StorageAccountName { get; }

            [nterraform.Core.TerraformProperty(name: "table_endpoint", @out: false, min: 1, max: 1)]
            public string @TableEndpoint { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "node_type")]
        public sealed class node_type : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "application_ports")]
            public sealed class application_ports : nterraform.Core.structure
            {
                public application_ports(int @endPort,
                                         int @startPort)
                {
                    @EndPort = @endPort;
                    @StartPort = @startPort;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "end_port", @out: false, min: 1, max: 1)]
                public int @EndPort { get; }

                [nterraform.Core.TerraformProperty(name: "start_port", @out: false, min: 1, max: 1)]
                public int @StartPort { get; }
            }

            [nterraform.Core.TerraformStructure(category: "resource", typeName: "ephemeral_ports")]
            public sealed class ephemeral_ports : nterraform.Core.structure
            {
                public ephemeral_ports(int @endPort,
                                       int @startPort)
                {
                    @EndPort = @endPort;
                    @StartPort = @startPort;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "end_port", @out: false, min: 1, max: 1)]
                public int @EndPort { get; }

                [nterraform.Core.TerraformProperty(name: "start_port", @out: false, min: 1, max: 1)]
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

            [nterraform.Core.TerraformProperty(name: "client_endpoint_port", @out: false, min: 1, max: 1)]
            public int @ClientEndpointPort { get; }

            [nterraform.Core.TerraformProperty(name: "http_endpoint_port", @out: false, min: 1, max: 1)]
            public int @HttpEndpointPort { get; }

            [nterraform.Core.TerraformProperty(name: "instance_count", @out: false, min: 1, max: 1)]
            public int @InstanceCount { get; }

            [nterraform.Core.TerraformProperty(name: "is_primary", @out: false, min: 1, max: 1)]
            public bool @IsPrimary { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "application_ports", @out: false, min: 0, max: 1)]
            public application_ports[] @ApplicationPorts { get; }

            [nterraform.Core.TerraformProperty(name: "durability_level", @out: false, min: 0, max: 1)]
            public string @DurabilityLevel { get; }

            [nterraform.Core.TerraformProperty(name: "ephemeral_ports", @out: false, min: 0, max: 1)]
            public ephemeral_ports[] @EphemeralPorts { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "fabric_settings")]
        public sealed class fabric_settings : nterraform.Core.structure
        {
            public fabric_settings(string @name,
                                   Dictionary<string,string> @parameters = null)
            {
                @Name = @name;
                @Parameters = @parameters;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "parameters", @out: false, min: 0, max: 1)]
            public Dictionary<string,string> @Parameters { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "certificate")]
        public sealed class certificate : nterraform.Core.structure
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

            [nterraform.Core.TerraformProperty(name: "thumbprint", @out: false, min: 1, max: 1)]
            public string @Thumbprint { get; }

            [nterraform.Core.TerraformProperty(name: "x509_store_name", @out: false, min: 1, max: 1)]
            public string @X509StoreName { get; }

            [nterraform.Core.TerraformProperty(name: "thumbprint_secondary", @out: false, min: 0, max: 1)]
            public string @ThumbprintSecondary { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "client_certificate_thumbprint")]
        public sealed class client_certificate_thumbprint : nterraform.Core.structure
        {
            public client_certificate_thumbprint(bool @isAdmin,
                                                 string @thumbprint)
            {
                @IsAdmin = @isAdmin;
                @Thumbprint = @thumbprint;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "is_admin", @out: false, min: 1, max: 1)]
            public bool @IsAdmin { get; }

            [nterraform.Core.TerraformProperty(name: "thumbprint", @out: false, min: 1, max: 1)]
            public string @Thumbprint { get; }
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

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "management_endpoint", @out: false, min: 1, max: 1)]
        public string @ManagementEndpoint { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "node_type", @out: false, min: 1, max: 0)]
        public node_type[] @NodeType { get; }

        [nterraform.Core.TerraformProperty(name: "reliability_level", @out: false, min: 1, max: 1)]
        public string @ReliabilityLevel { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "upgrade_mode", @out: false, min: 1, max: 1)]
        public string @UpgradeMode { get; }

        [nterraform.Core.TerraformProperty(name: "vm_image", @out: false, min: 1, max: 1)]
        public string @VmImage { get; }

        [nterraform.Core.TerraformProperty(name: "add_on_features", @out: false, min: 0, max: 1)]
        public string[] @AddOnFeatures { get; }

        [nterraform.Core.TerraformProperty(name: "certificate", @out: false, min: 0, max: 1)]
        public certificate[] @Certificate { get; }

        [nterraform.Core.TerraformProperty(name: "client_certificate_thumbprint", @out: false, min: 0, max: 1)]
        public client_certificate_thumbprint[] @ClientCertificateThumbprint { get; }

        [nterraform.Core.TerraformProperty(name: "cluster_endpoint", @out: true, min: 0, max: 1)]
        public string @ClusterEndpoint { get; }

        [nterraform.Core.TerraformProperty(name: "diagnostics_config", @out: false, min: 0, max: 1)]
        public diagnostics_config[] @DiagnosticsConfig { get; }

        [nterraform.Core.TerraformProperty(name: "fabric_settings", @out: false, min: 0, max: 0)]
        public fabric_settings[] @FabricSettings { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
