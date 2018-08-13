using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_storagegateway_smb_file_share")]
    public sealed class aws_storagegateway_smb_file_share : nterraform.Core.resource
    {
        public aws_storagegateway_smb_file_share(string @gatewayArn,
                                                 string @locationArn,
                                                 string @roleArn,
                                                 string @authentication = null,
                                                 string @defaultStorageClass = null,
                                                 bool? @guessMimeTypeEnabled = null,
                                                 string[] @invalidUserList = null,
                                                 bool? @kmsEncrypted = null,
                                                 string @kmsKeyArn = null,
                                                 string @objectAcl = null,
                                                 bool? @readOnly = null,
                                                 bool? @requesterPays = null,
                                                 string[] @validUserList = null)
        {
            @GatewayArn = @gatewayArn;
            @LocationArn = @locationArn;
            @RoleArn = @roleArn;
            @Authentication = @authentication;
            @DefaultStorageClass = @defaultStorageClass;
            @GuessMimeTypeEnabled = @guessMimeTypeEnabled;
            @InvalidUserList = @invalidUserList;
            @KmsEncrypted = @kmsEncrypted;
            @KmsKeyArn = @kmsKeyArn;
            @ObjectAcl = @objectAcl;
            @ReadOnly = @readOnly;
            @RequesterPays = @requesterPays;
            @ValidUserList = @validUserList;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "gateway_arn", @out: false, min: 1, max: 1)]
        public string @GatewayArn { get; }

        [nterraform.Core.TerraformProperty(name: "location_arn", @out: false, min: 1, max: 1)]
        public string @LocationArn { get; }

        [nterraform.Core.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
        public string @RoleArn { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "authentication", @out: false, min: 0, max: 1)]
        public string @Authentication { get; }

        [nterraform.Core.TerraformProperty(name: "default_storage_class", @out: false, min: 0, max: 1)]
        public string @DefaultStorageClass { get; }

        [nterraform.Core.TerraformProperty(name: "fileshare_id", @out: true, min: 0, max: 1)]
        public string @FileshareId { get; }

        [nterraform.Core.TerraformProperty(name: "guess_mime_type_enabled", @out: false, min: 0, max: 1)]
        public bool? @GuessMimeTypeEnabled { get; }

        [nterraform.Core.TerraformProperty(name: "invalid_user_list", @out: false, min: 0, max: 1)]
        public string[] @InvalidUserList { get; }

        [nterraform.Core.TerraformProperty(name: "kms_encrypted", @out: false, min: 0, max: 1)]
        public bool? @KmsEncrypted { get; }

        [nterraform.Core.TerraformProperty(name: "kms_key_arn", @out: false, min: 0, max: 1)]
        public string @KmsKeyArn { get; }

        [nterraform.Core.TerraformProperty(name: "object_acl", @out: false, min: 0, max: 1)]
        public string @ObjectAcl { get; }

        [nterraform.Core.TerraformProperty(name: "read_only", @out: false, min: 0, max: 1)]
        public bool? @ReadOnly { get; }

        [nterraform.Core.TerraformProperty(name: "requester_pays", @out: false, min: 0, max: 1)]
        public bool? @RequesterPays { get; }

        [nterraform.Core.TerraformProperty(name: "valid_user_list", @out: false, min: 0, max: 1)]
        public string[] @ValidUserList { get; }
    }

}
