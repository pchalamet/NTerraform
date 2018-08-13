using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_gamelift_build")]
    public sealed class aws_gamelift_build : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "storage_location")]
        public sealed class storage_location : nterraform.Core.structure
        {
            public storage_location(string @bucket,
                                    string @key,
                                    string @roleArn)
            {
                @Bucket = @bucket;
                @Key = @key;
                @RoleArn = @roleArn;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "bucket", @out: false, min: 1, max: 1)]
            public string @Bucket { get; }

            [nterraform.Core.TerraformProperty(name: "key", @out: false, min: 1, max: 1)]
            public string @Key { get; }

            [nterraform.Core.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
            public string @RoleArn { get; }
        }

        public aws_gamelift_build(string @name,
                                  string @operatingSystem,
                                  storage_location[] @storageLocation,
                                  string @version = null)
        {
            @Name = @name;
            @OperatingSystem = @operatingSystem;
            @StorageLocation = @storageLocation;
            @Version = @version;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "operating_system", @out: false, min: 1, max: 1)]
        public string @OperatingSystem { get; }

        [nterraform.Core.TerraformProperty(name: "storage_location", @out: false, min: 1, max: 1)]
        public storage_location[] @StorageLocation { get; }

        [nterraform.Core.TerraformProperty(name: "version", @out: false, min: 0, max: 1)]
        public string @Version { get; }
    }

}
