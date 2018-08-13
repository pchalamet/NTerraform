using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_storagegateway_nfs_file_share")]
    public sealed class aws_storagegateway_nfs_file_share : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "nfs_file_share_defaults")]
        public sealed class nfs_file_share_defaults : nterraform.Core.structure
        {
            public nfs_file_share_defaults(string @directoryMode = null,
                                           string @fileMode = null,
                                           int? @groupId = null,
                                           int? @ownerId = null)
            {
                @DirectoryMode = @directoryMode;
                @FileMode = @fileMode;
                @GroupId = @groupId;
                @OwnerId = @ownerId;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "directory_mode", @out: false, min: 0, max: 1)]
            public string @DirectoryMode { get; }

            [nterraform.Core.TerraformProperty(name: "file_mode", @out: false, min: 0, max: 1)]
            public string @FileMode { get; }

            [nterraform.Core.TerraformProperty(name: "group_id", @out: false, min: 0, max: 1)]
            public int? @GroupId { get; }

            [nterraform.Core.TerraformProperty(name: "owner_id", @out: false, min: 0, max: 1)]
            public int? @OwnerId { get; }
        }

        public aws_storagegateway_nfs_file_share(string[] @clientList,
                                                 string @gatewayArn,
                                                 string @locationArn,
                                                 string @roleArn,
                                                 string @defaultStorageClass = null,
                                                 bool? @guessMimeTypeEnabled = null,
                                                 bool? @kmsEncrypted = null,
                                                 string @kmsKeyArn = null,
                                                 nfs_file_share_defaults[] @nfsFileShareDefaults = null,
                                                 string @objectAcl = null,
                                                 bool? @readOnly = null,
                                                 bool? @requesterPays = null,
                                                 string @squash = null)
        {
            @ClientList = @clientList;
            @GatewayArn = @gatewayArn;
            @LocationArn = @locationArn;
            @RoleArn = @roleArn;
            @DefaultStorageClass = @defaultStorageClass;
            @GuessMimeTypeEnabled = @guessMimeTypeEnabled;
            @KmsEncrypted = @kmsEncrypted;
            @KmsKeyArn = @kmsKeyArn;
            @NfsFileShareDefaults = @nfsFileShareDefaults;
            @ObjectAcl = @objectAcl;
            @ReadOnly = @readOnly;
            @RequesterPays = @requesterPays;
            @Squash = @squash;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "client_list", @out: false, min: 1, max: 1)]
        public string[] @ClientList { get; }

        [nterraform.Core.TerraformProperty(name: "gateway_arn", @out: false, min: 1, max: 1)]
        public string @GatewayArn { get; }

        [nterraform.Core.TerraformProperty(name: "location_arn", @out: false, min: 1, max: 1)]
        public string @LocationArn { get; }

        [nterraform.Core.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
        public string @RoleArn { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "default_storage_class", @out: false, min: 0, max: 1)]
        public string @DefaultStorageClass { get; }

        [nterraform.Core.TerraformProperty(name: "fileshare_id", @out: true, min: 0, max: 1)]
        public string @FileshareId { get; }

        [nterraform.Core.TerraformProperty(name: "guess_mime_type_enabled", @out: false, min: 0, max: 1)]
        public bool? @GuessMimeTypeEnabled { get; }

        [nterraform.Core.TerraformProperty(name: "kms_encrypted", @out: false, min: 0, max: 1)]
        public bool? @KmsEncrypted { get; }

        [nterraform.Core.TerraformProperty(name: "kms_key_arn", @out: false, min: 0, max: 1)]
        public string @KmsKeyArn { get; }

        [nterraform.Core.TerraformProperty(name: "nfs_file_share_defaults", @out: false, min: 0, max: 1)]
        public nfs_file_share_defaults[] @NfsFileShareDefaults { get; }

        [nterraform.Core.TerraformProperty(name: "object_acl", @out: false, min: 0, max: 1)]
        public string @ObjectAcl { get; }

        [nterraform.Core.TerraformProperty(name: "read_only", @out: false, min: 0, max: 1)]
        public bool? @ReadOnly { get; }

        [nterraform.Core.TerraformProperty(name: "requester_pays", @out: false, min: 0, max: 1)]
        public bool? @RequesterPays { get; }

        [nterraform.Core.TerraformProperty(name: "squash", @out: false, min: 0, max: 1)]
        public string @Squash { get; }
    }

}
