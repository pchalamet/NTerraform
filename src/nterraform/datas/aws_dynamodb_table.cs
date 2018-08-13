using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_dynamodb_table")]
    public sealed class aws_dynamodb_table : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "attribute")]
        public sealed class attribute : nterraform.Core.structure
        {
            public attribute()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "type", @out: true, min: 0, max: 1)]
            public string @Type { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "server_side_encryption")]
        public sealed class server_side_encryption : nterraform.Core.structure
        {
            public server_side_encryption()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "enabled", @out: true, min: 0, max: 1)]
            public bool? @Enabled { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "local_secondary_index")]
        public sealed class local_secondary_index : nterraform.Core.structure
        {
            public local_secondary_index()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "non_key_attributes", @out: true, min: 0, max: 1)]
            public string[] @NonKeyAttributes { get; }

            [nterraform.Core.TerraformProperty(name: "projection_type", @out: true, min: 0, max: 1)]
            public string @ProjectionType { get; }

            [nterraform.Core.TerraformProperty(name: "range_key", @out: true, min: 0, max: 1)]
            public string @RangeKey { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "ttl")]
        public sealed class ttl : nterraform.Core.structure
        {
            public ttl()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "attribute_name", @out: true, min: 0, max: 1)]
            public string @AttributeName { get; }

            [nterraform.Core.TerraformProperty(name: "enabled", @out: true, min: 0, max: 1)]
            public bool? @Enabled { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "global_secondary_index")]
        public sealed class global_secondary_index : nterraform.Core.structure
        {
            public global_secondary_index()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "hash_key", @out: true, min: 0, max: 1)]
            public string @HashKey { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "non_key_attributes", @out: true, min: 0, max: 1)]
            public string[] @NonKeyAttributes { get; }

            [nterraform.Core.TerraformProperty(name: "projection_type", @out: true, min: 0, max: 1)]
            public string @ProjectionType { get; }

            [nterraform.Core.TerraformProperty(name: "range_key", @out: true, min: 0, max: 1)]
            public string @RangeKey { get; }

            [nterraform.Core.TerraformProperty(name: "read_capacity", @out: true, min: 0, max: 1)]
            public int? @ReadCapacity { get; }

            [nterraform.Core.TerraformProperty(name: "write_capacity", @out: true, min: 0, max: 1)]
            public int? @WriteCapacity { get; }
        }

        public aws_dynamodb_table(string @name,
                                  attribute[] @attribute = null,
                                  global_secondary_index[] @globalSecondaryIndex = null,
                                  local_secondary_index[] @localSecondaryIndex = null,
                                  server_side_encryption[] @serverSideEncryption = null,
                                  ttl[] @ttl = null)
        {
            @Name = @name;
            @Attribute = @attribute;
            @GlobalSecondaryIndex = @globalSecondaryIndex;
            @LocalSecondaryIndex = @localSecondaryIndex;
            @ServerSideEncryption = @serverSideEncryption;
            @Ttl = @ttl;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "attribute", @out: false, min: 0, max: 0)]
        public attribute[] @Attribute { get; }

        [nterraform.Core.TerraformProperty(name: "global_secondary_index", @out: false, min: 0, max: 0)]
        public global_secondary_index[] @GlobalSecondaryIndex { get; }

        [nterraform.Core.TerraformProperty(name: "hash_key", @out: true, min: 0, max: 1)]
        public string @HashKey { get; }

        [nterraform.Core.TerraformProperty(name: "local_secondary_index", @out: false, min: 0, max: 0)]
        public local_secondary_index[] @LocalSecondaryIndex { get; }

        [nterraform.Core.TerraformProperty(name: "range_key", @out: true, min: 0, max: 1)]
        public string @RangeKey { get; }

        [nterraform.Core.TerraformProperty(name: "read_capacity", @out: true, min: 0, max: 1)]
        public int? @ReadCapacity { get; }

        [nterraform.Core.TerraformProperty(name: "server_side_encryption", @out: false, min: 0, max: 1)]
        public server_side_encryption[] @ServerSideEncryption { get; }

        [nterraform.Core.TerraformProperty(name: "stream_arn", @out: true, min: 0, max: 1)]
        public string @StreamArn { get; }

        [nterraform.Core.TerraformProperty(name: "stream_enabled", @out: true, min: 0, max: 1)]
        public bool? @StreamEnabled { get; }

        [nterraform.Core.TerraformProperty(name: "stream_label", @out: true, min: 0, max: 1)]
        public string @StreamLabel { get; }

        [nterraform.Core.TerraformProperty(name: "stream_view_type", @out: true, min: 0, max: 1)]
        public string @StreamViewType { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "ttl", @out: false, min: 0, max: 1)]
        public ttl[] @Ttl { get; }

        [nterraform.Core.TerraformProperty(name: "write_capacity", @out: true, min: 0, max: 1)]
        public int? @WriteCapacity { get; }
    }

}
