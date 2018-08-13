using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_storagegateway_gateway")]
    public sealed class aws_storagegateway_gateway : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "smb_active_directory_settings")]
        public sealed class smb_active_directory_settings : nterraform.structure
        {
            public smb_active_directory_settings(string @domainName,
                                                 string @password,
                                                 string @username)
            {
                @DomainName = @domainName;
                @Password = @password;
                @Username = @username;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "domain_name", @out: false, min: 1, max: 1)]
            public string @DomainName { get; }

            [nterraform.TerraformProperty(name: "password", @out: false, min: 1, max: 1)]
            public string @Password { get; }

            [nterraform.TerraformProperty(name: "username", @out: false, min: 1, max: 1)]
            public string @Username { get; }
        }

        public aws_storagegateway_gateway(string @gatewayName,
                                          string @gatewayTimezone,
                                          string @gatewayType = null,
                                          string @mediumChangerType = null,
                                          smb_active_directory_settings[] @smbActiveDirectorySettings = null,
                                          string @smbGuestPassword = null,
                                          string @tapeDriveType = null)
        {
            @GatewayName = @gatewayName;
            @GatewayTimezone = @gatewayTimezone;
            @GatewayType = @gatewayType;
            @MediumChangerType = @mediumChangerType;
            @SmbActiveDirectorySettings = @smbActiveDirectorySettings;
            @SmbGuestPassword = @smbGuestPassword;
            @TapeDriveType = @tapeDriveType;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "gateway_name", @out: false, min: 1, max: 1)]
        public string @GatewayName { get; }

        [nterraform.TerraformProperty(name: "gateway_timezone", @out: false, min: 1, max: 1)]
        public string @GatewayTimezone { get; }

        [nterraform.TerraformProperty(name: "activation_key", @out: true, min: 0, max: 1)]
        public string @ActivationKey { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "gateway_id", @out: true, min: 0, max: 1)]
        public string @GatewayId { get; }

        [nterraform.TerraformProperty(name: "gateway_ip_address", @out: true, min: 0, max: 1)]
        public string @GatewayIpAddress { get; }

        [nterraform.TerraformProperty(name: "gateway_type", @out: false, min: 0, max: 1)]
        public string @GatewayType { get; }

        [nterraform.TerraformProperty(name: "medium_changer_type", @out: false, min: 0, max: 1)]
        public string @MediumChangerType { get; }

        [nterraform.TerraformProperty(name: "smb_active_directory_settings", @out: false, min: 0, max: 1)]
        public smb_active_directory_settings[] @SmbActiveDirectorySettings { get; }

        [nterraform.TerraformProperty(name: "smb_guest_password", @out: false, min: 0, max: 1)]
        public string @SmbGuestPassword { get; }

        [nterraform.TerraformProperty(name: "tape_drive_type", @out: false, min: 0, max: 1)]
        public string @TapeDriveType { get; }
    }

}
